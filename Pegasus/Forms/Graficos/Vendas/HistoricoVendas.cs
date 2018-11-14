using Pegasus.Business.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pegasus.Controllers.Graficos.Vendas
{
    public partial class HistoricoVendas : Form
    {

        private string comando = null;
        public HistoricoVendas()
        {
            InitializeComponent();
        }

        public HistoricoVendas(DateTime de,DateTime ate)
        {
            InitializeComponent();
        }

        private void HistoricoVendas_Load(object sender, EventArgs e)
        {
            dtp_ate.MaxDate = DateTime.Now;
            dtp_de.MaxDate = DateTime.Now;

            /*  string[] seriesArray = { "Cats", "Dogs" };
              int[] pointsArray = { 1, 2 };

              // Set palette.
             // this.cht1.Palette = ChartColorPalette.SeaGreen;

              // Set title.
              this.cht1.Titles.Add("Pets");

              // Add series.
              for (int i = 0; i < seriesArray.Length; i++)
              {
                  // Add series.
                  Series series = this.cht1.Series.Add(seriesArray[i]);
                //  series.ChartType = SeriesChartType.Area;
                  // Add point.
                  series.Points.Add(pointsArray[i]);

              }
              */
        }

        private void tsb_imprimir_Click(object sender, EventArgs e)
        {
            
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += document_print;
            pd.DefaultPageSettings.Landscape = true;
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.Document = pd;
            if (MyPrintDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

           
        }


        private void document_print(object sender, PrintPageEventArgs e)
        {
          //  e.PageSettings.Landscape = true;
            e.Graphics.Clear(Color.White);
            
            Bitmap MyChartPanel = new Bitmap(cht1.Width, cht1.Height);
            cht1.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, cht1.Width, cht1.Height));
            e.Graphics.DrawImage(MyChartPanel,new Rectangle(0,0,e.PageBounds.Width,MyChartPanel.Height));
        }

     

        private void dtp_de_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ate_ValueChanged(object sender, EventArgs e)
        {
            dtp_de.MaxDate = dtp_ate.Value;
        }

        private void GerarGrafico()
        {
            if (comando == @"Vendas/por Produto")
            {
                VendaImplementation vi = new VendaImplementation();

                IList<Factory.Entities.Venda> vendas = vi.BuscarPorData(dtp_de.Value, dtp_ate.Value);
                IList<Factory.Entities.ProdutoVenda> produtos = new List<Factory.Entities.ProdutoVenda>();
                IList<Factory.Entities.Produto> prod = new List<Factory.Entities.Produto>();

                Int64 produtosVendidos = 0;

                foreach (Factory.Entities.Venda v in vendas)
                {
                    foreach (Factory.Entities.ProdutoVenda p in v.produtos)
                    {
                        if (!prod.Contains(p.produto))
                        {

                            p.produto.estoque.Clear();
                            prod.Add(p.produto);
                        }

                        Factory.Entities.ProdutoEstoque estoque = new Factory.Entities.ProdutoEstoque();
                        estoque.atual = p.quantidade;
                        produtosVendidos += (long)p.quantidade;
                        prod.Where(pv => pv.id == p.produto.id).First().estoque.Add(estoque);
                    }
                }

                foreach (Factory.Entities.Produto p in prod)
                {
                    Factory.Entities.ProdutoEstoque estoque = new Factory.Entities.ProdutoEstoque();

                    estoque.atual = (int)p.estoque.Sum(es => es.atual);
                }


                this.cht1.Titles.Add("Histórico de Vendas por Produto");
                this.cht1.Series.Clear();
                this.cht1.Legends.Clear();
                this.cht1.Titles.Clear();
                //Inicia novas configurações
                this.cht1.Series.Add("GraficoPizza");

                //Seta o tipo pizza
                this.cht1.Series["GraficoPizza"].ChartType = SeriesChartType.Pie;

                //Seta o texto de cima
                this.cht1.Series["GraficoPizza"].Font = new Font(this.cht1.Series["GraficoPizza"].Font.FontFamily, 18);



                //Adiciona Valores
                int x = 0;
                foreach (Factory.Entities.Produto prod1 in prod.Take(10).OrderByDescending(dt => dt.estoque.Sum(es => es.atual)))
                {
                    int perCent = ((int)((prod1.estoque.Sum(es => es.atual) / produtosVendidos) * 100));
                    this.cht1.Series["GraficoPizza"].Points.Add(perCent);
                    this.cht1.Series["GraficoPizza"].Points[x].Label = "Aproximadamente " + perCent + "% de vendas";
                    this.cht1.Series["GraficoPizza"].Points[x].LegendText = prod1.descricao;
                    this.cht1.Legends.Add(prod1.descricao);
                    x++;
                }

                // this.cht1.Series["GraficoPizza"].Points.Add(10);
                //  this.cht1.Series["GraficoPizza"].Points.Add(20);

                //Seta descrições da legenda

                //  this.cht1.Series["GraficoPizza"].Points[1].LegendText = "Valor do Exemplo 2";
                // this.cht1.Series["GraficoPizza"].Points[2].LegendText = "Valor do Exemplo 3";

                //Seta descrição em cada pedaço da pizza

                // this.cht1.Series["GraficoPizza"].Points[1].Label = "Porcentagem: 50%";
                //  this.cht1.Series["GraficoPizza"].Points[2].Label = "Porcentagem: 30%";

            }

            else if (comando == @"Vendas/Horario de Pico")
            {
                 VendaImplementation vi = new VendaImplementation();
                 IList<Factory.Entities.Venda> vendas = vi.BuscarPorData(dtp_de.Value, dtp_ate.Value);
               

                
                this.cht1.Series.Clear();
                this.cht1.Legends.Clear();
                this.cht1.Titles.Clear();
                //Inicia novas configurações
               Title title = this.cht1.Titles.Add("Historico de Vendas por Horario do dia " + dtp_de.Value.ToShortDateString() + " a " + dtp_ate.Value.ToShortDateString());

                title.Font = new Font(title.Font.FontFamily.Name.ToString(),18);
                Series series = this.cht1.Series.Add("Pico Vendas");
               

                // this.cht1.Series["Vendas por Horario"].ChartType = SeriesChartType.Column;

                for (int i = 0; i < 24; i++)
                 {

                     int x = vendas.Where(rs => rs.dtFinalizacao.Hour == i).Count();

                    
                   int y= series.Points.AddXY(i,x);
                    series.Points[y].AxisLabel = i.ToString()+":00";
                    series.Points[y].Label = x.ToString();
                    if(i==23)
                    {
                        series.Points[y].ToolTip = "Foram Realizadas " + x + " Venda(s) entre " + i + ":00 e 0:00";
                    }
                    else
                    {
                        series.Points[y].ToolTip = "Foram Realizadas " + x + " Venda(s) entre " + i + ":00 e " + (i + 1) + ":00";
                    }
                    
                    
                    series.LabelBackColor = Color.White;
                   
                }

                

                //this.cht1.AlignDataPointsByAxisLabel();
                this.cht1.ApplyPaletteColors();
                //cht1.ChartAreas[0].AxisX.MaximumAutoSize = 100;
                cht1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;
                cht1.ChartAreas[0].AxisX.Interval = 1;
                //this.cht1.ChartAreas[0].CursorX.AutoScroll = true;
                //cht1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                cht1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;

            }

            else if(comando == @"Vendas/por Dia")
            {

                VendaImplementation vi = new VendaImplementation();

                IList<Factory.Entities.Venda> vendas = vi.Buscar();
                DateTime carry = vendas.First().dtFinalizacao;
                int numeroVendas = 0, x = 0;

                this.cht1.Series.Clear();
                this.cht1.Legends.Clear();
                this.cht1.Titles.Clear();



                while (x < vendas.Count)
                {

                    if (carry.Date.ToShortDateString() == vendas[x].dtFinalizacao.Date.ToShortDateString())
                    {
                        numeroVendas++;
                    }
                    else
                    {
                        Series series = this.cht1.Series.Add(vendas[x].dtFinalizacao.Date.ToShortDateString());
                        series.Label = vendas[x].dtFinalizacao.Date.ToShortDateString() + "\n " + numeroVendas + " Venda(s) realizadas";
                        series.Points.Add(numeroVendas);


                        series.LabelBackColor = Color.White;
                        this.cht1.Legends.Add(vendas[x].dtFinalizacao.Date.ToShortDateString());
                        carry = vendas[x].dtFinalizacao;
                        numeroVendas = 0;
                    }



                    x++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarGrafico();
            MessageBox.Show(comando);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            comando = e.Node.FullPath;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] s = new char[] { '/' };
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += document_print;
            pd.DefaultPageSettings.Landscape = true;
            pd.PrinterSettings.PrintToFile = true;
           // pd.PrinterSettings.PrintFileName = comando.Split(s).Last();
            pd.Print();
        }

 
    }
}

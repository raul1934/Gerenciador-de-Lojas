using Pegasus.Business.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.FluxodeCaixa
{
    public partial class FluxoCaixa : Form
    {
        private CarregandoVisualização c;
        int differenceInDays = 0;
        DataTable dtv = new DataTable();
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        private int iCount;

        public FluxoCaixa()
        {
            InitializeComponent();
        }

      

        private void onload()
        {

            DateTime oldDate = new DateTime(dtp_de.Value.Year, dtp_de.Value.Month, dtp_de.Value.Day, 0, 0, 0);
            DateTime newDate = new DateTime(dtp_ate.Value.Year, dtp_ate.Value.Month, dtp_ate.Value.Day, 23, 59, 59);
            TimeSpan ts = newDate - oldDate;

            OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
            IList<Factory.Entities.OrdemServico> listOrdemServico = ordemServicoImplementation.getDatas(oldDate, newDate);

            IList<Factory.Entities.Venda> listVenda = new VendaImplementation().BuscarPorData(oldDate, newDate);
            dtv = new DataTable();
            dtv.TableName = "Fluxo de Caixa";
            dtv.Columns.Add("Contas", typeof(string));
            dtv.Columns.Add("1-Entradas - [G]", typeof(string));
            dtv.Columns.Add("Vendas à vista", typeof(string));
            dtv.Columns.Add("Vendas à prazo", typeof(string));
            dtv.Columns.Add("Emprestimos", typeof(string));
            dtv.Columns.Add("Outras Receitas", typeof(string));
            dtv.Columns.Add("Total das Entradas - [J]", typeof(string));
            dtv.Columns.Add("2-Saídas - [I]", typeof(string));
            dtv.Columns.Add("Compras à vista", typeof(string));
            dtv.Columns.Add("Compras à prazo", typeof(string));
            dtv.Columns.Add("Impostos", typeof(string));
            dtv.Columns.Add("Salários", typeof(string));
            dtv.Columns.Add("Comissões", typeof(string));
            dtv.Columns.Add("Outros Pagamentos", typeof(string));
            dtv.Columns.Add("Total das Saidas - [J]", typeof(string));
            dtv.Columns.Add("Saldo Inicial [K]", typeof(string));
            dtv.Columns.Add("(-) Total das Saidas - [J]", typeof(string));
            dtv.Columns.Add("(=) Saldo Final - [L]", typeof(string));








            differenceInDays = ts.Days;
            Decimal TotalVendasVista = 0;
            Decimal TotalVendasPrazo = 0;
            Decimal TotalComprasVista = 0;
            Decimal TotalComprasPrazo = 0;


            for (int index = 0; index <= differenceInDays; index++)
            {

                TotalVendasPrazo = 0;
                TotalVendasVista = 0;
                TotalComprasPrazo = 0;
                TotalComprasVista = 0;

                foreach (Factory.Entities.Venda v in listVenda)
                {
                    if (v.dtFinalizacao.ToShortDateString().Equals(oldDate.ToShortDateString()))
                    {
                        foreach (global::Pegasus.Factory.Entities.ProdutoVenda produtoVenda in v.produtos)
                        {
                            if (v.pagamentoAVista.Equals(true))
                            {
                                TotalVendasVista += (produtoVenda.produto.preco.Last().precoVendaVista * produtoVenda.quantidade) - produtoVenda.desconto;
                                TotalComprasVista += (produtoVenda.produto.preco.Last().precoVendaPrazo * produtoVenda.quantidade);

                            }
                            else
                            {
                                TotalVendasPrazo += (produtoVenda.produto.preco.Last().precoVendaPrazo * produtoVenda.quantidade) - produtoVenda.desconto;
                                TotalVendasPrazo += (produtoVenda.produto.preco.Last().precoVendaVista * produtoVenda.quantidade);
                            }

                        }

                    }
                }

                dtv.Rows.Add(new object[] { oldDate.ToShortDateString(),
                                             "",
                                             "R$ " + string.Format("{0:0.00}", TotalVendasVista),
                                             "R$ " + string.Format("{0:0.00}", TotalVendasPrazo),
                                             "R$ " + string.Format("{0:0.00}", 0),
                                             "R$ " + string.Format("{0:0.00}", 0),
                                             "R$ " + string.Format("{0:0.00}", TotalVendasPrazo + TotalVendasVista),
                                             "",
                                             "R$ " + string.Format("{0:0.00}", TotalComprasVista),
                                             "R$ " + string.Format("{0:0.00}", TotalComprasPrazo),
                                             "R$ " + string.Format("{0:0.00}", TotalComprasVista + TotalComprasPrazo)});

                oldDate = oldDate.AddDays(1);



            }
            this.Invoke((MethodInvoker)delegate
            {
                dgv_Principal.DataSource = dtv;

            });
        }
    

            private void dtp_de_ValueChanged(object sender, EventArgs e)
        {
            using (CarregandoVisualização c = new CarregandoVisualização(onload))
            {
                c.ShowDialog(this);

            }
        }

        private void dtp_ate_ValueChanged(object sender, EventArgs e)
        {
            using (CarregandoVisualização c = new CarregandoVisualização(onload))
            {
                c.ShowDialog(this);

            }
        }

        public DataTable FlipDataSet(DataTable dt)
        {
            DataTable ds = new DataTable();


            ds.Columns.Add("Contas");
            for (int i = 0; i < dt.Rows.Count; i++)
            { ds.Columns.Add(""); }

            DataRow r;
            for (int k = 0; k < dt.Columns.Count; k++)
            {
                r = ds.NewRow();
                r[0] = dt.Columns[k].ToString();
                for (int j = 1; j <= dt.Rows.Count; j++)
                { r[j] = dt.Rows[j - 1][k]; }
                ds.Rows.Add(r);
            }



            return ds;
        }

      

        private void tsb_imprimir_Click(object sender, EventArgs e)
        {
           
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDocument1.DefaultPageSettings.Landscape = true;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            try
            {
                //Set the left margin
                int iLeftMargin = 10;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgv_Principal.Columns)
                    {
                        /* iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                             (double)iTotalWidth * (double)iTotalWidth *
                             ((double)e.MarginBounds.Width / (double)iTotalWidth)))); */

                        iTmpWidth = (int)(1090 / 18);

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgv_Principal.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgv_Principal.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Customer Summary",
                                new Font(dgv_Principal.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                                new Font(dgv_Principal.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(dgv_Principal.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(dgv_Principal.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("Customer Summary",
                                new Font(new Font(dgv_Principal.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgv_Principal.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgv_Principal.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

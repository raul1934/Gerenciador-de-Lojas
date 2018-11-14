using Pegasus.Business.Implementation;
using Pegasus.Factory.Entities;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Business
{
   public class ImprimirRelatorioEstoque
    {
        private IList<global::Pegasus.Factory.Entities.Produto> produtos;
        private OrdemServico ordemServico;
        private static Font h1,h2,h3,h4;
        private static Pen p;

        public ImprimirRelatorioEstoque(IList<global::Pegasus.Factory.Entities.Produto> produtos)
        {
            this.produtos = produtos;
            PrintDocument documento = new PrintDocument();
            documento.BeginPrint += document_BeginPrint;
            documento.EndPrint += document_EndPrint;
            documento.PrintPage += document_PrintPage;

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = documento;
            
            dialog.AutoSizeMode = AutoSizeMode.GrowOnly;
            ((Form)dialog).Text = "Imprimir Relatorio de Estoque - "+ DateTime.Now.ToShortDateString();
            ((Form)dialog).WindowState = FormWindowState.Maximized;
            
            dialog.UseAntiAlias = true;
            dialog.ShowIcon = false;

            dialog.ShowDialog();
        }

        static void document_BeginPrint(object sender, PrintEventArgs e)
        {
             
            
            h1 = new Font("Times New Roman", 24);
            h2 = new Font("Times New Roman", 14, FontStyle.Bold);
            h3 = new Font("Times New Roman", 10, FontStyle.Bold);
            h4 = new Font("Times New Roman", 8);
            p = Pens.Black;
        }

        static void document_EndPrint(object sender, PrintEventArgs e)
        {
            h1.Dispose();
            h2.Dispose();
            h3.Dispose();
            h4.Dispose();
        }
     private  void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            EmpresaImplementation ep = new EmpresaImplementation();
            Empresa empresa = ep.Buscar().First();
            e.Graphics.Clear(Color.White);
            Stream stream = new MemoryStream(empresa.logo);
            Image im = Image.FromStream(stream);
            e.Graphics.DrawImage(im, new Rectangle(20, 30, 260, 130));
         
            
            e.Graphics.DrawString("Relatório - Saldo em Estoque", h1, new SolidBrush(Color.Black),290, 30f);
            SizeF pos = new SizeF();
           pos = e.Graphics.MeasureString("Relatório - Saldo em Estoque", h1);
            e.Graphics.DrawString("Organizado por Ordem Alfabética", h2, new SolidBrush(Color.Black), (290)+pos.Width/2- e.Graphics.MeasureString("Organizado por Ordem Alfabética", h2).Width/2, 70f);
            e.Graphics.DrawString("Estoque Relativo a "+ DateTime.Now.ToShortDateString(), h2, new SolidBrush(Color.Black), (290) + pos.Width / 2 - e.Graphics.MeasureString("Estoque Relativo a " + DateTime.Now.ToShortDateString(), h2).Width / 2, 100f);

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(20, 190, e.PageBounds.Width - 40, 40));
            
            int height = 190;
            
            e.Graphics.DrawLine(p, 20f, height, 20f, e.PageBounds.Height-90);
            e.Graphics.DrawLine(p, 130f, height, 130f, e.PageBounds.Height-90);
            e.Graphics.DrawLine(p, 500f, height, 500f, e.PageBounds.Height-90);
            e.Graphics.DrawLine(p, 600f, height, 600f, e.PageBounds.Height-90);
            e.Graphics.DrawLine(p, 700f, height, 700f, e.PageBounds.Height-90);
            e.Graphics.DrawLine(p, e.PageBounds.Width - 20, height, e.PageBounds.Width-20, e.PageBounds.Height  - 90);
            e.Graphics.DrawLine(p, 20f, height, e.PageBounds.Width - 20, height);
            e.Graphics.DrawLine(p, 20f, 230, e.PageBounds.Width - 20, 230);
            e.Graphics.DrawLine(p, 20f, e.PageBounds.Height - 90, e.PageBounds.Width - 20, e.PageBounds.Height - 90);

            height += 15;
            e.Graphics.DrawString("Classe",h2,new SolidBrush(Color.White),50f, height);
            e.Graphics.DrawString("Descrição", h2, new SolidBrush(Color.White), 160f, height);
            e.Graphics.DrawString("Qtd", h2, new SolidBrush(Color.White),530f, height);
            e.Graphics.DrawString("Unitário", h2, new SolidBrush(Color.White), 610f, height);
            e.Graphics.DrawString("Total", h2, new SolidBrush(Color.White), 730f, height);

            height +=35;
            
            foreach(global::Pegasus.Factory.Entities.Produto produto in produtos)
            {
                
               
                if(produto.descricao.Length>55)
                {
                    e.Graphics.DrawString(produto.descricao.Substring(0, 56), h3, new SolidBrush(Color.Black), 140, height);
                }
                else
                {
                    e.Graphics.DrawString(produto.descricao, h3, new SolidBrush(Color.Black), 140, height);
                }
                
                e.Graphics.DrawString(Math.Round( produto.estoque.Last().atual,2)+" "+produto.unidadeMedida, h3, new SolidBrush(Color.Black), 510, height);
                e.Graphics.DrawString(Funcoes.formatarParaMoeda(produto.preco.Last().precoVendaVista.ToString()), h3, new SolidBrush(Color.Black), 610, height);
                e.Graphics.DrawString(Funcoes.formatarParaMoeda((produto.preco.Last().precoVendaVista * Decimal.Parse(produto.estoque.Last().atual.ToString())).ToString()), h3, new SolidBrush(Color.Black), 710, height);
               
                height += 15;
                e.Graphics.DrawLine(p, 20f, height, e.PageBounds.Width - 20, height);
                height += 15;
            }
        }

    }
}

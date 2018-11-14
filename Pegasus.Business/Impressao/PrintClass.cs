using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Business
{
   public class PrintClass 
    {
        private OrdemServico ordemServico;
        private static Font h1,h2,h3,h4;
        public PrintClass(OrdemServico ordemServico)
        {
            this.ordemServico = ordemServico;
            PrintDocument documento = new PrintDocument();
            documento.BeginPrint += document_BeginPrint;
            documento.EndPrint += document_EndPrint;
            documento.PrintPage += document_PrintPage;

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = documento;
            dialog.ShowDialog();

        }
        public PrintClass()
        {
            PrintDocument documento = new PrintDocument();
            documento.BeginPrint += document_BeginPrint;
            documento.EndPrint += document_EndPrint;
            documento.PrintPage += document_PrintPage;

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = documento;
            dialog.ShowDialog();
        }

        static void document_BeginPrint(object sender, PrintEventArgs e)
        {
            h1 = new Font("Comic Sans", 20);
            h2 = new Font("Comic Sans", 12);
            h3 = new Font("Comic Sans", 10);
            h4 = new Font("Comic Sans", 8);
        }

        static void document_EndPrint(object sender, PrintEventArgs e)
        {
            h1.Dispose();
            h2.Dispose();
            h2.Dispose();
        }
     private  void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            SizeF tamanho = e.Graphics.MeasureString("Luna e Raul Restaurante ME", h1);

            float posicao = ((e.PageBounds.Width)-(e.PageBounds.Width / 3)) - (tamanho.Width / 2);

            e.Graphics.DrawString("Luna e Raul Restaurante ME", h1, new SolidBrush(Color.Black), posicao, 10f);
            
            tamanho = e.Graphics.MeasureString("CNPJ: 78.423.718 / 0001 - 88", h2);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("CNPJ: 78.423.718 / 0001 - 88", h2, new SolidBrush(Color.Black), posicao, 40f);

            tamanho = e.Graphics.MeasureString("R: Viela Francisco Enande, 329 Bairro: Vila Júlia Cid: Poá", h3);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("R: Viela Francisco Enande, 329 Bairro: Vila Júlia Cid: Poá", h3, new SolidBrush(Color.Black), posicao, 60f);
            e.Graphics.DrawString("Orçamento nº: 0005", h2, new SolidBrush(Color.Black), 460, 100);
            tamanho = e.Graphics.MeasureString("Tel: (11) 3941-5889 Cel:(11) 99683-7109", h2);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("Tel: (11) 3941-5889 Cel:(11) 99683-7109", h2, new SolidBrush(Color.Black), posicao, 80f);
            //desenhar o retangulo do cliente
            e.Graphics.DrawString("Cliente:", h2, new SolidBrush(Color.Black), 40, 110f);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 130, e.PageBounds.Width, 80));
            
            e.Graphics.DrawString("Nome: "+ordemServico.cliente.nome, h3, new SolidBrush(Color.Black), 40, 140);
            e.Graphics.DrawString("CPF/CNPJ: "+ordemServico.cliente.cpfCnpj, h3, new SolidBrush(Color.Black), (40+ e.Graphics.MeasureString("Nome:", h3).Width)-e.Graphics.MeasureString("CPF/CNPJ:", h3).Width, 155);
            e.Graphics.DrawString("RG/IE: "+ordemServico.cliente.rgIe, h3, new SolidBrush(Color.Black),230, 155);
            e.Graphics.DrawString("Endereco: "+ordemServico.cliente.endereco+" ,"+ordemServico.cliente.numero, h3, new SolidBrush(Color.Black), (40 + e.Graphics.MeasureString("Nome:", h3).Width) - e.Graphics.MeasureString("Endereço:", h3).Width, 170);
            e.Graphics.DrawString("Bairro: "+ordemServico.cliente.bairro, h3, new SolidBrush(Color.Black), (40 + e.Graphics.MeasureString("Nome:", h3).Width) - e.Graphics.MeasureString("Bairro:", h3).Width, 185);
            e.Graphics.DrawString("Cidade: "+ordemServico.cliente.cidade+"-"+ordemServico.cliente.estado.uf, h3, new SolidBrush(Color.Black), (230 + e.Graphics.MeasureString("RG/IE::", h3).Width) - e.Graphics.MeasureString("Cidade:", h3).Width, 185);
            e.Graphics.DrawString("Entrada: "+ordemServico.dataInicio, h2, new SolidBrush(Color.Black), e.PageBounds.Width-250, 140);
            e.Graphics.DrawString("Saida: "+ordemServico.dataFim, h2, new SolidBrush(Color.Black), (e.PageBounds.Width-250+e.Graphics.MeasureString("Entrada:",h2).Width)- e.Graphics.MeasureString("Saida:", h2).Width, 160);
        
            // desenhar o retangulo do veiculo
            e.Graphics.DrawString("Veiculo:", h2, new SolidBrush(Color.Black), 40, 225);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 245, e.PageBounds.Width,80));

            

            e.Graphics.DrawString("Cod:", h2, new SolidBrush(Color.Black), 40, 325);
            e.Graphics.DrawString("Descrição:", h2, new SolidBrush(Color.Black), 175, 325);
            e.Graphics.DrawString("Qtd:", h2, new SolidBrush(Color.Black), 440, 325);
            e.Graphics.DrawString("Unitario:", h2, new SolidBrush(Color.Black), 495, 325);
            e.Graphics.DrawString("Desconto:", h2, new SolidBrush(Color.Black), 600, 325);
            e.Graphics.DrawString("Total:", h2, new SolidBrush(Color.Black), e.PageBounds.Width-(e.Graphics.MeasureString("Total:", h2).Width*2), 325);

            int x = 335;
            foreach (Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
            {
                x += 25;
                e.Graphics.DrawString(produto.produto.codigoBarras, h4, new SolidBrush(Color.Black), 40, x);
                e.Graphics.DrawString(produto.produto.descricao, h4, new SolidBrush(Color.Black), 175, x);
                e.Graphics.DrawString(produto.quantidade.ToString(), h4, new SolidBrush(Color.Black), 440, x);
                e.Graphics.DrawString(produto.produto.preco.Last().precoVendaVista.ToString(), h4, new SolidBrush(Color.Black), 495, x);
                e.Graphics.DrawString(produto.desconto.ToString(), h4, new SolidBrush(Color.Black), 600, x);
                e.Graphics.DrawString(((produto.produto.preco.Last().precoVendaVista -produto.desconto)*produto.quantidade).ToString(), h4, new SolidBrush(Color.Black), e.PageBounds.Width - (e.Graphics.MeasureString("Total:", h2).Width * 2), x);
            }

            e.Graphics.DrawString("Declaro ter autorizado:", h3, new SolidBrush(Color.Black), 40, (e.PageBounds.Height - 200));
            e.Graphics.DrawString("Luna e Raul Restaurante ME", h2, new SolidBrush(Color.Black), 40, (e.PageBounds.Height - 180));
            e.Graphics.DrawString("a executar o(s) Serviço(s) acima descrito \nconforme o ORÇAMENTO N:º 0005 em meu veiculo \n\n\nSegunda-Feira, 18 de fevereiro de 2017", h3, new SolidBrush(Color.Black), 40, (e.PageBounds.Height - 160));


        }

    }
}

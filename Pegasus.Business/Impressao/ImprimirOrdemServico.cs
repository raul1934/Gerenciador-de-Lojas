using Pegasus.Factory.Entities;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Business.Impressao
{
   public class ImprimirOrdemServico
    {
        private OrdemServico ordemServico;
        private static Font h1, h2, h3, h4;

        public ImprimirOrdemServico(global::Pegasus.Factory.Entities.OrdemServico ordemServico)
        {
            this.ordemServico = ordemServico;
            PrintDocument documento = new PrintDocument();
            documento.BeginPrint += document_BeginPrint;
            documento.EndPrint += document_EndPrint;
            documento.PrintPage += document_PrintPage;

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = documento;
            dialog.AutoSizeMode = AutoSizeMode.GrowOnly;
            dialog.UseAntiAlias = true;

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
            h3.Dispose();
            h4.Dispose();
        }
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            SizeF tamanho = e.Graphics.MeasureString("Luna e Raul Restaurante ME", h1);

            float posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);

            e.Graphics.DrawString("Luna e Raul Restaurante ME", h1, new SolidBrush(Color.Black), posicao, 10f);

            tamanho = e.Graphics.MeasureString("CNPJ: 78.423.718 / 0001 - 88", h2);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("CNPJ: 78.423.718 / 0001 - 88", h2, new SolidBrush(Color.Black), posicao, 40f);

            tamanho = e.Graphics.MeasureString("R: Viela Francisco Enande, 329 Bairro: Vila Júlia Cid: Poá", h3);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("R: Viela Francisco Enande, 329 Bairro: Vila Júlia Cid: Poá", h3, new SolidBrush(Color.Black), posicao, 60f);
            e.Graphics.DrawString("Orçamento nº: "+ordemServico.id, h2, new SolidBrush(Color.Black), 460, 100);
            tamanho = e.Graphics.MeasureString("Tel: (11) 3941-5889 Cel:(11) 99683-7109", h2);
            posicao = ((e.PageBounds.Width) - (e.PageBounds.Width / 3)) - (tamanho.Width / 2);
            e.Graphics.DrawString("Tel: (11) 3941-5889 Cel:(11) 99683-7109", h2, new SolidBrush(Color.Black), posicao, 80f);

            //desenhar o retangulo do cliente
            e.Graphics.DrawString("Cliente.", h2, new SolidBrush(Color.Black), 40, 110f);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 130, e.PageBounds.Width, 80));

            e.Graphics.DrawString("Nome: " + ordemServico.cliente.nome, h3, new SolidBrush(Color.Black), 40, 140);
            e.Graphics.DrawString("CPF/CNPJ: " + ordemServico.cliente.cpfCnpj, h3, new SolidBrush(Color.Black), (40 + e.Graphics.MeasureString("Nome:", h3).Width) - e.Graphics.MeasureString("CPF/CNPJ:", h3).Width, 155);
            e.Graphics.DrawString("RG/IE: " + ordemServico.cliente.rgIe, h3, new SolidBrush(Color.Black), 230, 155);
            e.Graphics.DrawString("Endereco: " + ordemServico.cliente.endereco + " ," + ordemServico.cliente.numero, h3, new SolidBrush(Color.Black), (40 + e.Graphics.MeasureString("Nome:", h3).Width) - e.Graphics.MeasureString("Endereço:", h3).Width, 170);
            e.Graphics.DrawString("Bairro: " + ordemServico.cliente.bairro, h3, new SolidBrush(Color.Black), (40 + e.Graphics.MeasureString("Nome:", h3).Width) - e.Graphics.MeasureString("Bairro:", h3).Width, 185);
            e.Graphics.DrawString("Cidade: " + ordemServico.cliente.cidade.nome + "-" + ordemServico.cliente.estado.uf, h3, new SolidBrush(Color.Black), (230 + e.Graphics.MeasureString("RG/IE::", h3).Width) - e.Graphics.MeasureString("Cidade:", h3).Width, 185);
            e.Graphics.DrawString("Entrada: " + ordemServico.dataInicio, h2, new SolidBrush(Color.Black), e.PageBounds.Width - 250, 140);
            e.Graphics.DrawString("Saida: " + ordemServico.dataFim, h2, new SolidBrush(Color.Black), (e.PageBounds.Width - 250 + e.Graphics.MeasureString("Entrada:", h2).Width) - e.Graphics.MeasureString("Saida:", h2).Width, 160);

            // desenhar o retangulo do veiculo
            e.Graphics.DrawString("Veiculo.", h2, new SolidBrush(Color.Black), 40, 225);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 245, e.PageBounds.Width, 80));

           

            e.PageSettings.Margins = new Margins(20, 20, 20, 20);

            e.Graphics.DrawString("Informações da O.S.", h2, new SolidBrush(Color.Black),e.PageBounds.Width/2- e.Graphics.MeasureString("Informações da O.S.", h2).Width/2,330);
            //if (e.Graphics.MeasureString("Defeito Relatado: " + ordemServico.defeitoRelatado, h3, e.PageBounds.Width - 40)
                

            e.Graphics.DrawString("Defeito Relatado: "+ordemServico.defeitoRelatado, h3, new SolidBrush(Color.Black), 20, 370);
            e.Graphics.DrawString("Defeito Constatado: " + ordemServico.defeitoConstatado, h3, new SolidBrush(Color.Black), 20, 450);


            e.Graphics.DrawString("Classe", h2, new SolidBrush(Color.Black), 20f, 530f);
            e.Graphics.DrawString("Descrição", h2, new SolidBrush(Color.Black), 130f, 530f);
            e.Graphics.DrawString("Qtd", h2, new SolidBrush(Color.Black), 500f, 530f);
            e.Graphics.DrawString("Un", h2, new SolidBrush(Color.Black), 550f, 530f);
            e.Graphics.DrawString("Unitário", h2, new SolidBrush(Color.Black), 600f, 530f);
            e.Graphics.DrawString("Total", h2, new SolidBrush(Color.Black), 700f, 530f);

            int height = 560;
            foreach (global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
            {
                
                e.Graphics.DrawString(produto.produto.descricao, h3, new SolidBrush(Color.Black), 130, height);
                e.Graphics.DrawString(produto.quantidade.ToString(), h3, new SolidBrush(Color.Black), 500, height);
                e.Graphics.DrawString(produto.produto.unidadeMedida, h3, new SolidBrush(Color.Black), 550, height);
                e.Graphics.DrawString(Funcoes.formatarParaMoeda(produto.produto.preco.Last().precoVendaVista.ToString()), h3, new SolidBrush(Color.Black), 600, height);
                e.Graphics.DrawString(Funcoes.formatarParaMoeda((produto.produto.preco.Last().precoVendaVista * Decimal.Parse(produto.produto.estoque.Last().atual.ToString())).ToString()), h3, new SolidBrush(Color.Black), 700, height);
                height += 25;
            }

        }

    }
}


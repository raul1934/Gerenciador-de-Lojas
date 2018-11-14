

using NHibernate.Linq;
using Pegasus.Business.Implementation;
using Pegasus.Business.Impressao;

using Pegasus.Controllers.Produtos;

using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Pegasus.Controllers.OrdemServico
{
    public partial class VisualizarOrdemServico : Form
    {
        private Decimal Total = 0, TotalProduto = 0, TotalServico = 0, TotalDescontoProduto = 0, TotalDescontoServico = 0, TotalImpostosServicos = 0, TotalImpostosProdutos = 0;
        private OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
        private global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        private global::Pegasus.Factory.Entities.Empresa empresa { get; set; }
        private IList<global::Pegasus.Factory.Entities.ProdutoVenda> produtos = new List<Factory.Entities.ProdutoVenda>();
        public VisualizarOrdemServico(global::Pegasus.Factory.Entities.OrdemServico ordemServico)
        {
            InitializeComponent();
            empresa = new Factory.Entities.Empresa();
            EmpresaImplementation e = new EmpresaImplementation();
            empresa =e.BuscarId(1);
            ordemServico.produtos.ForEach((rs) =>
            {
                produtos.Add(rs);
            });
            this.ordemServico = ordemServico;
            btn_Cliente.Enabled = false;
            txt_cliente.Text = ordemServico.cliente.nome;
            if(ordemServico.defeitoRelatado!=null)
            {
                chb_defeitoRelatado.Checked = true;
                txt_defeitoRelatado.Text = ordemServico.defeitoRelatado;
            }
            else
            {
                txt_defeitoRelatado.Enabled = false;
            }
            if (ordemServico.defeitoConstatado != null)
            {
                chb_defeitoConstatado.Checked = true;
                txt_defeitoConstatado.Text = ordemServico.defeitoConstatado;
            }
            else
            {
                txt_defeitoConstatado.Enabled = false;
            }
            if (ordemServico.servicosRealizados != null)
            {
                chb_servicosRealizados.Checked = true;
                txt_servicosRealizados.Text = ordemServico.servicosRealizados;
            }
            else
            {
                txt_servicosRealizados.Enabled = false;
            }
            if (ordemServico.observacoes != null)
            {
                chb_observacoes.Checked = true;
                txt_observacoes.Text = ordemServico.observacoes;
            }
            else
            {
                txt_observacoes.Enabled = false;
            }
           

            if(ordemServico.situacao==0)
            {
                tsb_imprimir.Enabled = false;
            }
            else if(ordemServico.situacao==1)
            {
                tsb_imprimir.Enabled = true;
                tsb_iniciarVenda.Enabled = false;
            }
            txt_numeroOS.Text = ordemServico.id.ToString();
            txt_funcionario.Text = ordemServico.funcionario.nome;
            txt_defeitoConstatado.Text = ordemServico.defeitoConstatado;
            txt_defeitoRelatado.Text = ordemServico.defeitoRelatado;
            dtp_entrada.Value = ordemServico.dataInicio;
            dtp_saida.Value = ordemServico.dataFim;
            txt_servicosRealizados.Text = ordemServico.servicosRealizados;
            txt_observacoes.Text = ordemServico.observacoes;

            /*
             * Em Aberto
               Finalizado
               Cancelado
               Aguardando Pagamento
             * */
            if (ordemServico.situacao == 0)
            {
                txt_situacao.Text = "Em Aberto";
            }
            else if(ordemServico.situacao ==1)
            {
                txt_situacao.Text = "Finalizado";
            }
            else if(ordemServico.situacao == 2)
            {
                txt_situacao.Text = "Cancelado";
            }
            else
            {
                txt_situacao.Text = "Aguardando Pagamento";
            }

            Carregar();
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           


           // NFe.Classes.NFe nfe = new NFe.Classes.NFe();
          //  nfe =  Funcoes.EmitirNFe(ordemServico, empresa);
          //  SaveFileDialog d = new SaveFileDialog();
          //  d.ShowDialog();
          //  d.Filter = ".xml | .XML";
          //  d.InitialDirectory = "C:\\";
          //  System.IO.StreamWriter file = new System.IO.StreamWriter(d.FileName);
          //  file.WriteLine(NFe.Utils.NFe.ExtNFe.ObterXmlString(nfe));

        //    file.Close();
             
        }

        private void VisualizarOrdemServico_Load(object sender, EventArgs e)
        {

        }

        private void chb_defeitoReladado_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_defeitoRelatado.Enabled = true;
            }
            else
            {
                txt_defeitoRelatado.Enabled = false;
            }

        }

        private void chb_defeitoConstatado_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_defeitoConstatado.Enabled = true;
            }
            else
            {
                txt_defeitoConstatado.Enabled = false;
            }

        }

        private void chb_servicosRealizados_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_servicosRealizados.Enabled = true;
            }
            else
            {
                txt_servicosRealizados.Enabled = false;
            }

        }

        private void chb_observacoes_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                txt_observacoes.Enabled = true;
            }
            else
            {
                txt_observacoes.Enabled = false;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ordemServico.dataInicio = dtp_entrada.Value;
            ordemServico.dataFim = dtp_saida.Value;
            ordemServico.situacao = 0;
              ProdutoImplementation productImplementation = new ProdutoImplementation();
            if(ordemServico.produtos.Count>0)
            {
                foreach (global::Pegasus.Factory.Entities.ProdutoVenda pv in ordemServico.produtos)
                {
                    var produto = produtos.Where(rs => rs.produto.id == pv.produto.id).FirstOrDefault();
                    if (produto != null && pv.produto.id == produto.produto.id)
                    {
                        if (produto.quantidade != pv.quantidade)
                        {
                            if (produto.quantidade > pv.quantidade)
                            {
                                global::Pegasus.Factory.Entities.Produto p = productImplementation.BuscarId(pv.produto.id);
                                p.estoque.Last().atual += (produto.quantidade - pv.quantidade);
                                productImplementation.Atualizar(p);
                            }
                            else
                            {
                                global::Pegasus.Factory.Entities.Produto p = productImplementation.BuscarId(pv.produto.id);
                                p.estoque.Last().atual -= (pv.quantidade - produto.quantidade);
                                productImplementation.Atualizar(p);
                            }
                        }
                    }
                    else
                    {
                        global::Pegasus.Factory.Entities.Produto p = productImplementation.BuscarId(pv.produto.id);
                        p.estoque.Last().atual -= (pv.quantidade);
                        productImplementation.Atualizar(p);
                    }
                }
            }
            else
            {
                produtos.ForEach((rs) =>
                {
                    global::Pegasus.Factory.Entities.Produto p = productImplementation.BuscarId(rs.produto.id);
                    p.estoque.Last().atual += (rs.quantidade);
                    productImplementation.Atualizar(p);
                });
                
            }
              
            ordemServicoImplementation = new OrdemServicoImplementation();

            ordemServicoImplementation.Atualizar(ordemServico);
           
            this.DialogResult = DialogResult.OK; 
            this.Close();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novoProduto_Click(object sender, EventArgs e)
        {
            SelecionarProduto selecionarProduto = new SelecionarProduto();
            selecionarProduto.ShowIcon = false;
            selecionarProduto.ShowInTaskbar = false;


            if (selecionarProduto.ShowDialog(this) == DialogResult.OK)
            {
                var produto = ordemServico.produtos.Where(rs => rs.produto.id == selecionarProduto.produto.produto.id).FirstOrDefault();

                if (produto == null)
                {
                    ordemServico.produtos.Add(selecionarProduto.produto);
                }
                else
                {
                    ordemServico.produtos.Remove(produto);

                    ordemServico.produtos.Add(selecionarProduto.produto);
                }

                Carregar();
            }
        }

        private void btn_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgv_Produtos.SelectedRows[0] != null && dgv_Produtos.Rows.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja excluir o produto selecionado.", "Confirmar exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var produto = ordemServico.produtos.Where(rs => rs.id == int.Parse(dgv_Produtos.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault();
                    ordemServico.produtos.Remove(produto);
                    Carregar();
                }
            }
        }

        private void tsb_imprimir_Click(object sender, EventArgs e)
        {
            if (chb_defeitoConstatado.Checked)
            {
                ordemServico.defeitoConstatado = txt_defeitoConstatado.Text;
            }

            if (chb_defeitoRelatado.Checked)
            {
                ordemServico.defeitoRelatado = txt_defeitoRelatado.Text;
            }

            if (chb_observacoes.Checked)
            {
                ordemServico.observacoes = txt_observacoes.Text;
            }
            if (chb_servicosRealizados.Checked)
            {
                ordemServico.servicosRealizados = txt_servicosRealizados.Text;
            }

            ordemServico.dataInicio = dtp_entrada.Value;
            ordemServico.dataFim = dtp_saida.Value;
            ImprimirOrdemServico imprimirOrdemServico = new ImprimirOrdemServico(ordemServico);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (ordemServico.situacao == 0)
            {

                if (MessageBox.Show(this, "A situação da venda sera alterada para aguardando Pagamento. \n Deseja Continuar?", "Erro ao Iniciar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ordemServico.situacao = 3;
                    ordemServico.dataInicio = dtp_entrada.Value;
                    ordemServico.dataFim = dtp_saida.Value;
                    NovaVenda finalizaros = new NovaVenda();
                    ordemServico.situacao = 3;
                    new OrdemServicoImplementation().Atualizar(ordemServico);
                    finalizaros.ShowIcon = false;
                    finalizaros.ShowInTaskbar = false;
                    if (finalizaros.ShowDialog(this) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                ordemServico.situacao = 3;
                ordemServico.dataInicio = dtp_entrada.Value;
                ordemServico.dataFim = dtp_saida.Value;
                NovaVenda finalizaros = new NovaVenda();
                finalizaros.ShowIcon = false;
                finalizaros.ShowInTaskbar = false;
                if (finalizaros.ShowDialog(this) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Carregar()
        {
            Total = 0;
            TotalProduto = 0;
            TotalServico = 0;
            TotalDescontoProduto = 0;
            TotalDescontoServico = 0;
            TotalImpostosServicos = 0;
            TotalImpostosProdutos = 0;
            dgv_servicos.Rows.Clear();
            
            int x = 1;
            foreach (global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
            {

                TotalProduto += produto.produto.preco.Last().precoVendaVista * produto.quantidade;
                //TotalImpostosServicos += prodiuto.servico.preco.Last().valorISSQN;
                TotalDescontoProduto += produto.desconto;
                dgv_Produtos.Rows.Add(produto.id, x, produto.produto.descricao, produto.quantidade, produto.produto.preco.Last().precoVendaVista);
                x += 1;
            }

            lbl_produtosProdutos.Text = Funcoes.formatarParaMoeda(TotalProduto.ToString());
            lbl_descontosProdutos.Text = Funcoes.formatarParaMoeda(TotalDescontoProduto.ToString());
            lbl_totalProdutos.Text = Funcoes.formatarParaMoeda((TotalProduto - TotalDescontoProduto).ToString());

            lbl_totalValorProduto.Text = Funcoes.formatarParaMoeda(TotalProduto.ToString());
            lbl_totalProdutoImpostos.Text = Funcoes.formatarParaMoeda(0.ToString());
            lbl_totalProdutoDesconto.Text = Funcoes.formatarParaMoeda(TotalDescontoProduto.ToString());
            lbl_totalprodutototal.Text = Funcoes.formatarParaMoeda(TotalProduto.ToString());
            lbl_totalServicos.Text = Funcoes.formatarParaMoeda(TotalServico.ToString());
            lbl_totalImpostos.Text = Funcoes.formatarParaMoeda(TotalImpostosProdutos.ToString());
            lbl_totalDescontos.Text = Funcoes.formatarParaMoeda(TotalDescontoServico.ToString());
            lbl_totalServicoTotal.Text = Funcoes.formatarParaMoeda((TotalServico - TotalDescontoServico).ToString());
            lbl_OrdemServicoSubtotal.Text = Funcoes.formatarParaMoeda((TotalServico + TotalProduto).ToString());
            lbl_OrdemServicosImpostos.Text = Funcoes.formatarParaMoeda((TotalImpostosProdutos + TotalImpostosServicos).ToString());
            lbl_OrdemServicoDescontos.Text = Funcoes.formatarParaMoeda((TotalDescontoProduto + TotalDescontoServico).ToString());
            lbl_OrdemServicoTotal.Text = Funcoes.formatarParaMoeda(((TotalProduto - TotalDescontoProduto) + (TotalServico - TotalDescontoServico)).ToString());
        }
    }
}

using Pegasus.Business.Implementation;
using Pegasus.Business.Impressao;
using Pegasus.Controllers.Cliente;
using Pegasus.Controllers.Produtos;
using Pegasus.Controllers.Relatorio.Estoque;

using Pegasus.Factory.Entities;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pegasus.Controllers.OrdemServico
{
    public partial class NovaOrdemServiço : Form
    {
        private global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        private OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
        private Decimal Total = 0, TotalProduto = 0, TotalServico = 0, TotalDescontoProduto = 0, TotalDescontoServico = 0, TotalImpostosServicos = 0, TotalImpostosProdutos = 0;
        public NovaOrdemServiço()
        {
            InitializeComponent();
            ordemServico = new Factory.Entities.OrdemServico();
            txt_defeitoRelatado.Enabled = false;
            txt_defeitoConstatado.Enabled = false;
            txt_servicosRealizados.Enabled = false;
            txt_observacoes.Enabled = false;
            ordemServico.situacao = 0;
            ordemServico.cliente = null;
        }
        /*
        private void carregarDataGridView()
        {
            dgv_Produtos.Rows.Clear();
            total = 0;
            foreach (global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
            {
                dgv_Produtos.Rows.Add(produto.id, dgv_Produtos.Rows.Count + 1, produto.produto.descricao, produto.quantidade, produto.produto.preco.Last().precoVendaVista.ToString("C"), (produto.quantidade*produto.produto.preco.Last().precoVendaVista).ToString("C"));
                total += (produto.produto.preco.Last().precoVendaVista * produto.quantidade);
            }
            //lbl_Total.Text = "TOTAL: "+total.ToString("C");
        }
        */
        

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            
        }


        private void salvarOs()

        {
            if(ordemServico.cliente !=null)
            {
                ordemServico.dataInicio = dtp_entrada.Value;
                ordemServico.dataFim = dtp_saida.Value;
                ordemServico.situacao = 0;
                if (!string.IsNullOrWhiteSpace(txt_defeitoConstatado.Text))
                {
                    ordemServico.defeitoConstatado = txt_defeitoConstatado.Text;
                }
                if (!string.IsNullOrWhiteSpace(txt_defeitoRelatado.Text))
                {
                    ordemServico.defeitoRelatado = txt_defeitoRelatado.Text;
                }
                if (!string.IsNullOrWhiteSpace(txt_servicosRealizados.Text))
                {
                    ordemServico.servicosRealizados = txt_servicosRealizados.Text;
                }
                if (!string.IsNullOrWhiteSpace(txt_observacoes.Text))
                {
                    ordemServico.observacoes = txt_observacoes.Text;
                }
                foreach(global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
                {
                    var p = produto.produto;

                    p.estoque.Last().ativo = false;
                    p.estoque.Last().dataFim = DateTime.Now;
                    ProdutoEstoque estoque = new ProdutoEstoque();
                    estoque.ativo = true;
                    estoque.atual = p.estoque.Last().atual - produto.quantidade;
                    estoque.dataInicio = DateTime.Now;
                 
                    p.estoque.Add(estoque);
                    new ProdutoImplementation().Atualizar(p);

                    new ProdutoImplementation().Atualizar(produto.produto);
                }
                ordemServico.funcionario = FuncionarioLogado.funcionarioLogado;

                ordemServicoImplementation.Inserir(ordemServico);
            }
            else

            {
                MessageBox.Show(this, "Informe um cliente valido.", "Cliente Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            /*
             * Em Aberto
               Finalizado
               Cancelado
               Aguardando Pagamento
             * */
            salvarOs();


            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(ordemServico.situacao==0)
            {

                if (MessageBox.Show(this, "A situação da venda sera alterada para aguardando Pagamento. \n Deseja Continuar?", "Erro ao Iniciar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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

        private void NovaOrdemServiço_Load(object sender, EventArgs e)
        {
            txt_situacao.Text = "Em Aberto";
            txt_funcionario.Text = FuncionarioLogado.funcionarioLogado.nome;
            txt_numeroOS.Text = ordemServicoImplementation.getLastId().ToString();
            ordemServico.id = Int32.Parse(txt_numeroOS.Text);
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
                var produto = ordemServico.produtos.Where(rs => rs.id == selecionarProduto.produto.id).FirstOrDefault();

                if(produto == null)
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
            if(dgv_Produtos.Rows.Count>0 && dgv_Produtos.SelectedRows[0]!=null)
            {
                int index = Int16.Parse(dgv_Produtos.Rows[dgv_Produtos.SelectedRows[0].Index].Cells[0].Value.ToString());
                ordemServico.produtos.RemoveAt(index);
                Carregar();
            }
            
        }

        private void tp_OS_Click(object sender, EventArgs e)
        {

        }

        private void chb_defeitoReladado_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(chb_defeitoConstatado.Checked)
            {
                ordemServico.defeitoConstatado = txt_defeitoConstatado.Text;
            }

            if(chb_defeitoReladado.Checked)
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

        private void btn_AlterarProduto_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Produtos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void gpbx_totais_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
          
             x = 1;
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
            lbl_OrdemServicoSubtotal.Text = Funcoes.formatarParaMoeda((TotalServico+ TotalProduto).ToString());
            lbl_OrdemServicosImpostos.Text = Funcoes.formatarParaMoeda((TotalImpostosProdutos+TotalImpostosServicos).ToString());
            lbl_OrdemServicoDescontos.Text = Funcoes.formatarParaMoeda((TotalDescontoProduto+TotalDescontoServico).ToString());
            lbl_OrdemServicoTotal.Text = Funcoes.formatarParaMoeda(((TotalProduto - TotalDescontoProduto) + (TotalServico - TotalDescontoServico)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

    
    }


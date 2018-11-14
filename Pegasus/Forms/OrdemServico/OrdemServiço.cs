using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pegasus.Controllers.Cliente;
using Pegasus.Controllers.Produtos;
using Pegasus.Business.Implementation;

namespace Pegasus.Controllers.OrdemServico
{
    public partial class OrdemServiço : UserControl
    {

        private global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        private Decimal total = 0;
        public OrdemServiço()
        {
            InitializeComponent();
            ordemServico = new Factory.Entities.OrdemServico();
            txt_defeitoRelatado.Enabled = false;
            txt_defeitoConstatado.Enabled = false;
        }

        private void OrdemServiço_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Day < 10 && DateTime.Now.Month < 10)
            {
                mtb_dataEntrada.Text = "0" + DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                mtb_previsaoEntrega.Text = "0" + DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }

            else if (DateTime.Now.Day < 10)
            {
                mtb_dataEntrada.Text = "0" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                mtb_previsaoEntrega.Text = "0" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            else if (DateTime.Now.Month < 10)
            {
                mtb_dataEntrada.Text = DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                mtb_previsaoEntrega.Text = DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }
            else
            {
                mtb_dataEntrada.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                mtb_previsaoEntrega.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            }

            cmb_situacao.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalizarOs finalizarOs = new FinalizarOs();
            finalizarOs.ShowIcon = false;
            finalizarOs.ShowInTaskbar = false;
            finalizarOs.ShowDialog();
        }

        private void carregarDataGridView()
        {
            dgv_Produtos.Rows.Clear();
            total = 0;
            foreach (global::Pegasus.Factory.Entities.ProdutoVenda produto in ordemServico.produtos)
            {
                dgv_Produtos.Rows.Add(produto.id, dgv_Produtos.Rows.Count + 1, produto.produto.descricao, produto.quantidade, produto.produto.precoVendaVista);
                total += (produto.produto.precoVendaVista * produto.quantidade);
            }


        }

        private void Estado()
        {
            ordemServico.aguardandoPagamento = false;
            ordemServico.cancelado = false;
            ordemServico.emAberto = false;
            ordemServico.finalizado = false;
            if (cmb_situacao.SelectedIndex == 0)
            {
                ordemServico.emAberto = true;
            }
            else if (cmb_situacao.SelectedIndex == 1)
            {
                ordemServico.finalizado = true;
            }
            else if (cmb_situacao.SelectedIndex == 2)
            {
                ordemServico.cancelado = true;
            }
            else if (cmb_situacao.SelectedIndex == 3)
            {
                ordemServico.aguardandoPagamento = true;
            }
        }

        private void btn_ExcluirProduto_Click(object sender, EventArgs e)
        {

            int index = Int16.Parse(dgv_Produtos.Rows[dgv_Produtos.SelectedRows[0].Index].Cells[0].Value.ToString());
            ordemServico.produtos.RemoveAt(index);
            carregarDataGridView();
        }

        private void btn_novoProduto_Click(object sender, EventArgs e)
        {

            SelecionarProduto selecionarProduto = new SelecionarProduto();
            selecionarProduto.ShowIcon = false;
            selecionarProduto.ShowInTaskbar = false;
            selecionarProduto.ShowDialog(this);

            if (selecionarProduto.DialogResult.Equals(DialogResult.OK))
            {
                ordemServico.produtos.Add(selecionarProduto.produto);
                carregarDataGridView();
            }
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            Selecionar_Cliente selecionarCliente = new Selecionar_Cliente();
            selecionarCliente.ShowIcon = false;
            selecionarCliente.ShowInTaskbar = false;
            DialogResult dr = selecionarCliente.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                ordemServico.cliente = selecionarCliente.cliente;
                ordemServico.veiculo = selecionarCliente.cliente.veiculos[0];



                txt_cliente.Text = ordemServico.cliente.nome;
                txt_km.Text = ordemServico.cliente.veiculos[0].quilometragem;
                txt_marca.Text = ordemServico.cliente.veiculos[0].marca;
                txt_modelo.Text = ordemServico.cliente.veiculos[0].modelo;
                mtb_anoFab.Text = ordemServico.cliente.veiculos[0].anoFabricacao;
                mtb_placa.Text = ordemServico.cliente.veiculos[0].placa;
                txt_cor.Text = ordemServico.cliente.veiculos[0].cor;
                txt_combustivel.Text = ordemServico.cliente.veiculos[0].combustivel;

            }
        }

        private void OrdemServiço_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
                Estado();
                ordemServicoImplementation.Inserir(ordemServico);

            }
            else if (e.KeyCode == Keys.F3)
            {
                FinalizarOs finalizaros = new FinalizarOs();
                finalizaros.ShowIcon = false;
                finalizaros.ShowInTaskbar = false;
                finalizaros.desconto = 0.00m;
                finalizaros.total = total;
                finalizaros.ShowDialog(this);

                if (finalizaros.imprimir == true)
                {
                    OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
                    Estado();
                    ordemServicoImplementation.Inserir(ordemServico);
                    global::Pegasus.Business.PrintClass printClass = new Business.PrintClass(ordemServico);
                }
                else if (finalizaros.salvar == true)
                {
                    OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
                    Estado();
                    ordemServicoImplementation.Inserir(ordemServico);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinalizarOs finalizaros = new FinalizarOs();
            finalizaros.ShowIcon = false;
            finalizaros.ShowInTaskbar = false;
            finalizaros.desconto = 0.00m;
            finalizaros.total = total;
            finalizaros.ShowDialog(this);

            if (finalizaros.imprimir == true)
            {
                OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
                Estado();
                ordemServicoImplementation.Inserir(ordemServico);
                global::Pegasus.Business.PrintClass printClass = new Business.PrintClass(ordemServico);
            }
            else if (finalizaros.salvar == true)
            {
                OrdemServicoImplementation ordemServicoImplementation = new OrdemServicoImplementation();
                Estado();
                ordemServicoImplementation.Inserir(ordemServico);
            }
        }
    }
}

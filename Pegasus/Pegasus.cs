
using Pegasus.Controllers;
using Pegasus.Controllers.Cheques;
using Pegasus.Controllers.Cliente;

using Pegasus.Controllers.Funcionario;
using Pegasus.Controllers.Graficos.Vendas;
using Pegasus.Controllers.Login;

using Pegasus.Controllers.OrdemServico;
using Pegasus.Controllers.Produtos;
using Pegasus.Controllers.Relatorio.Estoque;

using System;
using System.Windows.Forms;

namespace Pegasus
{
    public partial class Pegasus : Form
    {
        public Pegasus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
           
            

           Login l = new Login();

            DialogResult dr = l.ShowDialog() ;

            if(dr == DialogResult.OK)
            {
                this.Visible = true;
                this.Text = "Pegasus :: "+FuncionarioLogado.funcionarioLogado.nome;
                menuClientes.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.visualizarCliente;
                menuFornecedores.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.visualizarFornecedor;
                menuProdutos.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.visualizarProduto;
                menuCheques.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.visualizarCheque;
                menuFuncionarios.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.visualizarFuncionario;
                menuRelatorioClientes.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.gerarRelatorioClientes;
                menuRelatorioEstoque.Enabled = FuncionarioLogado.funcionarioLogado.permissoes.gerarRelatorioEstoque;
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {

            Clientes clientes = new Clientes();
            clientes.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(clientes);


        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Controllers.Produtos.Produtos produtos = new Controllers.Produtos.Produtos();
            produtos.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(produtos);

        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mainPanel.Controls.Clear();
            NovaOrdemServiço novaOrdemServiço = new NovaOrdemServiço();
            novaOrdemServiço.ShowIcon = false;
            novaOrdemServiço.ShowInTaskbar = false;
            novaOrdemServiço.ShowDialog();
            
            
        }

      

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.Fornecedor.Fornecedores fornecedores = new Controllers.Fornecedor.Fornecedores();
            fornecedores.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(fornecedores);
        }

        

        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.FluxodeCaixa.FluxoCaixa fluxoCaixa = new Controllers.FluxodeCaixa.FluxoCaixa();
            fluxoCaixa.ShowDialog(this);
        }

        private void chequesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cheques cheques = new Cheques();
            cheques.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(cheques);
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowIcon = false;
            estoque.ShowInTaskbar = false;
            estoque.ShowDialog(this);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios  = new Funcionarios();
            funcionarios.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(funcionarios);
        }

        private void Pegasus_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void historicoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdensServiço ordemServico = new OrdensServiço();
            ordemServico.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ordemServico);

        }

      

        private void novaVendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NovaVenda novaVenda = new NovaVenda();

            novaVenda.ShowIcon = false;
            novaVenda.ShowInTaskbar = false;

            novaVenda.ShowDialog(this);
        }

        

        private void nCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void emitirNFeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historicoVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoVendas historico = new HistoricoVendas();
            historico.ShowDialog();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

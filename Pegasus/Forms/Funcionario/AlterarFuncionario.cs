using Pegasus.Business.Implementation;
using Pegasus.Controllers.Telefone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Funcionario
{
    public partial class AlterarFuncionario : Form
    {
        global::Pegasus.Factory.Entities.Funcionario funcionario { get; set; }
        public IList<global::Pegasus.Factory.Entities.Cidade> cidades { get; set; }
        public IList<global::Pegasus.Factory.Entities.Estado> estados { get; set; }
        public AlterarFuncionario(global::Pegasus.Factory.Entities.Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;

            cidades = new CidadeImplemtation().Buscar();
            estados = new EstadoImplementation().Buscar();
            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                cmb_UF.Items.Add(estado.nome);
            }
            cmb_UF.SelectedItem = funcionario.estado.nome;
            cmb_cidade.SelectedItem = funcionario.cidade.nome;
            
        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            txt_Nome.Text = funcionario.nome;
            mtb_cpfcnpj.Text = funcionario.cpf;
            mtb_rgie.Text = funcionario.rg;
           chx_Ativo.Checked = funcionario.ativo;
            txt_Bairro.Text = funcionario.bairro ;
            mtb_Cep.Text=funcionario.cep;
            txt_Email.Text= funcionario.email;
            txt_Endereco.Text= funcionario.endereco;
            txt_Numero.Text= funcionario.numero.ToString();
            dtp_nascimento.Value = funcionario.nascimento;
            dtp_admissao.Value = funcionario.admissao;

            cbx_cadastrarCheque.Checked= funcionario.permissoes.cadastrarCheque;
            cbx_cadastrarCliente.Checked= funcionario.permissoes.cadastrarCliente;
            cbx_cadastrarFornecedor.Checked= funcionario.permissoes.cadastrarFornecedor;
            cbx_cadastrarFuncionario.Checked= funcionario.permissoes.cadastrarFuncionario;
            cbx_cadastrarOS.Checked = funcionario.permissoes.cadastrarOs;
            cbx_cadastrarProduto.Checked = funcionario.permissoes.cadastrarProduto;

            cbx_editarCheque.Checked= funcionario.permissoes.editarCheque;
            cbx_editarCliente.Checked= funcionario.permissoes.editarCliente;
            cbx_editarFornecedor.Checked= funcionario.permissoes.editarFornecedor;
            cbx_editarFuncionario.Checked= funcionario.permissoes.editarFuncionario;
            cbx_editarOS.Checked= funcionario.permissoes.editarOs;
            cbx_editarProduto.Checked= funcionario.permissoes.editarProduto;

            cbx_excluirCheque.Checked = funcionario.permissoes.excluirCheque;
            cbx_excluirCliente.Checked= funcionario.permissoes.excluirCliente;
            cbx_excluirFornecedor.Checked= funcionario.permissoes.excluirFornecedor;
            cbx_excluirFuncionario.Checked= funcionario.permissoes.excluirFuncionario;
            cbx_excluirOS.Checked = funcionario.permissoes.excluirOs;
            cbx_excluirProduto.Checked = funcionario.permissoes.excluirProduto;

            cbx_visualizarCheque.Checked = funcionario.permissoes.visualizarCheque;
            cbx_visualizarCliente.Checked = funcionario.permissoes.visualizarCliente;
            cbx_visualizarFornecedor.Checked = funcionario.permissoes.visualizarFornecedor;
            cbx_visualizarFuncionario.Checked = funcionario.permissoes.visualizarFuncionario;
            cbx_visualizarOS.Checked = funcionario.permissoes.visualizarOs;
            cbx_visualizarProduto.Checked = funcionario.permissoes.visualizarProduto;

            cbx_gerarRelatorioClientes.Checked = funcionario.permissoes.gerarRelatorioClientes;
            cbx_gerarRelatorioEstoque.Checked = funcionario.permissoes.gerarRelatorioEstoque;
            cbx_gerarRelatorioFluxoCaixa.Checked = funcionario.permissoes.gerarRelatorioFluxoCaixa;
            cbx_gerarRelatorioOS.Checked = funcionario.permissoes.gerarRelatorioOs;
            dgv_telefone.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Telefone t in funcionario.telefone)
            {
                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                if (mtb_cpfcnpj.MaskCompleted)
                {
                    if (mtb_rgie.MaskCompleted)
                    {
                       
                            if (funcionario.telefone.Count != 0)
                            {
                                if (cbx_visualizarCheque.Checked || cbx_visualizarCliente.Checked || cbx_visualizarFornecedor.Checked
                                   || cbx_visualizarFuncionario.Checked || cbx_visualizarOS.Checked || cbx_visualizarProduto.Checked ||
                                   cbx_gerarRelatorioClientes.Checked || cbx_gerarRelatorioEstoque.Checked || cbx_gerarRelatorioFluxoCaixa.Checked ||
                                   cbx_gerarRelatorioOS.Checked)
                                {
                                    funcionario.nome = txt_Nome.Text;
                                    funcionario.cpf = mtb_cpfcnpj.Text;
                                    funcionario.rg = mtb_rgie.Text;
                                    funcionario.ativo = chx_Ativo.Checked;
                                    funcionario.bairro = txt_Bairro.Text;
                                    funcionario.cep = mtb_Cep.Text;
                                    funcionario.email = txt_Email.Text;
                                    funcionario.endereco = txt_Endereco.Text;
                                   // funcionario.cidade = txt_Cidade.Text;
                                    funcionario.numero = Int16.Parse(txt_Numero.Text);
                                    foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
                                    {
                                      if (cmb_UF.Text == estado.nome)
                                        {
                                            funcionario.estado = estado;
                                            break;
                                        }
                                    }
                                foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
                                {
                                    if ( c.nome == cmb_cidade.Text)
                                    {

                                        funcionario.cidade = c;
                                        break;
                                    }
                                }
                                funcionario.admissao = dtp_admissao.Value;
                                funcionario.nascimento = dtp_nascimento.Value;
                                    funcionario.permissoes.cadastrarCheque = cbx_cadastrarCheque.Checked;
                                    funcionario.permissoes.cadastrarCliente = cbx_cadastrarCliente.Checked;
                                    funcionario.permissoes.cadastrarFornecedor = cbx_cadastrarFornecedor.Checked;
                                    funcionario.permissoes.cadastrarFuncionario = cbx_cadastrarFuncionario.Checked;
                                    funcionario.permissoes.cadastrarOs = cbx_cadastrarOS.Checked;
                                    funcionario.permissoes.cadastrarProduto = cbx_cadastrarProduto.Checked;

                                    funcionario.permissoes.editarCheque = cbx_editarCheque.Checked;
                                    funcionario.permissoes.editarCliente = cbx_editarCliente.Checked;
                                    funcionario.permissoes.editarFornecedor = cbx_editarFornecedor.Checked;
                                    funcionario.permissoes.editarFuncionario = cbx_editarFuncionario.Checked;
                                    funcionario.permissoes.editarOs = cbx_editarOS.Checked;
                                    funcionario.permissoes.editarProduto = cbx_editarProduto.Checked;

                                    funcionario.permissoes.excluirCheque = cbx_excluirCheque.Checked;
                                    funcionario.permissoes.excluirCliente = cbx_excluirCliente.Checked;
                                    funcionario.permissoes.excluirFornecedor = cbx_excluirFornecedor.Checked;
                                    funcionario.permissoes.excluirFuncionario = cbx_excluirFuncionario.Checked;
                                    funcionario.permissoes.excluirOs = cbx_excluirOS.Checked;
                                    funcionario.permissoes.excluirProduto = cbx_excluirProduto.Checked;

                                    funcionario.permissoes.visualizarCheque = cbx_visualizarCheque.Checked;
                                    funcionario.permissoes.visualizarCliente = cbx_visualizarCliente.Checked;
                                    funcionario.permissoes.visualizarFornecedor = cbx_visualizarFornecedor.Checked;
                                    funcionario.permissoes.visualizarFuncionario = cbx_visualizarFuncionario.Checked;
                                    funcionario.permissoes.visualizarOs = cbx_visualizarOS.Checked;
                                    funcionario.permissoes.visualizarProduto = cbx_visualizarProduto.Checked;
                                    funcionario.permissoes.visualizarTodasOs = cbx_visualizarTodasOS.Checked;

                                    funcionario.permissoes.gerarRelatorioClientes = cbx_gerarRelatorioClientes.Checked;
                                    funcionario.permissoes.gerarRelatorioEstoque = cbx_gerarRelatorioEstoque.Checked;
                                    funcionario.permissoes.gerarRelatorioFluxoCaixa = cbx_gerarRelatorioFluxoCaixa.Checked;
                                    funcionario.permissoes.gerarRelatorioOs = cbx_gerarRelatorioOS.Checked;
                                    FuncionarioImplementation funcionarioImplementation = new FuncionarioImplementation();
                                    funcionarioImplementation.Atualizar(funcionario);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();


                                }
                                else
                                {
                                    MessageBox.Show(this, "Permissoes inconsistentes.", "Erro ao cadastrar:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "Informe ao menos um telefone", "Erro ao cadastrar:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        

                    }
                    else
                    {
                        MessageBox.Show(this, "Informe um Rg valido.", "Erro ao cadastrar:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Informe um CPF valido.", "Erro ao cadastrar:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            else
            {
                MessageBox.Show(this, "Informe um nome valido.", "Erro ao cadastrar:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #region Permissoes
        private void cbx_visualizarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarCliente.Checked = false;
                cbx_editarCliente.Checked = false;
                cbx_excluirCliente.Checked = false;
            }
        }

        private void cbx_cadastrarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void cbx_editarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void cbx_excluirCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void cbx_cadastrarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void cbx_editarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void cbx_excluirProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void cbx_visualizarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarProduto.Checked = false;
                cbx_editarProduto.Checked = false;
                cbx_excluirProduto.Checked = false;
            }
        }

        private void cbx_cadastrarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void cbx_editarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void cbx_excluirFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void cbx_visualizarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFornecedor.Checked = false;
                cbx_editarFornecedor.Checked = false;
                cbx_excluirFornecedor.Checked = false;
            }
        }

        private void cbx_visualizarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
            }
        }

        private void cbx_excluirFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void cbx_editarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void cbx_cadastrarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void cbx_visualizarTodasOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
                cbx_visualizarOS.Checked = true;
            }
        }

        private void cbx_visualizarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;
            if (!cmb.Checked)
            {
                cbx_cadastrarOS.Checked = false;
                cbx_excluirOS.Checked = false;
                cbx_editarOS.Checked = false;
                cbx_visualizarTodasOS.Checked = false;
            }
        }

        private void cbx_excluirOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void cbx_editarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void cbx_cadastrarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void cbx_cadastrarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void cbx_editarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void cbx_excluirCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void cbx_visualizarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
            }
        }

        

        private void cbx_gerarTodosRelatorios_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_gerarRelatorioClientes.Checked = true;
                cbx_gerarRelatorioEstoque.Checked = true;
                cbx_gerarRelatorioFluxoCaixa.Checked = true;
                cbx_gerarRelatorioOS.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NovoTelefone novoTelefone = new NovoTelefone();

            novoTelefone.ShowInTaskbar = false;
            novoTelefone.ShowIcon = false;

            DialogResult result = novoTelefone.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                funcionario.telefone.Add(novoTelefone.telefone);
                dgv_telefone.Rows.Clear();
                foreach (global::Pegasus.Factory.Entities.Telefone t in funcionario.telefone)
                {

                    dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
                }


            }
        }

        private void chbx_visualizarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarCliente.Checked = false;
                cbx_editarCliente.Checked = false;
                cbx_excluirCliente.Checked = false;
            }
        }

        private void chbx_cadastrarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void chbx_editarCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void chbx_excluirCliente_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCliente.Checked = true;
            }
        }

        private void chbx_cadastrarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void chbx_editarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void chbx_excluirProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarProduto.Checked = true;
            }
        }

        private void chbx_visualizarProduto_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarProduto.Checked = false;
                cbx_editarProduto.Checked = false;
                cbx_excluirProduto.Checked = false;
            }
        }

        private void chbx_cadastrarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void chbx_editarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void chbx_excluirFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFornecedor.Checked = true;
            }
        }

        private void chbx_visualizarFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFornecedor.Checked = false;
                cbx_editarFornecedor.Checked = false;
                cbx_excluirFornecedor.Checked = false;
            }
        }

        private void chbx_visualizarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
            }
        }

        private void chbx_excluirFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void chbx_editarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void chbx_cadastrarFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarFuncionario.Checked = true;
            }
        }

        private void chbx_visualizarTodasOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
                cbx_visualizarOS.Checked = true;
            }
        }

        private void chbx_visualizarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;
            if (!cmb.Checked)
            {
                cbx_cadastrarOS.Checked = false;
                cbx_excluirOS.Checked = false;
                cbx_editarOS.Checked = false;
                cbx_visualizarTodasOS.Checked = false;
            }
        }

        private void chbx_excluirOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void chbx_editarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void chbx_cadastrarOS_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarOS.Checked = true;
            }
        }

        private void chbx_cadastrarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void chbx_editarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void chbx_excluirCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_visualizarCheque.Checked = true;
            }
        }

        private void chbx_visualizarCheque_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (!cmb.Checked)
            {
                cbx_cadastrarFuncionario.Checked = false;
                cbx_editarFuncionario.Checked = false;
                cbx_excluirFuncionario.Checked = false;
            }
        }

        private void chbx_gerarTodosRelatorios_CheckedChanged(object sender, EventArgs e)
        {
            var cmb = sender as CheckBox;

            if (cmb.Checked)
            {
                cbx_gerarRelatorioClientes.Checked = true;
                cbx_gerarRelatorioEstoque.Checked = true;
                cbx_gerarRelatorioFluxoCaixa.Checked = true;
                cbx_gerarRelatorioOS.Checked = true;
            }
        }

        private void cbx_gerarRelatorioEstoque_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void cmb_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_cidade.Items.Clear();
            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                if (estado.nome == cmb_UF.Text)
                {
                    foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
                    {
                        if (c.uf == estado.Id)
                        {
                            cmb_cidade.Items.Add(c.nome);
                        }
                    }
                }
            }
            cmb_cidade.SelectedIndex = 0;
        }
        #region Telefone
        private void btn_novoTelefone_Click(object sender, EventArgs e)
        {
            NovoTelefone novoTelefone = new NovoTelefone();

            novoTelefone.ShowInTaskbar = false;
            novoTelefone.ShowIcon = false;

            DialogResult result = novoTelefone.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                funcionario.telefone.Add(novoTelefone.telefone);
                carregarTelefone();
            }
        }
        private void carregarTelefone()
        {
            dgv_telefone.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Telefone t in funcionario.telefone)
            {
                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
        }
        private void btn_alterarTelefone_Click(object sender, EventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(funcionario.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }

        private void btn_exluirTelefone_Click(object sender, EventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                if (MessageBox.Show("Deseja excluir o telefone selecionado", "Confirmar Exclusão:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    funcionario.telefone.RemoveAt(dgv_telefone.SelectedRows[0].Index);
                    carregarTelefone();
                }
            }
        }

        private void dgv_telefone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(funcionario.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }
        #endregion

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

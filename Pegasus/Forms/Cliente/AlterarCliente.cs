using Pegasus.Business.Implementation;
using Pegasus.Controllers.Telefone;

using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Cliente
{
    public partial class AlterarCliente : Form
    {
        public global::Pegasus.Factory.Entities.Cliente cliente { get; set; }
        public IList<global::Pegasus.Factory.Entities.Cidade> cidades { get; set; }
        public IList<global::Pegasus.Factory.Entities.Estado> estados { get; set; }
        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            
            txt_Nome.Text = cliente.nome;
            txt_Bairro.Text = cliente.bairro;
            
            txt_Email.Text = cliente.email;
            txt_Endereco.Text = cliente.endereco;
            txt_Numero.Text = cliente.numero.ToString();
            mtb_Cep.Text = cliente.cep;
            cbx_Ativo.Checked = cliente.ativo;
            foreach(global::Pegasus.Factory.Entities.Telefone t in cliente.telefone)
            {
                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
           
            if (cliente.pessoaJuridica)
            {
                mtb_cpfcnpj.Mask = "99,999,999/9999-99";
                mtb_rgie.Mask = "999,999,999,999";
                lbl_cpfcnpj.Text = "CNPJ:";
                lbl_rgie.Text = "IE:";
                mtb_cpfcnpj.Text = cliente.cpfCnpj;
                mtb_rgie.Text = cliente.rgIe;
                lbl_tipo.Text = "Pessoa Juridica";
                txt_razao.Visible = true;
                lbl_razaoSocial.Visible = true;
                mtb_Nascimento.Visible = false;
                lbl_Nascimento.Visible = false;
                txt_razao.Text = cliente.razaoSocial;
            }
            else
            {
                mtb_cpfcnpj.Mask = "999,999,999-99";
                mtb_rgie.Mask = "99,999,999-9";
                lbl_cpfcnpj.Text = "CPF:";
                lbl_rgie.Text = "RG:";
                mtb_cpfcnpj.Text = cliente.cpfCnpj;
                mtb_rgie.Text = cliente.rgIe;
                mtb_Nascimento.Text = cliente.nascimento.Date.ToShortDateString();
                lbl_tipo.Text = "Pessoa Fisica";
                txt_razao.Visible =  false;
                lbl_razaoSocial.Visible = false;
            }

            cidades = new CidadeImplemtation().Buscar();
            estados = new EstadoImplementation().Buscar();

            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                cmb_UF.Items.Add(estado.nome);
            }
            cmb_UF.SelectedItem = cliente.estado.nome;

            foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
            {
                if (c.uf == cliente.estado.Id && c.nome == cmb_cidade.Text)
                {

                    cliente.cidade = c;
                    break;
                }
            }

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
            cmb_cidade.SelectedItem = cliente.cidade.nome;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                if (mtb_cpfcnpj.MaskCompleted)
                {
                    if (cliente.telefone.Count > 0)
                    {
                        if(cliente.pessoaJuridica)
                        {
                            cliente.razaoSocial = txt_razao.Text;
                        }
                        else
                        {
                            cliente.nascimento = DateTime.Parse(mtb_Nascimento.Text);
                        }
                        cliente.ativo = cbx_Ativo.Checked;
                        cliente.bairro = txt_Bairro.Text;
                        cliente.cep = mtb_Cep.Text;
                        cliente.nome = txt_Nome.Text;
                        cliente.numero = Int16.Parse(txt_Numero.Text);
                        cliente.rgIe = mtb_rgie.Text;
                        cliente.cpfCnpj = mtb_cpfcnpj.Text;
                        cliente.email = txt_Email.Text;
                        cliente.endereco = txt_Endereco.Text;
                        foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
                        {
                            if (cmb_UF.Text == estado.nome)
                            {
                                cliente.estado = estado;
                                break;
                            }
                        }

                        foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
                        {
                            if (c.uf == cliente.estado.Id && c.nome == cmb_cidade.Text)
                            {

                                cliente.cidade = c;
                                break;
                            }
                        }


                        ClienteImplementation clienteImplementation = new ClienteImplementation();
                        clienteImplementation.Atualizar(cliente);

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Informe ao menos um telefone.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe um cnpj valido.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe o nome do cliente.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                cliente.telefone.Add(novoTelefone.telefone);
                carregarTelefone();
            }
        }
        private void carregarTelefone()
        {
            dgv_telefone.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Telefone t in cliente.telefone)
            {
                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
        }
        private void btn_alterarTelefone_Click(object sender, EventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(cliente.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }

        private void btn_excluirTelefone_Click(object sender, EventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(cliente.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }

        private void dgv_telefone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(cliente.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }
        #endregion

        
    }
}

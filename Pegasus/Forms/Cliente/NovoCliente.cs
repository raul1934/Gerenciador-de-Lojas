using Pegasus.Business.Implementation;
using Pegasus.Controllers.Telefone;

using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pegasus.Controllers.Cliente
{
    public partial class NovoCliente : Form
    {
        public global::Pegasus.Factory.Entities.Cliente cliente { get; set; }
        public IList<global::Pegasus.Factory.Entities.Cidade> cidades { get; set; }
        public IList<global::Pegasus.Factory.Entities.Estado> estados { get; set; }
        public IList<global::Pegasus.Factory.Entities.Pais> paises { get; set; }

        public NovoCliente()
        {
            InitializeComponent();
            cliente = new Factory.Entities.Cliente();
            
            cidades = new CidadeImplemtation().Buscar();
            estados = new EstadoImplementation().Buscar();
            paises = new PaisImplementation().Buscar();
            foreach (global::Pegasus.Factory.Entities.Estado e in estados)
            {
                cmb_UF.Items.Add(e.nome);
            }
        }
        #region SalvarCliente
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                if (mtb_cpfcnpj.MaskCompleted)
                {
                    if (cliente.telefone.Count > 0)
                    {
                        
                        cliente.ativo = chx_Ativo.Checked;
                        cliente.bairro = txt_Bairro.Text;
                        cliente.cep = mtb_Cep.Text;
                        cliente.nome = txt_Nome.Text;
                        cliente.numero = Int16.Parse(txt_Numero.Text);
                        foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
                        { 
                            if(cmb_UF.Text == estado.nome)
                            {
                                cliente.estado = estado;
                                break;
                            }
                        }

                        foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
                        {
                            if (c.uf == cliente.estado.Id && c.nome == cmb_cidade.Text )
                            {
                                
                                cliente.cidade = c;
                                break;
                            }
                        }
                        cliente.pais = paises[0];
                        cliente.rgIe = mtb_rgie.Text;
                        cliente.cpfCnpj = mtb_cpfcnpj.Text;
                        cliente.email = txt_Email.Text;
                        cliente.endereco = txt_Endereco.Text;
                        cliente.razaoSocial = txt_razao.Text;
                        cliente.dataCadastro = DateTime.Now;
                        if (cbx_tipo.SelectedIndex == 1)
                        {
                            cliente.pessoaJuridica = false;
                            cliente.nascimento = DateTime.Parse(mtb_Nascimento.Text);
                        }
                        else if (cbx_tipo.SelectedIndex == 0)
                        {
                            cliente.pessoaJuridica = true;
                        }

                        ClienteImplementation clienteImplementation = new ClienteImplementation();
                        clienteImplementation.Inserir(cliente);

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
        #endregion

        #region novoClienteLoad
        private void NovoCliente_Load(object sender, EventArgs e)
        {
            cbx_tipo.SelectedIndex = 0;
            dgv_telefone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_telefone.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cmb_UF.SelectedIndex = 0;
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.cbx_tipo, "My button1");
            
        }
        #endregion

        #region novoTelefone
        private void button6_Click(object sender, EventArgs e)
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
        #endregion

        #region novoVeiculo
        #endregion

        #region close
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TpoSelectedIndexChanged
        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_tipo.SelectedIndex == 0)
            {
                mtb_Nascimento.Visible = false;
                lbl_Nascimento.Visible = false;
                lbl_cpfcnpj.Text = "CNPJ:";
                lbl_rgie.Text = "IE:";
                mtb_cpfcnpj.Mask = "99,999,999/9999-99";
                mtb_rgie.Mask = "999,999,999,999";
                lbl_razaoSocial.Visible = true;
                txt_razao.Visible = true;
                lbl_nomeFantasia.Text = "Nome Fantasia:";
            }
            else if (cbx_tipo.SelectedIndex == 1)
            {
                mtb_Nascimento.Visible = true;
                lbl_Nascimento.Visible = true;
                lbl_cpfcnpj.Text = "CPF:";
                lbl_rgie.Text = "RG:";
                mtb_cpfcnpj.Mask = "999,999,999-99";
                mtb_rgie.Mask = "99,999,999-9";
                lbl_nomeFantasia.Text = "Nome:";
                lbl_razaoSocial.Visible = false;
                txt_razao.Visible = false;
            }
        }
        #endregion

        #region UFSelectedIndexChanged
        private void cmb_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_cidade.Items.Clear();
            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                if(estado.nome == cmb_UF.Text)
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

        #endregion

        #region Telefone
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

        

        private void dgv_telefone_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                if (MessageBox.Show("Deseja excluir o telefone selecionado", "Confirmar Exclusão:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    cliente.telefone.RemoveAt(dgv_telefone.SelectedRows[0].Index);
                    carregarTelefone();
                }
            }
        }
        #endregion

     
    }
}

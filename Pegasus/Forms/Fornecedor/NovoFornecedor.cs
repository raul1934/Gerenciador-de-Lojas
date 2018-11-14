using Pegasus.Business.Implementation;
using Pegasus.Controllers.Telefone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pegasus.Controllers.Fornecedor
{
    public partial class NovoFornecedor : Form
    {
        global::Pegasus.Factory.Entities.Fornecedor fornecedor { get; set; }
        public IList<global::Pegasus.Factory.Entities.Cidade> cidades { get; set; }
        public IList<global::Pegasus.Factory.Entities.Estado> estados { get; set; }
        public IList<global::Pegasus.Factory.Entities.Pais> paises { get; set; }

        public NovoFornecedor()
        {
            InitializeComponent();
            fornecedor = new global::Pegasus.Factory.Entities.Fornecedor();
            cidades = new CidadeImplemtation().Buscar();
            estados = new EstadoImplementation().Buscar();
            paises = new PaisImplementation().Buscar();
            foreach (global::Pegasus.Factory.Entities.Estado e in estados)
            {
                cmb_UF.Items.Add(e.nome);
            }
            cmb_UF.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_razao.Text))
            {
                if (!string.IsNullOrWhiteSpace(txt_Nome.Text))
                {
                    if (mtb_cpfcnpj.MaskCompleted == true)
                    {
                        if (!(fornecedor.telefone.Count == 0))
                        {
                            fornecedor.nomeFantasia = txt_Nome.Text;
                            fornecedor.razaoSocial = txt_razao.Text;
                            fornecedor.numero = Int16.Parse(txt_Numero.Text);
                            fornecedor.endereco = txt_Endereco.Text;
                            fornecedor.Cnpj = mtb_cpfcnpj.Text;
                            fornecedor.Ie = mtb_rgie.Text;
                            fornecedor.bairro = txt_Bairro.Text;
                            fornecedor.ativo = chx_Ativo.Checked;
                            fornecedor.email = txt_Email.Text;
                            fornecedor.cep = mtb_Cep.Text;
                            fornecedor.pais = paises[0];
                            fornecedor.dataCadastro = DateTime.Now;
                            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
                            {
                                if (cmb_UF.Text == estado.nome)
                                {
                                    fornecedor.estado = estado;
                                    break;
                                }
                            }

                            foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
                            {
                                if (c.uf == fornecedor.estado.Id && c.nome == cmb_cidade.Text)
                                {

                                    fornecedor.cidade = c;
                                    break;
                                }
                            }


                            FornecedorImplementation fornecedorImplementation = new FornecedorImplementation();
                            fornecedorImplementation.Inserir(fornecedor);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Informe ao menos um Telefone do fornecedor.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe o CNPJ do fornecedor.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Nome Fantasia do fornecedor.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Informe a Razão Social do fornecedor.", "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_novoTelefone_Enter(object sender, EventArgs e)
        {
            NovoTelefone novoTelefone = new NovoTelefone();

            novoTelefone.ShowInTaskbar = false;
            novoTelefone.ShowIcon = false;

            

            if (novoTelefone.ShowDialog(this) == DialogResult.OK)
            {
                fornecedor.telefone.Add(novoTelefone.telefone);
                carregarTelefone();


            }
        }

        private void carregarTelefone()
        {
            dgv_telefone.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Telefone t in fornecedor.telefone)
            {

                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
        }

        private void btn_alterarTelefone_Click(object sender, EventArgs e)
        {
            if(dgv_telefone.Rows.Count>0 && dgv_telefone.SelectedRows[0]!=null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(fornecedor.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if(alterarTelefone.ShowDialog(this) == DialogResult.OK)
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
                    fornecedor.telefone.RemoveAt(dgv_telefone.SelectedRows[0].Index);
                    carregarTelefone();
                }
            }
        }

        private void dgv_telefone_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_telefone.Rows.Count > 0 && dgv_telefone.SelectedRows[0] != null)
            {
                AlterarTelefone alterarTelefone = new AlterarTelefone(fornecedor.telefone[dgv_telefone.SelectedRows[0].Index]);
                alterarTelefone.ShowIcon = false;
                alterarTelefone.ShowInTaskbar = false;
                if (alterarTelefone.ShowDialog(this) == DialogResult.OK)
                {
                    carregarTelefone();
                }
            }
        }
    }
}

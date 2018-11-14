using Pegasus.Business.Implementation;
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
    public partial class AlterarFornecedor : Form
    {
        private global::Pegasus.Factory.Entities.Fornecedor fornecedor { get; set; }
        public AlterarFornecedor(global::Pegasus.Factory.Entities.Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
        }

        private void AlterarFornecedor_Load(object sender, EventArgs e)
        {
            txt_Nome.Text= fornecedor.nomeFantasia;
            txt_razao.Text = fornecedor.razaoSocial;
            txt_Numero.Text = fornecedor.numero.ToString();
            txt_Endereco.Text = fornecedor.endereco;
            mtb_cpfcnpj.Text = fornecedor.Cnpj;
            mtb_rgie.Text = fornecedor.Ie;
          //  cmb_UF.SelectedItem = fornecedor.uf;
          //  txt_Cidade.Text = fornecedor.cidade;
            txt_Bairro.Text = fornecedor.bairro;
            chx_Ativo.Checked = fornecedor.ativo;
            txt_Email.Text = fornecedor.email;
             mtb_Cep.Text = fornecedor.cep;

            foreach(global::Pegasus.Factory.Entities.Telefone t in fornecedor.telefone)
            {
                dgv_telefone.Rows.Add(t.id, t.telefone, t.tipo, t.observacao);
            }
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
                           // fornecedor.uf = cmb_UF.SelectedItem.ToString();
                          //  fornecedor.cidade = txt_Cidade.Text;
                            fornecedor.bairro = txt_Bairro.Text;
                            fornecedor.ativo = chx_Ativo.Checked;
                            fornecedor.email = txt_Email.Text;
                            fornecedor.cep = mtb_Cep.Text;


                            FornecedorImplementation fornecedorImplementation = new FornecedorImplementation();
                            fornecedorImplementation.Atualizar(fornecedor);
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
    }
}

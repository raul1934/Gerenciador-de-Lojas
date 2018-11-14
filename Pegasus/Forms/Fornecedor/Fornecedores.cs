using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pegasus.Business.Implementation;

namespace Pegasus.Controllers.Fornecedor
{
    public partial class Fornecedores : UserControl
    {
        private IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedores { get; set; }
        private IList<global::Pegasus.Factory.Entities.Estado> estados;
        private IList<global::Pegasus.Factory.Entities.Cidade> cidades;
        public Fornecedores()
        {
            InitializeComponent();
            fornecedores = new List<global::Pegasus.Factory.Entities.Fornecedor>();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            NovoFornecedor novoCliente = new NovoFornecedor();
            novoCliente.ShowInTaskbar = false;
            novoCliente.ShowIcon = false;
            DialogResult dr = novoCliente.ShowDialog();

            if (dr == DialogResult.OK)
            {
                
            }
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            estados = new EstadoImplementation().Buscar();
            cidades = new CidadeImplemtation().Buscar();
            cmb_estado.Items.Add("Todos os Estados");
            cmb_estado.SelectedIndex = 0;
            chbx_todasDatas.Checked = true;

            FornecedorImplementation fornecedoresImplementation = new FornecedorImplementation();
            fornecedores = fornecedoresImplementation.Buscar();
            foreach (global::Pegasus.Factory.Entities.Fornecedor f in fornecedores)
            {
                dgv_fornecedores.Rows.Add(f.id, f.razaoSocial, f.nomeFantasia, f.Cnpj, f.Ie, f.cidade.nome+"-"+f.estado.uf);
            }
            foreach (global::Pegasus.Factory.Entities.Estado es in estados)
            {
                cmb_estado.Items.Add(es.nome);
            }

            
            lbl_quantidade.Text = fornecedores.Count + " Fornecedore(s) Encontrados(s)";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarFornecedor alterarFornecedor = new AlterarFornecedor(new FornecedorImplementation().BuscarId(Int16.Parse(dgv_fornecedores.Rows[e.RowIndex].Cells[0].Value.ToString())));
            alterarFornecedor.ShowIcon = false;
            alterarFornecedor.ShowInTaskbar = false;
            alterarFornecedor.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedoresBusca;
            global::Pegasus.Factory.Entities.Estado estado = null;
            global::Pegasus.Factory.Entities.Cidade cidade = null;
            foreach (global::Pegasus.Factory.Entities.Estado es in estados)
            {
                if (es.nome == cmb_estado.Text)
                {
                    estado = es;
                    break;
                }
            }

            foreach (global::Pegasus.Factory.Entities.Cidade c in cidades)
            {
                if (c.nome == cmb_cidade.Text)
                {
                    cidade = c;
                    break;
                }
            }
            #region SelecaoPersonalizada
            
                if (chbx_todasDatas.Checked)
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, null, cidade, estado);
                        }
                    }
                }
                else
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            fornecedoresBusca = new FornecedorImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, null, cidade, estado);
                        }
                    }
                }
            
           




            #endregion



            dgv_fornecedores.Rows.Clear();

            foreach (global::Pegasus.Factory.Entities.Fornecedor f in fornecedoresBusca)
            {

                dgv_fornecedores.Rows.Add(f.id, f.razaoSocial, f.nomeFantasia, f.Cnpj, f.Ie, f.cidade.nome + "-" + f.estado.uf);



            }
            lbl_quantidade.Text = fornecedoresBusca.Count + " Fornecedore(s) Encontrados(s)";
        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_cidade.Items.Clear();
            cmb_cidade.Items.Add("Todas as Cidades");
            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                if (estado.nome == cmb_estado.Items[cmb_estado.SelectedIndex].ToString())
                {
                    foreach (global::Pegasus.Factory.Entities.Cidade cidade in cidades)
                    {
                        if (cidade.uf == estado.Id)
                        {
                            cmb_cidade.Items.Add(cidade.nome);

                        }

                    }
                    break;
                }
            }
            cmb_cidade.SelectedIndex = 0;
        }

        private void chbx_todasDatas_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                dtp_ate.Enabled = false;
                dtp_de.Enabled = false;
            }
            else
            {
                dtp_ate.Enabled = true;
                dtp_de.Enabled = true;
            }
        }
    }
}

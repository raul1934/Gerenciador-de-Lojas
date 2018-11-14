using NHibernate.Linq;
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

namespace Pegasus.Controllers.Cliente
{
    public partial class SelecionarCliente : Form
    {
        #region createObjects
        public global::Pegasus.Factory.Entities.Cliente cliente { get; set; }
        private IList<global::Pegasus.Factory.Entities.Cliente> clientes { get; set; }
        private ClienteImplementation clienteImplementation = new ClienteImplementation();
        private IList<global::Pegasus.Factory.Entities.Estado> estados;
        private IList<global::Pegasus.Factory.Entities.Cidade> cidades;

        #endregion

        public SelecionarCliente()
        {
            InitializeComponent();
        }

        #region LoadDataGridView
        private void SelecionarCliente_Load(object sender, EventArgs e)
        {
            clientes = clienteImplementation.BuscarbyNome();
            estados = new EstadoImplementation().Buscar();
            cidades = new CidadeImplemtation().Buscar();
            foreach(global::Pegasus.Factory.Entities.Cliente c in clientes)
            {
                dgv_cliente.Rows.Add(c.id, c.nome, c.cpfCnpj, c.rgIe, c.cidade);
            }

            estados.ForEach((rs) => 
            {
                cmb_estado.Items.Add(rs.nome);
            });
            cmb_estado.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
            chbx_todasDatas.Checked = true;
        }
        #endregion


        private void dgv_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarCliente();
        }

        #region selecionarCliente
        private void selecionarCliente()
        {
            
            if (dgv_cliente.Rows.Count > 0 && dgv_cliente.SelectedRows[0] != null)
            {
                int x = Int16.Parse(dgv_cliente.SelectedRows[0].Cells[0].Value.ToString());
                foreach (global::Pegasus.Factory.Entities.Cliente c in clientes)
                {
                    if (c.id == x)
                    {
                        this.cliente = c;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    }
                }
            }
            
        }
        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            selecionarCliente();
        }
       
        #endregion


        private void tsb_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void SelecionarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                selecionarCliente();
            }
            else if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgv_cliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                selecionarCliente();
            }
            else if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            IList<global::Pegasus.Factory.Entities.Cliente> clientesBusca;
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
            if (cmb_tipo.SelectedIndex == 1)
            {
                if (chbx_todasDatas.Checked)
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado, false);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado, false);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, mtb_rgie.Text, cidade, estado, false);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, null, cidade, estado, false);
                        }
                    }
                }
                else
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado, false);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado, false);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, mtb_rgie.Text, cidade, estado, false);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, null, cidade, estado, false);
                        }
                    }
                }
            }
            else if (cmb_tipo.SelectedIndex == 2)
            {
                if (chbx_todasDatas.Checked)
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado, true);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado, true);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, mtb_rgie.Text, cidade, estado, true);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, null, cidade, estado, true);
                        }
                    }
                }
                else
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado, true);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado, true);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value, txt_nome.Text, null, mtb_rgie.Text, cidade, estado, true);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value, txt_nome.Text, null, null, cidade, estado, true);
                        }
                    }
                }
            }
            else
            {
                if (chbx_todasDatas.Checked)
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, null, cidade, estado);
                        }
                    }
                }
                else
                {
                    if (mtb_cpfcnpj.MaskFull)
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                        }
                    }
                    else
                    {
                        if (mtb_rgie.MaskFull)
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                        }
                        else
                        {
                            clientesBusca = new ClienteImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, null, cidade, estado);
                        }
                    }
                }
            }




            #endregion



            dgv_cliente.Rows.Clear();

            foreach (global::Pegasus.Factory.Entities.Cliente c in clientesBusca)
            {
                if (c.pessoaJuridica)
                {
                    dgv_cliente.Rows.Add(c.id, "Pessoa Juridica", c.nome, c.cpfCnpj, c.endereco + ", " + c.numero, c.cidade.nome + " - " + c.estado.uf);
                }
                else
                {
                    dgv_cliente.Rows.Add(c.id, "Pessoa Fisica", c.nome, c.cpfCnpj, c.endereco + ", " + c.numero, c.cidade.nome + " - " + c.estado.uf);
                }

            }
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

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedIndex == 1)
            {
                lbl_cpfcnpj.Visible = true;
                lbl_rgie.Visible = true;
                mtb_cpfcnpj.Visible = true;
                mtb_rgie.Visible = true;

                lbl_cpfcnpj.Text = "CPF:";
                mtb_cpfcnpj.Mask = "999,999,999-99";
                lbl_rgie.Text = "RG:";
                mtb_rgie.Mask = "99,999,999-9";
                mtb_cpfcnpj.Enabled = true;
                mtb_rgie.Enabled = true;
            }
            else if (cmb_tipo.SelectedIndex == 2)
            {
                lbl_cpfcnpj.Visible = true;
                lbl_rgie.Visible = true;
                mtb_cpfcnpj.Visible = true;
                mtb_rgie.Visible = true;

                lbl_cpfcnpj.Text = "CNPJ:";
                mtb_cpfcnpj.Mask = "99,999,999/9999-99";
                lbl_rgie.Text = "IE:";
                mtb_rgie.Mask = "999,999,999,999";
                mtb_cpfcnpj.Enabled = true;
                mtb_rgie.Enabled = true;
            }
            else
            {
                mtb_cpfcnpj.Enabled = false;
                mtb_rgie.Enabled = false;
                lbl_cpfcnpj.Visible = false;
                lbl_rgie.Visible = false;
                mtb_cpfcnpj.Visible = false;
                mtb_rgie.Visible = false;
            }
        }
    }
}

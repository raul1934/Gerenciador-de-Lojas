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

namespace Pegasus.Controllers.Funcionario
{
    public partial class Funcionarios : UserControl
    {
        private IList<global::Pegasus.Factory.Entities.Funcionario> funcionarios { get; set; }
        private IList<global::Pegasus.Factory.Entities.Estado> estados;
        private IList<global::Pegasus.Factory.Entities.Cidade> cidades;
        public Funcionarios()
        {
            InitializeComponent();
        }


        private void btn_AlterarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btn_NovoCliente_Click(object sender, EventArgs e)
        {
            NovoFuncionario novoFuncionario = new NovoFuncionario();
            novoFuncionario.ShowIcon = false;
            novoFuncionario.ShowInTaskbar = false;
            novoFuncionario.ShowDialog();
        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {

        }

        private void OnLoad()
        {
            FuncionarioImplementation funcionarioImplementation = new FuncionarioImplementation();
            funcionarios = funcionarioImplementation.BuscarbyNome();
            dgv_funcionarios.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Funcionario funcionario in funcionarios)
            {
                dgv_funcionarios.Rows.Add(funcionario.id, funcionario.nome, funcionario.cpf, funcionario.rg);
            }

            estados = new EstadoImplementation().Buscar();
            cidades = new CidadeImplemtation().Buscar();
            cmb_estado.Items.Add("Todos os Estados");
            cmb_estado.SelectedIndex = 0;
            foreach (global::Pegasus.Factory.Entities.Estado estado in estados)
            {
                cmb_estado.Items.Add(estado.nome);
            }

            chbx_todasDatas.Checked = true;
            lbl_quantidade.Text = funcionarios.Count + " Funcionario(s) Encontrado(s)";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarFuncionario alterarFornecedor = new AlterarFuncionario(new FuncionarioImplementation().BuscarId(Int16.Parse(dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString())));
            alterarFornecedor.ShowIcon = false;
            alterarFornecedor.ShowInTaskbar = false;
            if (alterarFornecedor.ShowDialog() == DialogResult.OK)
            {
                OnLoad();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            IList<global::Pegasus.Factory.Entities.Funcionario> funcionarioBusca;
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
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                    }
                    else
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(null, null, txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                    }
                }
                else
                {
                    if (mtb_rgie.MaskFull)
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                    }
                    else
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(null, null, txt_nome.Text, null, null, cidade, estado);
                    }
                }
            }
            else
            {
                if (mtb_cpfcnpj.MaskFull)
                {
                    if (mtb_rgie.MaskFull)
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, mtb_rgie.Text, cidade, estado);
                    }
                    else
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, mtb_cpfcnpj.Text, null, cidade, estado);
                    }
                }
                else
                {
                    if (mtb_rgie.MaskFull)
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, mtb_rgie.Text, cidade, estado);
                    }
                    else
                    {
                        funcionarioBusca = new FuncionarioImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value.AddHours(23).AddMinutes(59).AddSeconds(59), txt_nome.Text, null, null, cidade, estado);
                    }
                }
            }





            #endregion



            dgv_funcionarios.Rows.Clear();

            foreach (global::Pegasus.Factory.Entities.Funcionario funcionario in funcionarioBusca)
            {

                dgv_funcionarios.Rows.Add(funcionario.id, funcionario.nome, funcionario.cpf, funcionario.rg);


            }
            lbl_quantidade.Text = funcionarioBusca.Count + " Funcionario(s) Encontrado(s)";
        }

        private void dtp_de_ValueChanged(object sender, EventArgs e)
        {
            dtp_ate.MinDate = dtp_de.Value;
        }

        private void chbx_todasDatas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_todasDatas.Checked)
            {
                dtp_de.Enabled = false;
                dtp_ate.Enabled = false;
            }
            else
            {
                dtp_ate.Enabled = true;
                dtp_de.Enabled = true;
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

        private void dtp_ate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
    }
}


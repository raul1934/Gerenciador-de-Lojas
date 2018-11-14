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
using NHibernate.Linq;
using Pegasus.Util;

namespace Pegasus.Controllers.OrdemServico
{
    public partial class OrdensServiço : UserControl
    {
        private IList<global::Pegasus.Factory.Entities.OrdemServico> listOrdemServico { get; set; }
        private IList<global::Pegasus.Factory.Entities.Cliente> listCliente { get; set; }
        public OrdensServiço()
        {
            InitializeComponent();
        }

        private void OrdensServiço_Load(object sender, EventArgs e)
        {

            listCliente = new ClienteImplementation().Buscar();
            listOrdemServico = new OrdemServicoImplementation().Buscar();
            listCliente.ForEach((rs) => {

                cmb_Cliente.Items.Add(rs.nome);

            });
            chbx_todasDatas.Checked = true;
            cmb_situacao.SelectedIndex = 0;
            cmb_tipo.SelectedIndex = 0;
            Carregar();
        }
        private void Carregar()
        {
            dgv_ordemServico.Rows.Clear();




            foreach (global::Pegasus.Factory.Entities.OrdemServico ordemServico in listOrdemServico)
            {
                string situacao;
                if (ordemServico.situacao == 0)
                {
                    situacao = "Em Aberto";
                }
                else if (ordemServico.situacao == 1)
                {
                    situacao = "Finalizado";
                }
                else if (ordemServico.situacao == 2)
                {
                    situacao = "Cancelado";
                }
                else
                {
                    situacao = "Aguardando Pagamento";
                }
                dgv_ordemServico.Rows.Add(ordemServico.id, ordemServico.dataInicio, ordemServico.cliente.nome, situacao);
            }
            lbl_quantidade.Text = listOrdemServico.Count + " Ordem(s) de serviço encontrada(s)";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_NovaOrdemServico_Click(object sender, EventArgs e)
        {
            NovaOrdemServiço novaOrdemServiço = new NovaOrdemServiço();
            novaOrdemServiço.ShowIcon = false;
            novaOrdemServiço.ShowInTaskbar = false;
            

            if (novaOrdemServiço.ShowDialog(this) == DialogResult.OK)
            {
                Carregar();
            }
        }

        private void btn_AlterarOrdemServico_Click(object sender, EventArgs e)
        {
            if (dgv_ordemServico.SelectedRows[0] != null && dgv_ordemServico.Rows[0].Index != -1)
            {
                VisualizarOrdemServico visualizaros = new VisualizarOrdemServico(new OrdemServicoImplementation().BuscarId(int.Parse(dgv_ordemServico.SelectedRows[0].Cells[0].Value.ToString())));
                visualizaros.ShowIcon = false;
                visualizaros.ShowInTaskbar = false;

                if (visualizaros.ShowDialog(this) == DialogResult.OK)
                {
                    Carregar();
                }
            }
        }

        private void dgv_ordemServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ordemServico.SelectedRows[0] != null && dgv_ordemServico.Rows[0].Index != -1)
            {
                VisualizarOrdemServico visualizaros = new VisualizarOrdemServico(new OrdemServicoImplementation().BuscarId(int.Parse(dgv_ordemServico.SelectedRows[0].Cells[0].Value.ToString())));
                visualizaros.ShowIcon = false;
                visualizaros.ShowInTaskbar = false;

                if (visualizaros.ShowDialog(this) == DialogResult.OK)
                {
                    Carregar();
                }
            }

        }

        private void btn_excluirOrdemServico_Click(object sender, EventArgs e)
        {
            if (dgv_ordemServico.SelectedRows[0] != null && dgv_ordemServico.Rows.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja excluir a ordem de serviço selecionada. /n As informações nela contidas não poderão ser visualizadas futuramente.", "Confirmar exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var ordemServico = listOrdemServico.Where(rs => rs.id == int.Parse(dgv_ordemServico.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault();
                    ProdutoImplementation productImplementation = new ProdutoImplementation();
                    ordemServico.produtos.ForEach((rs) =>
                    {
                        global::Pegasus.Factory.Entities.Produto p = productImplementation.BuscarId(rs.produto.id);
                        p.estoque.Last().atual += (rs.quantidade);
                        productImplementation.Atualizar(p);
                    });
                    new OrdemServicoImplementation().Deletar(ordemServico);
                    Carregar();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                dtp_de.Enabled = true;
                dtp_ate.Enabled = true;
            }
        }

        private global::Pegasus.Factory.Entities.Cliente retornaCliente()
        {
            if (cmb_situacao.SelectedIndex == 1)
            {
                return listCliente.Where(rs => rs.nome == cmb_Cliente.Text && rs.pessoaJuridica == false).FirstOrDefault();
            }
            else if (cmb_situacao.SelectedIndex == 2)
            {
                return listCliente.Where(rs => rs.nome == cmb_Cliente.Text && rs.pessoaJuridica == true).FirstOrDefault();
            }
            else
            {
                return listCliente.Where(rs => rs.nome == cmb_Cliente.Text).FirstOrDefault();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
            

            
            int id = -1;
            int.TryParse(txt_numos.Text, out id);


            
                if (!chbx_todasDatas.Checked)
                {
                    if (cmb_situacao.SelectedIndex != 0)
                    {
                        listOrdemServico = new OrdemServicoImplementation().BuscaPersonalizada(Funcoes.HoraZero(dtp_de.Value), Funcoes.HoraMaxima(dtp_ate.Value), id, cmb_situacao.SelectedIndex - 1, retornaCliente());
                        Carregar();
                    }
                    else
                    {
                        listOrdemServico = new OrdemServicoImplementation().BuscaPersonalizada(Funcoes.HoraZero(dtp_de.Value), Funcoes.HoraMaxima(dtp_ate.Value), id,null, retornaCliente());
                        Carregar();
                    }
                }
                else
                {
                    if (cmb_situacao.SelectedIndex != 0)
                    {
                        listOrdemServico = new OrdemServicoImplementation().BuscaPersonalizada(null, null, id, cmb_situacao.SelectedIndex - 1, retornaCliente());
                        Carregar();
                    }
                    else
                    {
                        listOrdemServico = new OrdemServicoImplementation().BuscaPersonalizada(null, null, id,null, retornaCliente());
                        Carregar();
                    }
                }
            
        }


        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_tipo.SelectedIndex==0)
            {
                cmb_Cliente.Items.Clear();
                listCliente.ForEach((rs) => {
                        cmb_Cliente.Items.Add(rs.nome);

                });
            }
            else if(cmb_tipo.SelectedIndex==1)
            {
                cmb_Cliente.Items.Clear();
                listCliente.ForEach((rs) => {
                    
                    if(rs.pessoaJuridica ==false)
                    {
                        cmb_Cliente.Items.Add(rs.nome);
                    }
                    

                });
            }
            else if(cmb_tipo.SelectedIndex == 2)
            {
                cmb_Cliente.Items.Clear();
                listCliente.ForEach((rs) => {

                    if (rs.pessoaJuridica == true)
                    {
                        cmb_Cliente.Items.Add(rs.nome);
                    }


                });
            }
            
        }

       
    }
}

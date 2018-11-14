using Pegasus.Business.Implementation;
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

namespace Pegasus.Controllers.Categoria
{
    public partial class SelecionarCategoria : Form
    {
       
        public SelecionarCategoria()
        {
            InitializeComponent();
            load();
        }

        private void SelecionarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {
            if (txt_categoria.Text.Length < 3 && !string.IsNullOrWhiteSpace(txt_categoria.Text))
            {
                
            }
        }
        private void load()
        {
            
        }

        private void btn_novoTelefone_Click(object sender, EventArgs e)
        {
            NovaCategoria novaCategoria = new NovaCategoria();
            novaCategoria.ShowIcon = false;
            novaCategoria.ShowInTaskbar = false;

            if (novaCategoria.ShowDialog(this) == DialogResult.OK)
            {
                load();
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void selecionar()
        {
            if (dgv_categoria.SelectedRows != null && dgv_categoria.Rows.Count > 0)
            {
                
            }
            else
            {
                MessageBox.Show(this, "Selecione uma Categoria", "Erro ao Selecionar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        private void dgv_categoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selecionar();
            }

        }

        private void btn_alterarTelefone_Click(object sender, EventArgs e)
        {
            if (dgv_categoria.SelectedRows[0] != null && dgv_categoria.Rows.Count > 0)
            {
               
            }

        }

        private void btn_excluirCategoria_Click(object sender, EventArgs e)
        {
            if (dgv_categoria.SelectedRows[0] != null && dgv_categoria.Rows.Count > 0)
            {
                
                
            }
        }
    }
}

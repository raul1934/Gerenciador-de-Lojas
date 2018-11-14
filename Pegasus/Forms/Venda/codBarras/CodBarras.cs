using Pegasus.Business.Implementation;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Venda.codBarras
{
    public partial class CodBarras : Form
    {
        public global::Pegasus.Factory.Entities.ProdutoVenda produto { get; set; }
        private ProdutoImplementation produtoImplementatation = new ProdutoImplementation();
        
        public CodBarras()
        {
            InitializeComponent();
        }

        private void txt_codBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.ApenasNumeros(sender, e);
        }

        #region alterarQuantidade
        private void alterarQuantidade()
        {
            produto = new global::Pegasus.Factory.Entities.ProdutoVenda();
            produto.produto = produtoImplementatation.BuscarCobBarras(txt_codBarras.Text);

            if (produto.produto != null)
            {
                produto.quantidade = 1;
                produto.desconto = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else

            {
                MessageBox.Show("Codigo de barras não encontrado");
            }
        }
        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            alterarQuantidade();
        }
        private void CodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
            {
                alterarQuantidade();
            }
            else if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txt_codBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
            {
                alterarQuantidade();
            }
            else if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
        
        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

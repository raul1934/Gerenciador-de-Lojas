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

namespace Pegasus.Controllers.Venda
{
    public partial class Quantidade : Form
    {
        #region CriarObjetos
        public global::Pegasus.Factory.Entities.ProdutoVenda produto { get; set; }
        private ProdutoImplementation produtoImplementatation = new ProdutoImplementation();
        #endregion

        public Quantidade(global::Pegasus.Factory.Entities.ProdutoVenda produto)
        {
            InitializeComponent();
            this.produto = produto;
            produto.produto = produtoImplementatation.BuscarId(produto.produto.id);
            nup_qtd.Maximum = produto.produto.estoque.Last().atual;
            nup_qtd.Value = produto.quantidade;
        }
        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            if (produto.produto != null)
            {
                produto.quantidade = nup_qtd.Value;
                produto.desconto = 0;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else

            {
                MessageBox.Show("A quantidade não pode ser igual a 0.");
            }
        }

        private void tsb_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.OrdemServico
{
    public partial class FinalizarOs : Form
    {
        public global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        public FinalizarOs()
        {
            InitializeComponent();
        }

        private void FinalizarOs_Load(object sender, EventArgs e)
        {
            foreach(global::Pegasus.Factory.Entities.ProdutoVenda produtoVenda in ordemServico.produtos)
            {
                dgv_produtos.Rows.Add(produtoVenda.produto.descricao, produtoVenda.quantidade, string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", produtoVenda.produto.precoVendaVista), string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}",  produtoVenda.quantidade * produtoVenda.produto.precoVendaVista));
            }
          
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

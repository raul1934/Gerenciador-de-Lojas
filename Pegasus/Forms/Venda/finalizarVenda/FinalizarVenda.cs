using Pegasus.Controllers.Venda.finalizarOs;
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

namespace Pegasus.Controllers.Venda
{
    public partial class FinalizarOS : Form
    {
        global::Pegasus.Factory.Entities.Venda venda;
        public FinalizarOS(global::Pegasus.Factory.Entities.Venda venda)
        {
            InitializeComponent();
            this.venda = venda;
            cmb_formaPagamento.SelectedIndex = 0;
            cmb_meioPagamento.SelectedIndex = 0;
            lbl_credito.Text = "Crédito = R$ 0,00";
            lbl_desconto.Text = "Desconto = "+Funcoes.formatarParaMoeda(venda.desconto.ToString());
            lbl_subtotal.Text = "Subtotal = " + Funcoes.formatarParaMoeda(venda.subtotal.ToString());
            lbl_total.Text = "Total = " + Funcoes.formatarParaMoeda(venda.total.ToString());
        }

        

        private void finalizarOS()
        {
            if (cmb_meioPagamento.SelectedIndex == 0)
            {
                Dinheiro d = new Dinheiro(venda.total);
                d.ShowIcon = false;
                d.ShowInTaskbar = false;
                if (d.ShowDialog(this) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            finalizarOS();
        }

        private void FinalizarOS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                finalizarOS();
            }
        }
    }
}

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

namespace Pegasus.Controllers.Venda.finalizarOs
{
    public partial class Dinheiro : Form
    {
        decimal dinheiro;
        public Dinheiro(decimal d)
        {
            InitializeComponent();
            dinheiro = d;
            txt_dinheiro.Text = d.ToString();
            txt_dinheiro.Focus();
        }

        private void Dinheiro_Load(object sender, EventArgs e)
        {
            

        }

      

        private void txt_dinheiro_Leave(object sender, EventArgs e)
        {
            txt_dinheiro.Text = Funcoes.formatarParaMoeda(txt_dinheiro.Text);
        }

        private void txt_dinheiro_Enter(object sender, EventArgs e)
        {
            
            txt_dinheiro.Text = Funcoes.parse(txt_dinheiro.Text).ToString();
        }

        private void txt_dinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                finalizar();
            }
        }

        private void finalizar()
        {
            if (Funcoes.parse(txt_dinheiro.Text) < dinheiro)
            {
                MessageBox.Show("Valor informado menor que o total do pagamento");
            }
            else
            {
                dinheiro = Funcoes.parse(txt_dinheiro.Text) - dinheiro;
                Troco troco = new Troco(dinheiro);
                troco.ShowIcon = false;
                troco.ShowInTaskbar = false;
                if(troco.ShowDialog(this) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            finalizar();
        }

        private void Dinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                finalizar();
            }
        }
    }
}

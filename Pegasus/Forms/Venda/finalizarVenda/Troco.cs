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
    public partial class Troco : Form
    {
        public Troco(decimal d)
        {
            InitializeComponent();
            txt_troco.Text = Funcoes.formatarParaMoeda(d.ToString());
        }

        private void Troco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Troco_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Gostaria de Imprimir "))
        }
    }
}

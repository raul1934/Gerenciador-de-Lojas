using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Telefone
{
    public partial class NovoTelefone : Form
    {
        public global::Pegasus.Factory.Entities.Telefone telefone { get; set; }
        public NovoTelefone()
        {
            InitializeComponent();
            telefone = new Factory.Entities.Telefone();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_formato.SelectedIndex ==0)
            {
                mtb_Numero.Mask = "(99) 9999-9999";
            }
            else if(cmb_formato.SelectedIndex == 1)
            {
                mtb_Numero.Mask = "(99) 99999-9999";
            }
            mtb_Numero.Focus();
        }

        private void NovoTelefone_Load(object sender, EventArgs e)
        {
            cmb_Tipo.SelectedIndex = 1;
            cmb_formato.SelectedIndex = 1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (mtb_Numero.MaskFull)
            {
                telefone.observacao = txt_Observacao.Text;
                telefone.tipo = cmb_Tipo.SelectedItem.ToString();
                telefone.telefone = mtb_Numero.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Informe um numero de Telefone valido.", "Numero de Telefone Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

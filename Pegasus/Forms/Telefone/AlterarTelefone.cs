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
    public partial class AlterarTelefone : Form
    {
       public global::Pegasus.Factory.Entities.Telefone telefone { get; set; }
        public AlterarTelefone(global::Pegasus.Factory.Entities.Telefone telefone)
        {
            InitializeComponent();
            this.telefone = telefone;
        }

        private void AlterarTelefone_Load(object sender, EventArgs e)
        {
            if(telefone.telefone.Length>13)
            {
                cmb_formato.SelectedIndex = 1;
            }
            else
            {
                cmb_formato.SelectedIndex = 0;
            }
            mtb_Numero.Text = telefone.telefone;
            cmb_Tipo.Text = telefone.tipo;
            txt_Observacao.Text = telefone.observacao;


        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            telefone.telefone = mtb_Numero.Text;
            telefone.tipo = cmb_Tipo.Text;
            telefone.observacao = txt_Observacao.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_formato_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_formato.SelectedIndex == 0)
            {
                mtb_Numero.Mask = "(99) 9999-9999";
            }
            else if (cmb_formato.SelectedIndex == 1)
            {
                mtb_Numero.Mask = "(99) 99999-9999";
            }
            mtb_Numero.Focus();
        }
    }
}

﻿using Pegasus.Business.Implementation;
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
    public partial class AlterarCategoria : Form
    {
        
        public AlterarCategoria()
        {
            InitializeComponent();
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_descricao.Text))
            {

               
               

            }
            else
            {
                MessageBox.Show(this, "Informe a descrição", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txt_descricao.Focus();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

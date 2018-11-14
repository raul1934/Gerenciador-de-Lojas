using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Produtos
{
    public partial class QtdDesc : Form
    {
        public global::Pegasus.Factory.Entities.Produto produto { get; set; }
        public Decimal qtd { get; set; }
        public QtdDesc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.qtd = numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void QtdDesc_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if((numericUpDown1.Value)> produto.estoque.Last().atual)
            {
                numericUpDown1.Value = Convert.ToDecimal(produto.estoque);
            }
            else if(numericUpDown1.Value <=0)
            {
                numericUpDown1.Value = 1;
            }
        }
    }
}

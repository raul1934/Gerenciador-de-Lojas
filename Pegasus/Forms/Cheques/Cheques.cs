using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pegasus.Business.Implementation;
using Pegasus.Factory.Entities;

namespace Pegasus.Controllers.Cheques
{
    public partial class Cheques : UserControl
    {
        public Cheques()
        {
            InitializeComponent();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            NovoCheque novoCheque = new NovoCheque();
            novoCheque.ShowIcon = false;
            novoCheque.ShowInTaskbar = false;
            novoCheque.ShowDialog(this);
        }

        private void Cheques_Load(object sender, EventArgs e)
        {
            ChequeImplementation chequeImplementation = new ChequeImplementation();

            IList<Cheque> cheques = chequeImplementation.Buscar();

            foreach(global::Pegasus.Factory.Entities.Cheque cheque in cheques)
            {
                MessageBox.Show(cheque.baixadoem.ToString());
                dgv_cheques.Rows.Add(cheque.id, cheque.emitente, cheque.valor, cheque.vencimento, cheque.baixadoem);
            }
        }
    }
}

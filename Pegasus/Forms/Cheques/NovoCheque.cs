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

namespace Pegasus.Controllers.Cheques
{
    public partial class NovoCheque : Form
    {
        global::Pegasus.Factory.Entities.Cheque cheque { get; set; }
        public NovoCheque()
        {
            InitializeComponent();
            cheque = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cheque = new Factory.Entities.Cheque();

            cheque.emissao = txt_emissao.Text;
            cheque.emitente = txt_emitente.Text;
            cheque.numero = txt_numeroCheque.Text;
            cheque.numeroAgencia = txt_numeroAgencia.Text;
            cheque.numeroBanco = txt_numeroBanco.Text;
            cheque.pago = false;
            cheque.baixadoem = txt_baixadoEm.Text;
            cheque.observacoes = txt_observacoes.Text;
            cheque.vencimento = txt_vencimento.Text;
            cheque.valor = Decimal.Parse(txt_valor.Text.ToString());
            cheque.desconto = Decimal.Parse(txt_desconto.Text.ToString());
            ChequeImplementation clienteImplementation = new ChequeImplementation();

            clienteImplementation.Inserir(cheque);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}

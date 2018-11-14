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

namespace Pegasus.Controllers.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logar()
        {
            FuncionarioImplementation funcionarioImplementation = new FuncionarioImplementation();
            global::Pegasus.Factory.Entities.Funcionario f = funcionarioImplementation.logar(mtb_cpf.Text, txt_senha.Text);

            if (f != null)
            {
                FuncionarioLogado.funcionarioLogado = f;
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Credencias invalidas.", "Erro ao fazer login:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)Keys.Enter)
            {
                logar();
            }
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logar();
            }
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}

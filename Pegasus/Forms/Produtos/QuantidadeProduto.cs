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

namespace Pegasus.Controllers.Produtos
{
    public partial class QuantidadeProduto : Form
    {
        public global::Pegasus.Factory.Entities.ProdutoVenda produto;
        
        public QuantidadeProduto(global::Pegasus.Factory.Entities.ProdutoVenda produto,Boolean AlterarQuantidade)
        {
            
           
            this.produto = produto;
            InitializeComponent();
            if(AlterarQuantidade)
            {
                lbl_nomeProduto.Text = produto.produto.descricao;
                nup_quantidade.Maximum = produto.produto.estoque.Last().atual + produto.quantidade;
                nup_quantidade.Value = produto.quantidade;
                lbl_estoque.Text = "de " + nup_quantidade.Maximum + " disponiveis.";
            }
            else
            {
                lbl_nomeProduto.Text = produto.produto.descricao;
                nup_quantidade.Maximum = produto.produto.estoque.Last().atual;
                nup_quantidade.Value = produto.quantidade;
                lbl_estoque.Text = "de " + nup_quantidade.Maximum + " disponiveis.";
            }
           
            
        }
        
        
        private void AlterarQuantidade_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ConfirmarSelecao();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarSelecao()
        {
            if (nup_quantidade.Value > 0)
            {
                produto.quantidade = nup_quantidade.Value;
                produto.produto.estoque.Last().atual = nup_quantidade.Maximum - nup_quantidade.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("A quantidade do produto precisa ser maior que 0.", "Erro ao salvar.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void QuantidadeProduto_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Teste KeyUP");
            if(e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
            {
                ConfirmarSelecao();
            }else if( e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

using Pegasus.Business.Implementation;
using Pegasus.Factory.Entities;
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
    public partial class Produtos : UserControl
    {
        ProdutoImplementation produtoImplementation = new ProdutoImplementation();

        IList<Produto> produtos;
        IList<Marca> marcas;
        IList<global::Pegasus.Factory.Entities.Categoria> categorias;
        IList<global::Pegasus.Factory.Entities.SubCategoria> subcategorias;
        IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedores;

        public Produtos()
        {
            InitializeComponent();
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {

            NovoProduto novoProduto = new NovoProduto();
            novoProduto.ShowInTaskbar = false;
            novoProduto.ShowIcon = false;
            DialogResult dr = novoProduto.ShowDialog();

            if (dr == DialogResult.OK)
            {
                produtos = produtoImplementation.BuscarbyDescricaoAtivo();
                CarregarProdutos();
            }


        }

        private void CarregarProdutos()
        {
            dgv_produtos.Rows.Clear();
            foreach (Produto p in produtos)
            {
                dgv_produtos.Rows.Add(p.id, p.descricao, p.codigoBarras, Math.Round(p.estoque.Last().atual, 2), p.preco.Last().precoVendaVista, p.preco.Last().precoVendaPrazo);
            }
        }



        private void dtp_de_ValueChanged(object sender, EventArgs e)
        {
            dtp_ate.MinDate = dtp_de.Value;
        }

        private void dtp_ate_ValueChanged(object sender, EventArgs e)
        {
            dtp_ate.MinDate = dtp_de.Value;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            IList<Produto> produtosBuscados;
            global::Pegasus.Factory.Entities.Marca marca = null;
            global::Pegasus.Factory.Entities.Fornecedor fornecedor = null;
            global::Pegasus.Factory.Entities.Categoria categoria = null;
            global::Pegasus.Factory.Entities.SubCategoria subcategoria = null;

            foreach (global::Pegasus.Factory.Entities.Marca m in marcas)
            {
                if (m.nome == cmb_marca.Text)
                {
                    marca = m;
                    break;
                }
            }
            foreach (global::Pegasus.Factory.Entities.Fornecedor f in fornecedores)
            {
                if (f.nomeFantasia == cmb_fornecedor.Text)
                {
                    fornecedor = f;
                    break;
                }
            }
            foreach (global::Pegasus.Factory.Entities.Categoria c in categorias)
            {
                if (c.categoria == cmb_categoria.Text)
                {
                    categoria = c;
                    break;
                }
            }
            foreach (global::Pegasus.Factory.Entities.SubCategoria sc in subcategorias)
            {
                if (sc.categoria == cmb_subcategoria.Text)
                {
                    subcategoria = sc;
                    break;
                }
            }

            if (chbx_todasDatas.Checked)
            {
                produtosBuscados = new ProdutoImplementation().BuscaPersonalizada(null, null, txt_descricao.Text, txt_ean.Text, marca, fornecedor, categoria, subcategoria);
            }
            else
            {
                produtosBuscados = new ProdutoImplementation().BuscaPersonalizada(dtp_de.Value, dtp_ate.Value, txt_descricao.Text, txt_ean.Text, marca, fornecedor, categoria, subcategoria);
            }

            dgv_produtos.Rows.Clear();
            foreach (Produto p in produtosBuscados)
            {
                dgv_produtos.Rows.Add(p.id, p.descricao, p.codigoBarras, p.estoque.Last().atual, p.preco.Last().precoVendaVista, p.preco.Last().precoVendaPrazo);
            }
            lbl_quantidade.Text = produtosBuscados.Count + " Produto(s) Encontrado(s)";
        }

    

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.Rows.Count != 0 && dgv_produtos.SelectedRows[0] != null)
            {
                AlterarProduto alteararProduto = new AlterarProduto();
                alteararProduto.produto = new ProdutoImplementation().BuscarId(Int16.Parse(dgv_produtos.Rows[dgv_produtos.SelectedRows[0].Index].Cells[0].Value.ToString()));
                alteararProduto.ShowIcon = false;
                alteararProduto.ShowInTaskbar = false;
                alteararProduto.ShowDialog();
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_produtos.Rows.Count != 0 && dgv_produtos.SelectedRows[0] != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Confirmar Exclusão?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    Produto produto = new ProdutoImplementation().BuscarId(Int16.Parse(dgv_produtos.Rows[dgv_produtos.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    ProdutoImplementation p = new ProdutoImplementation();
                    if (produto.estoque.Last().atual != 0)
                    {
                        MessageBox.Show("Não é possivel excluir o produto selecionado, ainda existem " + Math.Round(produto.estoque.Last().atual, 2) + " em estoque", "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        produto.ativo = false;
                        produto.preco.Last().ativo = false;
                        produto.preco.Last().dataFim = DateTime.Now;
                        produto.dataFim = DateTime.Now;
                        p.Atualizar(produto);
                        CarregarProdutos();
                    }


                }
            }
        }

        private void dgv_produtos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarProduto alteararProduto = new AlterarProduto();
            alteararProduto.produto = new ProdutoImplementation().BuscarId(Int16.Parse(dgv_produtos.Rows[e.RowIndex].Cells[0].Value.ToString()));
            alteararProduto.ShowIcon = false;
            alteararProduto.ShowInTaskbar = false;
            alteararProduto.ShowDialog();
        }

        private void chbx_todasDatas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_todasDatas.Checked)
            {
                dtp_ate.Enabled = false;
                dtp_de.Enabled = false;
            }
            else
            {
                dtp_ate.Enabled = true;
                dtp_de.Enabled = true;
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            produtos = produtoImplementation.BuscarbyDescricaoAtivo();
            marcas = new MarcaImplementation().Buscar();
            fornecedores = new FornecedorImplementation().Buscar();
            subcategorias = new SubCategoriaImplementation().Buscar();
            categorias = new CategoriaImplementation().Buscar();
            cmb_subcategoria.Items.Add("Nenhuma Subcategoria");
            cmb_categoria.Items.Add("Nenhuma Categoria");
            cmb_fornecedor.Items.Add("Nenhuma Fornecedor");
            cmb_marca.Items.Add("Nenhuma Marca");
            cmb_categoria.SelectedIndex = 0;
            cmb_fornecedor.SelectedIndex = 0;
            cmb_marca.SelectedIndex = 0;
            cmb_subcategoria.SelectedIndex = 0;
            chbx_todasDatas.Checked = true;
            CarregarProdutos();
            foreach (global::Pegasus.Factory.Entities.SubCategoria subcategoria in subcategorias)
            {
                cmb_subcategoria.Items.Add(subcategoria.categoria);
            }

            foreach (global::Pegasus.Factory.Entities.Categoria categoria in categorias)
            {
                cmb_categoria.Items.Add(categoria.categoria);
            }
            foreach (global::Pegasus.Factory.Entities.Marca marca in marcas)
            {
                cmb_marca.Items.Add(marca.nome);
            }
            foreach (global::Pegasus.Factory.Entities.Fornecedor fornecedor in fornecedores)
            {
                cmb_fornecedor.Items.Add(fornecedor.nomeFantasia);
            }
            lbl_quantidade.Text = produtos.Count + " Produto(s) Encontrado(s)";
        }
    }
}

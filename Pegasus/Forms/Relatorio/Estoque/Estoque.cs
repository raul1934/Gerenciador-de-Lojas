using Pegasus.Business;
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

namespace Pegasus.Controllers.Relatorio.Estoque
{
    public partial class Estoque : Form
    {
        public IList<global::Pegasus.Factory.Entities.Produto> produtosDataBase { get; set; }
        public IList<global::Pegasus.Factory.Entities.Produto> produtosDataGridView { get; set; }
        public IList<global::Pegasus.Factory.Entities.Categoria> categorias { get; set; }
        public IList<global::Pegasus.Factory.Entities.SubCategoria> subCategorias { get; set; }

        public Estoque()
        {
            InitializeComponent();
            produtosDataGridView = new List<global::Pegasus.Factory.Entities.Produto>();
            produtosDataBase = new List<global::Pegasus.Factory.Entities.Produto>();
            cmb_categoria.Items.Add("Nenhuma Categoria");
            cmb_fornecedor.Items.Add("Nenhum Fornecedor");
            cmb_subCategoria.Items.Add("Nenhuma Sub-Categoria");

            cmb_categoria.SelectedIndex = 0;
            cmb_fornecedor.SelectedIndex = 0;
            cmb_ordem.SelectedIndex = 0;
            cmb_subCategoria.SelectedIndex = 0;
        }

        private void Estoque1_Load(object sender, EventArgs e)
        {
            CategoriaImplementation categoriaImplementation = new CategoriaImplementation();
            categorias = categoriaImplementation.BuscarbyCategoria();


            foreach (global::Pegasus.Factory.Entities.Categoria c in categorias)
            {
                cmb_categoria.Items.Add(c.categoria);
            }

            SubCategoriaImplementation subCategoriaImplementation = new SubCategoriaImplementation();
            subCategorias = subCategoriaImplementation.BuscarbySubCategoria();
            foreach (global::Pegasus.Factory.Entities.SubCategoria c in subCategorias)
            {
                cmb_subCategoria.Items.Add(c.categoria);
            }

            ProdutoImplementation produtoImplementation = new ProdutoImplementation();

            this.produtosDataBase = produtoImplementation.Buscar();


            foreach (global::Pegasus.Factory.Entities.Produto p in produtosDataBase)
            {
                produtosDataGridView.Add(p);
            }


            loadDataGridView();
        }
        private void loadDataGridView()
        {
            
        }

        private void onChangedSearchOptions()
        {
            produtosDataGridView.Clear();
            dataGridView1.Rows.Clear();
            foreach (global::Pegasus.Factory.Entities.Produto p in produtosDataBase)
            {
                if (p.fornecedor != null)
                {
                    if (p.categoria.categoria == cmb_categoria.Text && p.fornecedor.nomeFantasia + "" == cmb_fornecedor.Text + "" && p.descricao.Contains(txt_descricao.Text))
                    {
                        produtosDataGridView.Add(p);
                    }
                }
                else
                {
                    if (cmb_categoria.Text != "Nenhuma Categoria")
                    {
                        if (p.categoria.categoria == cmb_categoria.Text && p.descricao.Contains(txt_descricao.Text) && cmb_subCategoria.Text == "Nenhuma Sub-Categoria")
                        {
                            produtosDataGridView.Add(p);
                        }
                        else if (p.categoria.categoria == cmb_categoria.Text && p.descricao.Contains(txt_descricao.Text) && p.subcategoria.categoria == cmb_subCategoria.Text)
                        {
                            produtosDataGridView.Add(p);
                        }
                    }
                    else
                    {
                        if (p.descricao.Contains(txt_descricao.Text) && cmb_subCategoria.Text == "Nenhuma Sub-Categoria")
                        {
                            produtosDataGridView.Add(p);
                        }
                        else if (p.descricao.Contains(txt_descricao.Text) && p.subcategoria.categoria == cmb_subCategoria.Text)
                        {
                            produtosDataGridView.Add(p);
                        }
                    }

                }

            }
            loadDataGridView();
        }

        private void cmb_ordem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ordem.SelectedIndex == 0)
            {
                produtosDataGridView = produtosDataGridView.OrderBy(n => n.descricao).ToList();
                loadDataGridView();
            }
        }

        private void cmb_subCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            onChangedSearchOptions();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            onChangedSearchOptions();
        }

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_imprimir_Click(object sender, EventArgs e)
        {
            ImprimirRelatorioEstoque imprimirRelatorioEstoque = new ImprimirRelatorioEstoque(produtosDataGridView);
            
        }
    }
}

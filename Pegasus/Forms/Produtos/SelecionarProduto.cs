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
    public partial class SelecionarProduto : Form
    {
        public global::Pegasus.Factory.Entities.ProdutoVenda produto { get; set; }
        private IList<Produto> produtosBuscados;
        private ProdutoVenda produtoAlterado;
        IList<Produto> produtos;
        IList<Marca> marcas;
        IList<global::Pegasus.Factory.Entities.Categoria> categorias;
        IList<global::Pegasus.Factory.Entities.SubCategoria> subcategorias;
        IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedores;
        public SelecionarProduto(global::Pegasus.Factory.Entities.ProdutoVenda pv = null)
        {
            InitializeComponent();
            if(pv!=null)
            {
                produtoAlterado = pv;
            }
            else
            {
                produtoAlterado = new ProdutoVenda();
            }
            produto = new Factory.Entities.ProdutoVenda();
            produtosBuscados = null;
        }
        #region LoadProduto
        private void SelecionarProduto_Load(object sender, EventArgs e)
        {
            produtos = new ProdutoImplementation().BuscarbyDescricaoAtivo();
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

            ProdutoImplementation produtoImplementation = new ProdutoImplementation();
            produtosBuscados = produtoImplementation.BuscarbyDescricaoAtivo();
            foreach (global::Pegasus.Factory.Entities.Produto prod in produtosBuscados)
            {
                
                if(produtoAlterado == null)
                {
                    dgv_produtos.Rows.Add(prod.id, prod.descricao, prod.codigoBarras, prod.estoque.Last().atual, prod.preco.Last().precoVendaVista, prod.preco.Last().precoVendaPrazo);
                    
                    
                }
                else if(produtoAlterado.produto != null)
                {
                    dgv_produtos.Rows.Add(prod.id, prod.descricao, prod.codigoBarras, prod.estoque.Last().atual - produtoAlterado.quantidade, prod.preco.Last().precoVendaVista, prod.preco.Last().precoVendaPrazo);
                }
                
            }
        }
        #endregion

        #region SelecionarProduto
        private void dgv_Produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selecionarProduto();
            
        }

        private void selecionarProduto()
        {
            if(dgv_produtos.Rows.Count>0 && dgv_produtos.SelectedRows[0]!=null)
            {
                int index = Int16.Parse(dgv_produtos.Rows[dgv_produtos.SelectedRows[0].Index].Cells[0].Value.ToString());

                foreach (global::Pegasus.Factory.Entities.Produto prod in produtosBuscados)
                {
                    if (prod.id == index)
                    {
                        if(prod.id == produtoAlterado.produto.id)
                        {
                            this.produto.produto = prod;
                            produto.quantidade -= produtoAlterado.quantidade;
                            QuantidadeProduto QtdProduto = new QuantidadeProduto(produto, false);
                            QtdProduto.ShowIcon = false;
                            QtdProduto.ShowInTaskbar = false;

                            if (QtdProduto.ShowDialog(this) == DialogResult.OK)
                            {

                                this.produto.quantidade = QtdProduto.produto.quantidade;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                break;
                            }
                        }
                        else
                        {
                            this.produto.produto = prod;
                            QuantidadeProduto QtdProduto = new QuantidadeProduto(produto, false);
                            QtdProduto.ShowIcon = false;
                            QtdProduto.ShowInTaskbar = false;

                            if (QtdProduto.ShowDialog(this) == DialogResult.OK)
                            {

                                this.produto.quantidade = QtdProduto.produto.quantidade;
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                break;
                            }
                        }
                       
                       
                        
                    }
                }
            }
            

        }
        #endregion

        #region AtualizarQuantidade
        

       
        #endregion

        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            selecionarProduto();
        }

        private void tsb_sair_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
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
        }

        private void SelecionarProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                selecionarProduto();
            }
            else if (e.KeyCode == Keys.F12 || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

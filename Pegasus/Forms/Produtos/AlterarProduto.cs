using Pegasus.Business.Implementation;

using Pegasus.Factory.Entities;
using Pegasus.Properties;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Produtos
{
    public partial class AlterarProduto : Form
    {
        public global::Pegasus.Factory.Entities.Produto produto { get; set; }
        private IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedores;
        private IList<global::Pegasus.Factory.Entities.Categoria> categorias;
        private IList<global::Pegasus.Factory.Entities.SubCategoria> subCategorias;
        private IList<global::Pegasus.Factory.Entities.Marca> marcas;

        public AlterarProduto()
        {
            InitializeComponent();
            
        }


        private void AlterarProduto_Load(object sender, EventArgs e)
        {
            txt_CodBarras.Text = produto.codigoBarras;
            txt_CodInterno.Text = produto.codInterno;
            txt_descricao.Text = produto.descricao;
            txt_especificacao.Text = produto.especificacao;
            chbx_nControlarEstoque.Checked = produto.naoControlarEstoque;
            
            mtb_corredor.Text = produto.corredor;
            mtb_prateleira.Text = produto.prateleira;
            mtb_EstoqueAtual.Text = produto.estoque.Last().atual.ToString();
            
            txt_deCompraAcrescimo.Text = (produto.preco.Last().acrescimoDeCompra/100).ToString("P");
            txt_freteAcrescimo.Text = (produto.preco.Last().acrescimoFrete / 100).ToString("P");
            txt_margemLucroPrazo.Text = (produto.preco.Last().margemLucroPrazo / 100).ToString("P");
            txt_margemLucroVista.Text = (produto.preco.Last().margemLucroVista / 100).ToString("P");
            
            
            txt_deCompra.Text = Funcoes.formatarParaMoeda((produto.preco.Last().precodeCompra).ToString());
            txt_frete.Text = Funcoes.formatarParaMoeda((produto.preco.Last().precoFrete).ToString());
            txt_peso.Text = Double.Parse(produto.peso.ToString()).ToString()+" kg";
            txt_comprimento.Text= Double.Parse(produto.comprimento.ToString()).ToString()+" cm";
            txt_altura.Text= Double.Parse(produto.altura.ToString()).ToString() + " cm";
            txt_largura.Text= Double.Parse(produto.largura.ToString()).ToString() + " cm";
            cmb_UnidadeMedida.SelectedItem = produto.unidadeMedida;
           
         
            cmb_UnidadeMedida.SelectedText = produto.unidadeMedida;

            FornecedorImplementation fornecedorImplementation = new FornecedorImplementation();
            fornecedores = fornecedorImplementation.Buscar();
            if (fornecedores.Count > 0)
            {
                cmb_fornecedor.MaxDropDownItems = fornecedores.Count;
            }

            foreach (global::Pegasus.Factory.Entities.Fornecedor f in fornecedores)
            {
                if (f.nomeFantasia != null)
                {
                    cmb_fornecedor.Items.Add(f.nomeFantasia);
                }
            }
            
            if(produto.fornecedor!=null)
            {
                cmb_fornecedor.SelectedItem = produto.fornecedor.nomeFantasia;
            }

            CategoriaImplementation categoriaImplementation = new CategoriaImplementation();
            categorias = categoriaImplementation.Buscar();

            if (categorias.Count > 0)
            {
                cmb_Categoria.MaxDropDownItems = categorias.Count;
                cmb_subCategoria.MaxDropDownItems = categorias.Count;
            }

            foreach (global::Pegasus.Factory.Entities.Categoria c in categorias)
            {
                if (!String.IsNullOrWhiteSpace(c.categoria))
                {
                    cmb_Categoria.Items.Add(c.categoria);
                }

            }

            if (produto.categoria != null)
            {
                cmb_Categoria.SelectedItem = produto.categoria.categoria;
            }

           

            SubCategoriaImplementation subCategoriaImplementation = new SubCategoriaImplementation();
            subCategorias = subCategoriaImplementation.BuscarbySubCategoria();
            foreach (global::Pegasus.Factory.Entities.SubCategoria c in subCategorias)
            {
                cmb_subCategoria.Items.Add(c.categoria);
            }

            if (produto.subcategoria != null)
            {
                cmb_subCategoria.SelectedItem = produto.subcategoria.categoria;
            }

            MarcaImplementation marcaImplementation = new MarcaImplementation();
            marcas = marcaImplementation.Buscar();

            
            
            foreach (global::Pegasus.Factory.Entities.Marca m in marcas)
            {
                if (!String.IsNullOrWhiteSpace(m.nome))
                {
                    cmb_marca.Items.Add(m.nome);
                }

            }

            if (produto.marca != null)
            {
                cmb_marca.SelectedItem = produto.marca.nome;
            }

            if(produto.imagem!=null)
            {
                using (var ms = new MemoryStream(produto.imagem))
                {
                    ptb_Imagem.Image =  Image.FromStream(ms);
                    ptb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                
            }

            txt_precoCusto.Text = Convert.ToDecimal(produto.preco.Last().precoDeCusto.ToString()).ToString("C");
            txt_precoVista.Text = Funcoes.formatarParaMoeda(produto.preco.Last().precoVendaVista.ToString());
            txt_precoPrazo.Text = Funcoes.formatarParaMoeda(produto.preco.Last().precoVendaPrazo.ToString());
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
                if (!string.IsNullOrWhiteSpace(txt_descricao.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txt_especificacao.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(cmb_Categoria.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(cmb_subCategoria.Text))
                            {
                                if (!string.IsNullOrWhiteSpace(cmb_marca.Text))
                                {
                                    if (Funcoes.parse(txt_deCompra.Text) > 0m)
                                    {
                                        if (Funcoes.parse(txt_precoCusto.Text) > 0m)
                                        {
                                            
                                            //DESCRICAO CATEGORIA SUBCATEGORIA MARCA
                                            produto.descricao = txt_descricao.Text;
                                            produto.categoria.categoria = cmb_Categoria.Text.ToString();
                                            produto.subcategoria.categoria = cmb_subCategoria.Text.ToString();
                                            produto.marca.nome = cmb_marca.Text.ToString();


                                            //COMPRA CUSTO FRETE ACRESCIMOCOMPRA ACRESCIMOFRETE
                                            ProdutoPreco preco = new ProdutoPreco();
                                        preco.precodeCompra = Funcoes.parse(txt_deCompra.Text);
                                            preco.precoDeCusto = Funcoes.parse(txt_precoCusto.Text);
                                            preco.precoFrete = Funcoes.parse(txt_frete.Text);
                                            preco.acrescimoDeCompra = Funcoes.parse(txt_deCompraAcrescimo.Text);
                                            preco.acrescimoFrete = Funcoes.parse(txt_freteAcrescimo.Text);
                                            preco.margemLucroVista = Funcoes.parse(txt_margemLucroVista.Text);
                                            preco.margemLucroPrazo = Funcoes.parse(txt_margemLucroPrazo.Text);
                                            preco.precoVendaPrazo = Funcoes.parse(txt_precoPrazo.Text);
                                            preco.precoVendaVista = Funcoes.parse(txt_precoVista.Text);
                                            produto.preco.Last().ativo = false;
                                            produto.preco.Last().dataFim = DateTime.Now;
                                            preco.dataInicio = DateTime.Now;
                                            produto.preco.Add(preco);

                                            //PESO COMPRIMENTO ALTURA LARGURA
                                            produto.peso = Funcoes.parse(txt_peso.Text);
                                            produto.comprimento = Funcoes.parse(txt_comprimento.Text);
                                            produto.altura = Funcoes.parse(txt_altura.Text);
                                            produto.largura = Funcoes.parse(txt_largura.Text);

                                            //CORREDOR PRATELEIRA CODBARRAS CODINTERNO
                                            produto.corredor = mtb_corredor.Text;
                                            produto.prateleira = mtb_prateleira.Text;
                                            produto.codigoBarras = txt_CodBarras.Text;
                                            produto.codInterno = txt_CodInterno.Text;
                                            produto.unidadeMedida = cmb_UnidadeMedida.Text;

                                            ProdutoEstoque estoque = new ProdutoEstoque();
                                            estoque.atual = Decimal.Parse(mtb_EstoqueAtual.Text);
                                            
                                            estoque.ativo = true;
                                            estoque.dataInicio = DateTime.Now;

                                            produto.estoque.Last().dataFim = DateTime.Now;
                                            produto.estoque.Last().ativo = false;

                                            produto.estoque.Add(estoque);
                                            //MAGENLUCROVISTA MARGEM

                                            produto.naoControlarEstoque = chbx_nControlarEstoque.Checked;
                                            
                                         

                                            // IMAGEM
                                            if (ptb_Imagem.Image != null)
                                            {
                                            Image im = ptb_Imagem.Image;

                                            using (var ms = new MemoryStream())
                                            {
                                                //ptb_Imagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                               // produto.imagem = ms.ToArray();
                                            }
                                            
                                                
                                            }

                                            if (cmb_fornecedor.SelectedItem != null)
                                            {

                                                produto.fornecedor = fornecedores.ElementAt(cmb_fornecedor.SelectedIndex);
                                            }
                                            else
                                            {
                                                produto.fornecedor = null;
                                            }
                                            
                                            ProdutoImplementation produtoImplementation = new ProdutoImplementation();
                                            produtoImplementation.Atualizar(produto);
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show(this, "Informe o preco de compra do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "Informe o preco de compra do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "Informe a marca do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "Informe a sub-categoria do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }

                        }
                        else
                        {
                            MessageBox.Show(this, "Informe a categoria do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Informe a especificação do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Informe a descricão do produto:", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
            
        

        

        private void ptb_Imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files|*.JPG";
            openFileDialog1.Title = "Select a Cursor File";
            openFileDialog1.Multiselect = false;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.

                ptb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb_Imagem.Image = Image.FromFile(openFileDialog1.FileName);
                // pictureBox1.Image.
            }
            else if (dr == DialogResult.Cancel)
            {
                ptb_Imagem.SizeMode = PictureBoxSizeMode.CenterImage;
                ptb_Imagem.Image = Resources.picture;

            }
        }

        private void txt_frete_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_deCompra_Enter(object sender, EventArgs e)
        {
            txt_deCompra.Text = txt_deCompra.Text.Replace("$", "").Replace("R", "").Trim();
            txt_deCompra.SelectAll();
        }

        private void txt_deCompra_Leave(object sender, EventArgs e)
        {
            txt_deCompra.Text = Util.Funcoes.formatarParaMoeda(txt_deCompra.Text);
            PrecoCusto();
        }

        private void txt_frete_Enter(object sender, EventArgs e)
        {
            txt_frete.Text = txt_frete.Text.Replace("$", "").Replace("R", "").Trim();
            txt_frete.SelectAll();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_frete_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Convert.ToDouble(txt.Text).ToString("C");
            PrecoCusto();
        }

        private void txt_deCompraAcrescimo_Enter(object sender, EventArgs e)
        {
            txt_deCompraAcrescimo.Text = txt_deCompraAcrescimo.Text.Replace("%", "").Trim();
            txt_deCompraAcrescimo.SelectAll();

        }

        private void txt_deCompraAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_deCompraAcrescimo_Leave(object sender, EventArgs e)
        {
            txt_deCompraAcrescimo.Text = Funcoes.formatarParaPorcentagem(txt_deCompraAcrescimo.Text);
            PrecoCusto();

        }

        private void mtb_freteAcrescimo_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            string result = (Decimal.Parse(txt.Text) / 100).ToString("P");
            txt.Text = result;
            PrecoCusto();
        }

        private void mtb_freteAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void PrecoCusto()
        {
            decimal d = (Funcoes.parse(txt_deCompra.Text) + (Funcoes.parse(txt_deCompra.Text) * Funcoes.parse(txt_deCompraAcrescimo.Text) / 100)) +
                        (Funcoes.parse(txt_frete.Text) + (Funcoes.parse(txt_frete.Text) * Funcoes.parse(txt_freteAcrescimo.Text) / 100));

            txt_precoCusto.Text = Convert.ToDouble(d.ToString()).ToString("C");
        }

        private void txt_freteAcrescimo_Enter(object sender, EventArgs e)
        {
            txt_freteAcrescimo.Text = txt_freteAcrescimo.Text.Replace("%", "").Trim();
        }

        private void txt_freteAcrescimo_Leave(object sender, EventArgs e)
        {
            txt_freteAcrescimo.Text = Funcoes.formatarParaPorcentagem(txt_freteAcrescimo.Text);
        }

        private void txt_freteAcrescimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_precoCusto_TextChanged(object sender, EventArgs e)
        {
            txt_precoVista.Text = Convert.ToDouble(Funcoes.parse(txt_precoCusto.Text).ToString()).ToString("C");
            txt_precoPrazo.Text = Convert.ToDouble(Funcoes.parse(txt_precoCusto.Text).ToString()).ToString("C");
        }

        private void txt_precoVista_Leave(object sender, EventArgs e)
        {
            txt_precoVista.Text = Convert.ToDouble(Funcoes.parse(txt_precoVista.Text).ToString()).ToString("C");
            if (Funcoes.parse(txt_precoCusto.Text) != 0)
            {
                txt_margemLucroVista.Text = ((Funcoes.parse(txt_precoVista.Text) / Funcoes.parse(txt_precoCusto.Text) - 1)).ToString("P");
            }
            else
            {
                txt_margemLucroVista.Text = (0).ToString("P");
            }




        }

        private void txt_precoVista_Enter(object sender, EventArgs e)
        {
            txt_precoVista.Text = txt_precoVista.Text.Replace("$", "").Replace("R", "").Trim();
            txt_precoVista.SelectAll();
        }

        private void txt_precoVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_margemLucroVista_Enter(object sender, EventArgs e)
        {
            txt_margemLucroVista.Text = Funcoes.parse(txt_margemLucroVista.Text).ToString();
        }

        private void txt_margemLucroVista_Leave(object sender, EventArgs e)
        {
            if (!produto.servico)
            {
                txt_margemLucroVista.Text = (Decimal.Parse(txt_margemLucroVista.Text) / 100).ToString("P");
                Decimal precoCusto = Decimal.Parse(Funcoes.parse(txt_precoCusto.Text).ToString());
                Decimal precoVista = (Decimal.Parse(Funcoes.parse(txt_margemLucroVista.Text).ToString()) * precoCusto) / 100;
                txt_precoVista.Text = Convert.ToDouble((precoCusto + precoVista)).ToString("C");
            }
            else
            {
                txt_margemLucroVista.Text = (0).ToString("P");
            }

        }

        private void txt_precoPrazo_Enter(object sender, EventArgs e)
        {
            txt_precoPrazo.Text = txt_precoPrazo.Text.Replace("$", "").Replace("R", "").Trim();
            txt_precoPrazo.SelectAll();
        }

        private void txt_precoPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_precoPrazo_Leave(object sender, EventArgs e)
        {

            txt_precoPrazo.Text = Convert.ToDouble(Funcoes.parse(txt_precoPrazo.Text).ToString()).ToString("C");

            if (Funcoes.parse(txt_precoCusto.Text) != 0)
            {
                txt_margemLucroPrazo.Text = ((Funcoes.parse(txt_precoPrazo.Text) / Funcoes.parse(txt_precoCusto.Text) - 1)).ToString("P");
            }
            else
            {
                txt_margemLucroPrazo.Text = (0).ToString("P");
            }

        }

        private void txt_margemLucroPrazo_Enter(object sender, EventArgs e)
        {
            txt_margemLucroPrazo.Text = Funcoes.parse(txt_margemLucroPrazo.Text).ToString();
        }

        private void txt_margemLucroVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_margemLucroPrazo_Leave(object sender, EventArgs e)
        {
            if (!produto.servico)
            {
                txt_margemLucroPrazo.Text = (Decimal.Parse(txt_margemLucroPrazo.Text) / 100).ToString("P");
                Decimal precoCusto = Decimal.Parse(Funcoes.parse(txt_precoCusto.Text).ToString());
                Decimal precoPrazo = (Decimal.Parse(Funcoes.parse(txt_margemLucroPrazo.Text).ToString()) * precoCusto) / 100;
                txt_precoPrazo.Text = Convert.ToDouble((precoCusto + precoPrazo)).ToString("C");
            }
            else
            {
                txt_margemLucroPrazo.Text = (0).ToString("P");
            }

        }

        private void txt_peso_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " kg";
        }

        private void txt_peso_Enter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = txt.Text.Replace('k', ' ').Replace('g', ' ').Trim();
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_largura_Enter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = txt.Text.Replace('c', ' ').Replace('m', ' ').Trim();
        }

        private void txt_largura_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }

        private void txt_largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_altura_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }

        private void txt_altura_Enter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = txt.Text.Replace('c', ' ').Replace('m', ' ').Trim();
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_comprimento_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }

        private void txt_comprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_comprimento_Enter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = txt.Text.Replace('c', ' ').Replace('m', ' ').Trim();
        }

        private void chbx_servico_CheckedChanged(object sender, EventArgs e)
        {
            if (produto.servico)
            {
                txt_deCompra.Enabled = false;
                txt_deCompraAcrescimo.Enabled = false;
                txt_frete.Enabled = false;
                txt_freteAcrescimo.Enabled = false;
            }
            else
            {
                txt_deCompra.Enabled = true;
                txt_deCompraAcrescimo.Enabled = true;
                txt_frete.Enabled = true;
                txt_freteAcrescimo.Enabled = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_deCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_margemLucroPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_precoCusto_TextChanged_1(object sender, EventArgs e)
        {
            if (!produto.servico)
            {
                txt_margemLucroPrazo.Text = (Decimal.Parse((Funcoes.parse(txt_margemLucroPrazo.Text) / 100).ToString())).ToString("P");
                Decimal precoCusto = Decimal.Parse(Funcoes.parse(txt_precoCusto.Text).ToString());
                Decimal precoPrazo = (Decimal.Parse(Funcoes.parse(txt_margemLucroPrazo.Text).ToString()) * precoCusto) / 100;
                txt_precoPrazo.Text = Convert.ToDouble((precoCusto + precoPrazo)).ToString("C");

                txt_margemLucroVista.Text = (Decimal.Parse((Funcoes.parse(txt_margemLucroVista.Text) / 100).ToString())).ToString("P");
                Decimal precoVista = (Decimal.Parse(Funcoes.parse(txt_margemLucroVista.Text).ToString()) * precoCusto) / 100;
                txt_precoVista.Text = Convert.ToDouble((precoCusto + precoVista)).ToString("C");

            }
            else
            {
                txt_margemLucroPrazo.Text = (0).ToString("P");
                txt_margemLucroVista.Text = (0).ToString("P");
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       


     
       

        
       
        

        

        

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files|*.JPG";
            openFileDialog1.Title = "Select a Cursor File";
            openFileDialog1.Multiselect = false;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ptb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb_Imagem.Image = Image.FromFile(openFileDialog1.FileName);
                
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ptb_Imagem.SizeMode = PictureBoxSizeMode.CenterImage;
            ptb_Imagem.Image = Resources.picture;
        }

        
    }
}

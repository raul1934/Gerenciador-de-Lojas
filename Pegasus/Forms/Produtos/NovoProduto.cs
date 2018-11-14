using Pegasus.Business.Implementation;

using Pegasus.Factory.Entities;
using Pegasus.Properties;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus.Controllers.Produtos
{
    public partial class NovoProduto : Form
    {
        private Produto produto;
        private IList<global::Pegasus.Factory.Entities.Fornecedor> fornecedores;
        private IList<global::Pegasus.Factory.Entities.Categoria> categorias;
        private IList<global::Pegasus.Factory.Entities.Marca> marcas;
        public IList<global::Pegasus.Factory.Entities.SubCategoria> subCategorias { get; set; }
        public NovoProduto()
        {
            InitializeComponent();
            produto = new Produto();

        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {
            FornecedorImplementation fornecedorImplementation = new FornecedorImplementation();
            fornecedores = fornecedorImplementation.Buscar();
            foreach (global::Pegasus.Factory.Entities.Fornecedor f in fornecedores)
            {
                if (f.nomeFantasia != null)
                {
                    cmb_fornecedor.Items.Add(f.nomeFantasia);
                }
            }
            CategoriaImplementation categoriaImplementation = new CategoriaImplementation();
            categorias = categoriaImplementation.Buscar();

            foreach (global::Pegasus.Factory.Entities.Categoria c in categorias)
            {
                if (!String.IsNullOrWhiteSpace(c.categoria))
                {
                    cmb_Categoria.Items.Add(c.categoria);
                }
            }

            MarcaImplementation marcaImplementation = new MarcaImplementation();
            marcas = marcaImplementation.BuscarbyMarca();

            foreach (global::Pegasus.Factory.Entities.Marca m in marcas)
            {
                if (!String.IsNullOrWhiteSpace(m.nome))
                {
                    cmb_marca.Items.Add(m.nome);
                }
            }

            SubCategoriaImplementation subCategoriaImplementation = new SubCategoriaImplementation();
            subCategorias = subCategoriaImplementation.BuscarbySubCategoria();
            foreach (global::Pegasus.Factory.Entities.SubCategoria c in subCategorias)
            {
                cmb_subCategoria.Items.Add(c.categoria);
            }

            

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
                                    if (parse(txt_deCompra.Text) > 0m)
                                    {
                                    if (parse(txt_precoCusto.Text) > 0m)
                                    {

                                        //DESCRICAO CATEGORIA SUBCATEGORIA MARCA ESPECIFICACAO
                                        produto.descricao = txt_descricao.Text;
                                        produto.categoria.categoria = cmb_Categoria.Text.ToString();
                                        produto.subcategoria.categoria = cmb_subCategoria.Text.ToString();
                                        produto.marca.nome = cmb_marca.Text.ToString();
                                        produto.especificacao = txt_especificacao.Text;

                                        //COMPRA CUSTO FRETE ACRESCIMOCOMPRA ACRESCIMOFRETE
                                        produto.ativo = true;


                                        //PESO COMPRIMENTO ALTURA LARGURA
                                        produto.peso = parse(txt_peso.Text);
                                        produto.comprimento = parse(txt_comprimento.Text);
                                        produto.altura = parse(txt_altura.Text);
                                        produto.largura = parse(txt_largura.Text);

                                        //CORREDOR PRATELEIRA CODBARRAS CODINTERNO
                                        produto.corredor = mtb_corredor.Text;
                                        produto.prateleira = mtb_prateleira.Text;
                                        produto.codigoBarras = txt_CodBarras.Text;
                                        produto.codInterno = txt_CodInterno.Text;

                                        //ESTOQUE ESTOQUE MIN UNMEDIDA


                                        produto.unidadeMedida = cmb_UnidadeMedida.Text;

                                        //MAGENLUCROVISTA MARGEM


                                        produto.naoControlarEstoque = chbx_nControlarEstoque.Checked;


                                        produto.dataInicio = DateTime.Now;
                                        produto.dataFim = DateTime.Now;
                                        // ALTERARPRECOVISTA ALTERARPRECOPRAZO



                                        // IMAGEM
                                        if (ptb_Imagem.Image != null)
                                        {
                                            ImageConverter converter = new ImageConverter();
                                            produto.imagem = (byte[])converter.ConvertTo(ptb_Imagem.Image, typeof(byte[]));
                                        }
                                        // TODO FIX FORNECEDOR SELECT
                                        if (cmb_fornecedor.SelectedItem != null)
                                        {

                                            produto.fornecedor = fornecedores.ElementAt(cmb_fornecedor.SelectedIndex);
                                        }
                                        else
                                        {
                                            produto.fornecedor = null;
                                        }

                                        try
                                        {
                                            ProdutoPreco pp = new ProdutoPreco();
                                            pp.acrescimoDeCompra = Funcoes.parse(txt_deCompraAcrescimo.Text);
                                            pp.acrescimoFrete = Funcoes.parse(txt_freteAcrescimo.Text);
                                            pp.ativo = true;
                                            pp.dataInicio = Funcoes.HoraZero(new DateTime());
                                            pp.margemLucroPrazo = Funcoes.parse(txt_margemLucroPrazo.Text);
                                            pp.margemLucroVista = Funcoes.parse(txt_margemLucroVista.Text);
                                            pp.precodeCompra = Funcoes.parse(txt_deCompra.Text);
                                            pp.precoDeCusto = Funcoes.parse(txt_precoCusto.Text);
                                            pp.precoFrete = Funcoes.parse(txt_frete.Text);
                                            pp.precoVendaPrazo = Funcoes.parse(txt_precoPrazo.Text);
                                            pp.precoVendaVista = Funcoes.parse(txt_precoVista.Text);

                                            produto.preco.Add(pp);

                                            ProdutoEstoque pe = new ProdutoEstoque();

                                            pe.ativo = true;
                                            pe.atual = Funcoes.parse(mtb_EstoqueAtual.Text);
                                            pe.dataInicio = Funcoes.HoraZero(new DateTime());
                                            pe.dataFim = Funcoes.HoraZero(new DateTime());

                                            

                                            produto.estoque.Add(pe);
                                            

                                            ProdutoImplementation pi = new ProdutoImplementation();
                                            pi.Inserir(produto);

                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                        catch(Exception ex)
                                        {
                                            MessageBox.Show(this,ex.ToString(), "Erro ao Inserir");
                                        }
                                    }
                                    //Situacao tributaria

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
       


        private void txt_deCompra_Leave(object sender, EventArgs e)
        {
            txt_deCompra.Text = Funcoes.formatarParaMoeda(txt_deCompra.Text);
            PrecoCusto();
        }





        private void textBox1_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Convert.ToDouble(txt.Text).ToString("C");
            PrecoCusto();
        }



       

        private void txt_deCompraAcrescimo_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            string result = (Decimal.Parse(txt.Text) / 100).ToString("P");
            txt.Text = result;
            PrecoCusto();

        }

        private void mtb_freteAcrescimo_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            string result = (Decimal.Parse(txt.Text) / 100).ToString("P");
            txt.Text = result;
            PrecoCusto();
        }

       
        private decimal parse(string text)
        {

            String x = "";
            for (int i = 0; i <= text.Length - 1; i++)
            {
                if ((text[i] >= '0' &&
                    text[i] <= '9') ||
                    text[i] == ',')
                {
                    x += text[i];
                }
            }
            return Decimal.Parse(x);
        }

        private void PrecoCusto()
        {
            decimal d = (parse(txt_deCompra.Text) + (parse(txt_deCompra.Text) * parse(txt_deCompraAcrescimo.Text) / 100)) +
                        (parse(txt_frete.Text) + (parse(txt_frete.Text) * parse(txt_freteAcrescimo.Text) / 100));

            txt_precoCusto.Text = Convert.ToDouble(d.ToString()).ToString("C");
        }


        private void txt_freteAcrescimo_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Convert.ToDouble(txt.Text).ToString("C");
            PrecoCusto();
        }

        private void txt_precoCusto_TextChanged(object sender, EventArgs e)
        {
            txt_precoVista.Text = Convert.ToDouble(parse(txt_precoCusto.Text).ToString()).ToString("C");
            txt_precoPrazo.Text = Convert.ToDouble(parse(txt_precoCusto.Text).ToString()).ToString("C");
        }

        private void txt_precoVista_Leave(object sender, EventArgs e)
        {
            txt_precoVista.Text = Convert.ToDouble(parse(txt_precoVista.Text).ToString()).ToString("C");
            if(parse(txt_precoCusto.Text)!=0)
            {
                txt_margemLucroVista.Text = ((parse(txt_precoVista.Text) / parse(txt_precoCusto.Text) - 1)).ToString("P");
            }
            else
            {
                txt_margemLucroVista.Text = (0).ToString("P");
            }

            


        }



        private void txt_margemLucroVista_Enter(object sender, EventArgs e)
        {
            txt_margemLucroVista.Text = parse(txt_margemLucroVista.Text).ToString();
        }

        private void txt_margemLucroVista_Leave(object sender, EventArgs e)
        {
           
                txt_margemLucroVista.Text = (Decimal.Parse(txt_margemLucroVista.Text) / 100).ToString("P");
                Decimal precoCusto = Decimal.Parse(parse(txt_precoCusto.Text).ToString());
                Decimal precoVista = (Decimal.Parse(parse(txt_margemLucroVista.Text).ToString()) * precoCusto) / 100;
                txt_precoVista.Text = Convert.ToDouble((precoCusto + precoVista)).ToString("C");
           
           
        }





        private void txt_precoPrazo_Leave(object sender, EventArgs e)
        {

            txt_precoPrazo.Text = Convert.ToDouble(parse(txt_precoPrazo.Text).ToString()).ToString("C");

            if (parse(txt_precoCusto.Text) != 0)
            {
                txt_margemLucroPrazo.Text = ((parse(txt_precoPrazo.Text) / parse(txt_precoCusto.Text) - 1)).ToString("P");
            }
            else
            {
                txt_margemLucroPrazo.Text = (0).ToString("P");
            }
           
        }





        private void txt_margemLucroPrazo_Leave(object sender, EventArgs e)
        {
            
                txt_margemLucroPrazo.Text = (Decimal.Parse(txt_margemLucroPrazo.Text) / 100).ToString("P");
                Decimal precoCusto = Decimal.Parse(parse(txt_precoCusto.Text).ToString());
                Decimal precoPrazo = (Decimal.Parse(parse(txt_margemLucroPrazo.Text).ToString()) * precoCusto) / 100;
                txt_precoPrazo.Text = Convert.ToDouble((precoCusto + precoPrazo)).ToString("C");
            
           
        }

        private void txt_peso_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " kg";
        }






        private void txt_largura_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }


        private void txt_altura_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }



        private void txt_comprimento_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Text = Double.Parse(txt.Text) + " cm";
        }



        private void toolStripButton3_Click(object sender, EventArgs e)
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
                // Assign the cursor in the Stream to the Form's Cursor property.

                ptb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb_Imagem.Image = Image.FromFile(openFileDialog1.FileName);
                // pictureBox1.Image.
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ptb_Imagem.SizeMode = PictureBoxSizeMode.CenterImage;
            ptb_Imagem.Image = Resources.picture;
        }

        private void ApenasNumeros_KeyPress(object sender, KeyEventArgs e)
        {
            
            Funcoes.ApenasNumeros_KeyPress(this, sender, e);
        }

        private void ApenasNumeros_Enter(object sender, EventArgs e)
        {
            Funcoes.ApenasNumeros_Enter(sender, e);
        }



    }
}


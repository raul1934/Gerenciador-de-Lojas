namespace Pegasus.Controllers.OrdemServico
{
    partial class NovaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Finalizar = new System.Windows.Forms.ToolStripButton();
            this.tsb_cliente = new System.Windows.Forms.ToolStripButton();
            this.tsb_produtos = new System.Windows.Forms.ToolStripButton();
            this.tsb_codBarras = new System.Windows.Forms.ToolStripButton();
            this.tsb_gerarNota = new System.Windows.Forms.ToolStripButton();
            this.tsb_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_menu = new System.Windows.Forms.ToolStrip();
            this.sptContainer = new System.Windows.Forms.SplitContainer();
            this.gpb_produto = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Vendedor = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.ptb_produto = new System.Windows.Forms.PictureBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_volumesValor = new System.Windows.Forms.Label();
            this.lbl_volumes = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).BeginInit();
            this.sptContainer.Panel1.SuspendLayout();
            this.sptContainer.Panel2.SuspendLayout();
            this.sptContainer.SuspendLayout();
            this.gpb_produto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_produto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // tsb_Finalizar
            // 
            this.tsb_Finalizar.AutoToolTip = false;
            this.tsb_Finalizar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Finalizar.Image")));
            this.tsb_Finalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsb_Finalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Finalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Finalizar.Name = "tsb_Finalizar";
            this.tsb_Finalizar.Size = new System.Drawing.Size(98, 52);
            this.tsb_Finalizar.Text = "Finalizar - F2";
            this.tsb_Finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            
            // 
            // tsb_cliente
            // 
            this.tsb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_cliente.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cliente.Image")));
            this.tsb_cliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cliente.Name = "tsb_cliente";
            this.tsb_cliente.Size = new System.Drawing.Size(78, 52);
            this.tsb_cliente.Text = "Cliente - F3";
            this.tsb_cliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsb_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
           
            // 
            // tsb_produtos
            // 
            this.tsb_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_produtos.Image = ((System.Drawing.Image)(resources.GetObject("tsb_produtos.Image")));
            this.tsb_produtos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_produtos.Name = "tsb_produtos";
            this.tsb_produtos.Size = new System.Drawing.Size(91, 52);
            this.tsb_produtos.Text = "Produtos - F4";
            this.tsb_produtos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsb_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          
            // 
            // tsb_codBarras
            // 
            this.tsb_codBarras.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_codBarras.Image = ((System.Drawing.Image)(resources.GetObject("tsb_codBarras.Image")));
            this.tsb_codBarras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_codBarras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_codBarras.Name = "tsb_codBarras";
            this.tsb_codBarras.Size = new System.Drawing.Size(121, 52);
            this.tsb_codBarras.Text = "Cod. Barras - F5";
            this.tsb_codBarras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            
            // 
            // tsb_gerarNota
            // 
            this.tsb_gerarNota.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_gerarNota.Image = ((System.Drawing.Image)(resources.GetObject("tsb_gerarNota.Image")));
            this.tsb_gerarNota.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_gerarNota.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_gerarNota.Name = "tsb_gerarNota";
            this.tsb_gerarNota.Size = new System.Drawing.Size(116, 52);
            this.tsb_gerarNota.Text = "Gerar Nota - F7";
            this.tsb_gerarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsb_sair
            // 
            this.tsb_sair.AutoToolTip = false;
            this.tsb_sair.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_sair.Image = ((System.Drawing.Image)(resources.GetObject("tsb_sair.Image")));
            this.tsb_sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_sair.Name = "tsb_sair";
            this.tsb_sair.Size = new System.Drawing.Size(110, 52);
            this.tsb_sair.Text = "Cancelar - F12";
            this.tsb_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // ts_menu
            // 
            this.ts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsb_Finalizar,
            this.tsb_cliente,
            this.tsb_produtos,
            this.tsb_codBarras,
            this.tsb_gerarNota,
            this.tsb_sair,
            this.toolStripSeparator2});
            this.ts_menu.Location = new System.Drawing.Point(0, 0);
            this.ts_menu.Name = "ts_menu";
            this.ts_menu.Size = new System.Drawing.Size(1284, 55);
            this.ts_menu.TabIndex = 23;
            this.ts_menu.Text = "toolStrip1";
            // 
            // sptContainer
            // 
            this.sptContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptContainer.Location = new System.Drawing.Point(0, 55);
            this.sptContainer.Name = "sptContainer";
            // 
            // sptContainer.Panel1
            // 
            this.sptContainer.Panel1.Controls.Add(this.gpb_produto);
            // 
            // sptContainer.Panel2
            // 
            this.sptContainer.Panel2.Controls.Add(this.dgv_produtos);
            this.sptContainer.Panel2.Controls.Add(this.panel2);
            this.sptContainer.Panel2.Controls.Add(this.panel1);
            this.sptContainer.Size = new System.Drawing.Size(1284, 675);
            this.sptContainer.SplitterDistance = 590;
            this.sptContainer.TabIndex = 7;
            // 
            // gpb_produto
            // 
            this.gpb_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpb_produto.Controls.Add(this.tableLayoutPanel1);
            this.gpb_produto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpb_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_produto.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_produto.Location = new System.Drawing.Point(0, 0);
            this.gpb_produto.Name = "gpb_produto";
            this.gpb_produto.Size = new System.Drawing.Size(587, 672);
            this.gpb_produto.TabIndex = 41;
            this.gpb_produto.TabStop = false;
            this.gpb_produto.Text = "Produto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.83334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.166666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_produto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptb_produto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_codigo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_quantidade, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_desconto, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_valor, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 10);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.txt_Vendedor);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 534);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendendor:";
            // 
            // txt_Vendedor
            // 
            this.txt_Vendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Vendedor.Location = new System.Drawing.Point(6, 28);
            this.txt_Vendedor.Name = "txt_Vendedor";
            this.txt_Vendedor.ReadOnly = true;
            this.txt_Vendedor.Size = new System.Drawing.Size(552, 35);
            this.txt_Vendedor.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 147);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 29);
            this.linkLabel2.TabIndex = 0;
            // 
            // txt_produto
            // 
            this.txt_produto.BackColor = System.Drawing.SystemColors.Control;
            this.txt_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_produto, 3);
            this.txt_produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_produto.Location = new System.Drawing.Point(3, 3);
            this.txt_produto.Multiline = true;
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.ReadOnly = true;
            this.txt_produto.Size = new System.Drawing.Size(572, 64);
            this.txt_produto.TabIndex = 0;
            // 
            // ptb_produto
            // 
            this.ptb_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_produto.Image = global::Pegasus.Properties.Resources.picture;
            this.ptb_produto.InitialImage = global::Pegasus.Properties.Resources.picture;
            this.ptb_produto.Location = new System.Drawing.Point(3, 93);
            this.ptb_produto.Name = "ptb_produto";
            this.tableLayoutPanel1.SetRowSpan(this.ptb_produto, 8);
            this.ptb_produto.Size = new System.Drawing.Size(232, 342);
            this.ptb_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_produto.TabIndex = 1;
            this.ptb_produto.TabStop = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(251, 122);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(324, 31);
            this.txt_codigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(251, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txt_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(251, 188);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.ReadOnly = true;
            this.txt_quantidade.Size = new System.Drawing.Size(324, 31);
            this.txt_quantidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desconto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_desconto
            // 
            this.txt_desconto.BackColor = System.Drawing.SystemColors.Control;
            this.txt_desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desconto.Location = new System.Drawing.Point(251, 254);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(308, 31);
            this.txt_desconto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.SystemColors.Control;
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(251, 320);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(308, 31);
            this.txt_valor.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.txt_Cliente);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cliente.Location = new System.Drawing.Point(11, 28);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(552, 35);
            this.txt_Cliente.TabIndex = 1;
            this.txt_Cliente.Text = "Consumidor";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 29);
            this.linkLabel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Location = new System.Drawing.Point(215, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 72);
            this.panel2.TabIndex = 41;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(61, 13);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(325, 55);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total: R$ 0,00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lbl_volumesValor);
            this.panel1.Controls.Add(this.lbl_volumes);
            this.panel1.Location = new System.Drawing.Point(3, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 72);
            this.panel1.TabIndex = 40;
            // 
            // lbl_volumesValor
            // 
            this.lbl_volumesValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volumesValor.Location = new System.Drawing.Point(6, 31);
            this.lbl_volumesValor.Name = "lbl_volumesValor";
            this.lbl_volumesValor.Size = new System.Drawing.Size(214, 30);
            this.lbl_volumesValor.TabIndex = 1;
            this.lbl_volumesValor.Text = "0";
            this.lbl_volumesValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_volumes
            // 
            this.lbl_volumes.AutoSize = true;
            this.lbl_volumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volumes.Location = new System.Drawing.Point(23, 0);
            this.lbl_volumes.Name = "lbl_volumes";
            this.lbl_volumes.Size = new System.Drawing.Size(194, 31);
            this.lbl_volumes.TabIndex = 0;
            this.lbl_volumes.Text = "Volumes/Items";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descrição,
            this.qtd,
            this.Preco});
            this.dgv_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_produtos.Location = new System.Drawing.Point(0, 0);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(690, 675);
            this.dgv_produtos.TabIndex = 42;
            
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Descrição
            // 
            this.Descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrição.FillWeight = 178.58F;
            this.Descrição.HeaderText = "Descricao";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descrição.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // qtd
            // 
            this.qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtd.FillWeight = 71.43161F;
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Preco
            // 
            this.Preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preco.FillWeight = 44.91226F;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Preco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 730);
            this.ControlBox = false;
            this.Controls.Add(this.sptContainer);
            this.Controls.Add(this.ts_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDV : ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.ts_menu.ResumeLayout(false);
            this.ts_menu.PerformLayout();
            this.sptContainer.Panel1.ResumeLayout(false);
            this.sptContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).EndInit();
            this.sptContainer.ResumeLayout(false);
            this.gpb_produto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_produto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_Finalizar;
        private System.Windows.Forms.ToolStripButton tsb_cliente;
        private System.Windows.Forms.ToolStripButton tsb_produtos;
        private System.Windows.Forms.ToolStripButton tsb_codBarras;
        private System.Windows.Forms.ToolStripButton tsb_gerarNota;
        private System.Windows.Forms.ToolStripButton tsb_sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip ts_menu;
        private System.Windows.Forms.SplitContainer sptContainer;
        private System.Windows.Forms.GroupBox gpb_produto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_volumesValor;
        private System.Windows.Forms.Label lbl_volumes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.PictureBox ptb_produto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.TextBox txt_Vendedor;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}
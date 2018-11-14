namespace Pegasus.Controllers.Produtos
{
    partial class SelecionarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreçoVendaVista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tsb_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_subcategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.dtp_ate = new System.Windows.Forms.DateTimePicker();
            this.chbx_todasDatas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.AllowUserToResizeColumns = false;
            this.dgv_produtos.AllowUserToResizeRows = false;
            this.dgv_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_produtos.CausesValidation = false;
            this.dgv_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descricao,
            this.Codigo,
            this.Estoque,
            this.PreçoVendaVista,
            this.PrecoPrazo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 216);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_produtos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.ShowCellErrors = false;
            this.dgv_produtos.ShowCellToolTips = false;
            this.dgv_produtos.ShowRowErrors = false;
            this.dgv_produtos.Size = new System.Drawing.Size(1326, 501);
            this.dgv_produtos.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.FillWeight = 449.2386F;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.FillWeight = 12.69035F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 100;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estoque.FillWeight = 12.69035F;
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.MinimumWidth = 100;
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 105;
            // 
            // PreçoVendaVista
            // 
            this.PreçoVendaVista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PreçoVendaVista.FillWeight = 12.69035F;
            this.PreçoVendaVista.HeaderText = "Preço à Vista";
            this.PreçoVendaVista.MinimumWidth = 155;
            this.PreçoVendaVista.Name = "PreçoVendaVista";
            this.PreçoVendaVista.ReadOnly = true;
            this.PreçoVendaVista.Width = 155;
            // 
            // PrecoPrazo
            // 
            this.PrecoPrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecoPrazo.FillWeight = 12.69035F;
            this.PrecoPrazo.HeaderText = "Preço à Prazo";
            this.PrecoPrazo.MinimumWidth = 155;
            this.PrecoPrazo.Name = "PrecoPrazo";
            this.PrecoPrazo.ReadOnly = true;
            this.PrecoPrazo.Width = 155;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsb_salvar,
            this.tsb_sair,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1350, 57);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // tsb_salvar
            // 
            this.tsb_salvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_salvar.Image = global::Pegasus.Properties.Resources.save;
            this.tsb_salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salvar.Name = "tsb_salvar";
            this.tsb_salvar.Size = new System.Drawing.Size(138, 54);
            this.tsb_salvar.Text = "Salvar - F2";
            this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click);
            // 
            // tsb_sair
            // 
            this.tsb_sair.AutoToolTip = false;
            this.tsb_sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_sair.Image = global::Pegasus.Properties.Resources.error;
            this.tsb_sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_sair.Name = "tsb_sair";
            this.tsb_sair.Size = new System.Drawing.Size(131, 54);
            this.tsb_sair.Text = "Sair - F12";
            this.tsb_sair.Click += new System.EventHandler(this.tsb_sair_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.74496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.42936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.88643F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.btn_pesquisar, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_descricao, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ean, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_marca, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmb_fornecedor, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_categoria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmb_subcategoria, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_de, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_ate, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.chbx_todasDatas, 7, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 150);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pesquisar.Image = global::Pegasus.Properties.Resources.search;
            this.btn_pesquisar.Location = new System.Drawing.Point(1191, 110);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(132, 37);
            this.btn_pesquisar.TabIndex = 17;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descricao:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_descricao
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_descricao, 7);
            this.txt_descricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_descricao.Location = new System.Drawing.Point(122, 3);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(1063, 29);
            this.txt_descricao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "EAN:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ean
            // 
            this.txt_ean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ean.Location = new System.Drawing.Point(122, 38);
            this.txt_ean.MaxLength = 13;
            this.txt_ean.Name = "txt_ean";
            this.txt_ean.Size = new System.Drawing.Size(221, 29);
            this.txt_ean.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_marca
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmb_marca, 2);
            this.cmb_marca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(122, 73);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(375, 32);
            this.cmb_marca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_fornecedor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmb_fornecedor, 4);
            this.cmb_fornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fornecedor.FormattingEnabled = true;
            this.cmb_fornecedor.Location = new System.Drawing.Point(663, 38);
            this.cmb_fornecedor.Name = "cmb_fornecedor";
            this.cmb_fornecedor.Size = new System.Drawing.Size(522, 32);
            this.cmb_fornecedor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(503, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 35);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fornecedor:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_categoria
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmb_categoria, 2);
            this.cmb_categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(122, 110);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(375, 32);
            this.cmb_categoria.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(503, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 43);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subcategoria:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_subcategoria
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmb_subcategoria, 4);
            this.cmb_subcategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subcategoria.FormattingEnabled = true;
            this.cmb_subcategoria.Location = new System.Drawing.Point(663, 110);
            this.cmb_subcategoria.Name = "cmb_subcategoria";
            this.cmb_subcategoria.Size = new System.Drawing.Size(522, 32);
            this.cmb_subcategoria.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(503, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(779, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 37);
            this.label9.TabIndex = 13;
            this.label9.Text = "ate";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_de
            // 
            this.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_de.Location = new System.Drawing.Point(663, 73);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(110, 29);
            this.dtp_de.TabIndex = 14;
            // 
            // dtp_ate
            // 
            this.dtp_ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ate.Location = new System.Drawing.Point(839, 73);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(132, 29);
            this.dtp_ate.TabIndex = 15;
            // 
            // chbx_todasDatas
            // 
            this.chbx_todasDatas.AutoSize = true;
            this.chbx_todasDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbx_todasDatas.Location = new System.Drawing.Point(998, 73);
            this.chbx_todasDatas.Name = "chbx_todasDatas";
            this.chbx_todasDatas.Size = new System.Drawing.Size(187, 31);
            this.chbx_todasDatas.TabIndex = 16;
            this.chbx_todasDatas.Text = "Todas as Datas";
            this.chbx_todasDatas.UseVisualStyleBackColor = true;
            this.chbx_todasDatas.CheckedChanged += new System.EventHandler(this.chbx_todasDatas_CheckedChanged);
            // 
            // SelecionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_produtos);
            this.KeyPreview = true;
            this.Name = "SelecionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionarProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelecionarProduto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelecionarProduto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreçoVendaVista;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoPrazo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.ToolStripButton tsb_sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_subcategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.DateTimePicker dtp_ate;
        private System.Windows.Forms.CheckBox chbx_todasDatas;
    }
}
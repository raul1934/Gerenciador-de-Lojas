namespace Pegasus.Controllers.Cliente
{
    partial class NovoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_novoTelefone = new System.Windows.Forms.Button();
            this.btn_alterarTelefone = new System.Windows.Forms.Button();
            this.btn_excluirTelefone = new System.Windows.Forms.Button();
            this.dgv_telefone = new System.Windows.Forms.DataGridView();
            this.numero_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_novoVeiculo = new System.Windows.Forms.Button();
            this.btn_alterarVeiculo = new System.Windows.Forms.Button();
            this.btn_excluirVeiculo = new System.Windows.Forms.Button();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quilometragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_UF = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtb_Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mtb_rgie = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rgie = new System.Windows.Forms.Label();
            this.mtb_cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpfcnpj = new System.Windows.Forms.Label();
            this.txt_razao = new System.Windows.Forms.TextBox();
            this.lbl_razaoSocial = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_nomeFantasia = new System.Windows.Forms.Label();
            this.chx_Ativo = new System.Windows.Forms.CheckBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_Cep = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefone)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::Pegasus.Properties.Resources.save;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(138, 54);
            this.toolStripButton2.Text = "Salvar - F2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = global::Pegasus.Properties.Resources.error;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(164, 54);
            this.toolStripButton3.Text = "Cancelar - F12";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 322);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1314, 327);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_novoTelefone);
            this.tabPage2.Controls.Add(this.btn_alterarTelefone);
            this.tabPage2.Controls.Add(this.btn_excluirTelefone);
            this.tabPage2.Controls.Add(this.dgv_telefone);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1306, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_novoTelefone
            // 
            this.btn_novoTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novoTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoTelefone.Image = global::Pegasus.Properties.Resources.plus;
            this.btn_novoTelefone.Location = new System.Drawing.Point(976, 240);
            this.btn_novoTelefone.Name = "btn_novoTelefone";
            this.btn_novoTelefone.Size = new System.Drawing.Size(100, 40);
            this.btn_novoTelefone.TabIndex = 19;
            this.btn_novoTelefone.Text = "Novo";
            this.btn_novoTelefone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novoTelefone.UseVisualStyleBackColor = true;
            this.btn_novoTelefone.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_alterarTelefone
            // 
            this.btn_alterarTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alterarTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarTelefone.Image = global::Pegasus.Properties.Resources.file;
            this.btn_alterarTelefone.Location = new System.Drawing.Point(1082, 240);
            this.btn_alterarTelefone.Name = "btn_alterarTelefone";
            this.btn_alterarTelefone.Size = new System.Drawing.Size(100, 40);
            this.btn_alterarTelefone.TabIndex = 18;
            this.btn_alterarTelefone.Text = "Alterar";
            this.btn_alterarTelefone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarTelefone.UseVisualStyleBackColor = true;
            this.btn_alterarTelefone.Click += new System.EventHandler(this.btn_alterarTelefone_Click);
            // 
            // btn_excluirTelefone
            // 
            this.btn_excluirTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluirTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirTelefone.Image = global::Pegasus.Properties.Resources.error;
            this.btn_excluirTelefone.Location = new System.Drawing.Point(1188, 240);
            this.btn_excluirTelefone.Name = "btn_excluirTelefone";
            this.btn_excluirTelefone.Size = new System.Drawing.Size(100, 40);
            this.btn_excluirTelefone.TabIndex = 17;
            this.btn_excluirTelefone.Text = "Excluir";
            this.btn_excluirTelefone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_excluirTelefone.UseVisualStyleBackColor = true;
            this.btn_excluirTelefone.Click += new System.EventHandler(this.btn_excluirTelefone_Click);
            // 
            // dgv_telefone
            // 
            this.dgv_telefone.AllowUserToAddRows = false;
            this.dgv_telefone.AllowUserToDeleteRows = false;
            this.dgv_telefone.AllowUserToResizeColumns = false;
            this.dgv_telefone.AllowUserToResizeRows = false;
            this.dgv_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_telefone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_telefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_id,
            this.Numero,
            this.Tipo,
            this.Observação});
            this.dgv_telefone.Location = new System.Drawing.Point(22, 10);
            this.dgv_telefone.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.dgv_telefone.MultiSelect = false;
            this.dgv_telefone.Name = "dgv_telefone";
            this.dgv_telefone.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_telefone.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_telefone.RowHeadersVisible = false;
            this.dgv_telefone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_telefone.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_telefone.RowTemplate.Height = 50;
            this.dgv_telefone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_telefone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_telefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_telefone.Size = new System.Drawing.Size(1266, 221);
            this.dgv_telefone.TabIndex = 0;
            this.dgv_telefone.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_telefone_CellContentDoubleClick);
            // 
            // numero_id
            // 
            this.numero_id.HeaderText = "id";
            this.numero_id.Name = "numero_id";
            this.numero_id.ReadOnly = true;
            this.numero_id.Visible = false;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.NullValue = null;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle13;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle14;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Observação
            // 
            this.Observação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            this.Observação.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_novoVeiculo);
            this.tabPage1.Controls.Add(this.btn_alterarVeiculo);
            this.tabPage1.Controls.Add(this.btn_excluirVeiculo);
            this.tabPage1.Controls.Add(this.dgvCarros);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1306, 290);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Veiculos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_novoVeiculo
            // 
            this.btn_novoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novoVeiculo.Image = global::Pegasus.Properties.Resources.plus;
            this.btn_novoVeiculo.Location = new System.Drawing.Point(976, 240);
            this.btn_novoVeiculo.Name = "btn_novoVeiculo";
            this.btn_novoVeiculo.Size = new System.Drawing.Size(100, 40);
            this.btn_novoVeiculo.TabIndex = 16;
            this.btn_novoVeiculo.Text = "Novo";
            this.btn_novoVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novoVeiculo.UseVisualStyleBackColor = true;
            
            // 
            // btn_alterarVeiculo
            // 
            this.btn_alterarVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alterarVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarVeiculo.Image = global::Pegasus.Properties.Resources.file;
            this.btn_alterarVeiculo.Location = new System.Drawing.Point(1082, 240);
            this.btn_alterarVeiculo.Name = "btn_alterarVeiculo";
            this.btn_alterarVeiculo.Size = new System.Drawing.Size(100, 40);
            this.btn_alterarVeiculo.TabIndex = 15;
            this.btn_alterarVeiculo.Text = "Alterar";
            this.btn_alterarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarVeiculo.UseVisualStyleBackColor = true;
           
            // 
            // btn_excluirVeiculo
            // 
            this.btn_excluirVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluirVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirVeiculo.Image = global::Pegasus.Properties.Resources.error;
            this.btn_excluirVeiculo.Location = new System.Drawing.Point(1188, 240);
            this.btn_excluirVeiculo.Name = "btn_excluirVeiculo";
            this.btn_excluirVeiculo.Size = new System.Drawing.Size(100, 40);
            this.btn_excluirVeiculo.TabIndex = 14;
            this.btn_excluirVeiculo.Text = "Excluir";
            this.btn_excluirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_excluirVeiculo.UseVisualStyleBackColor = true;
            
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.AllowUserToResizeColumns = false;
            this.dgvCarros.AllowUserToResizeRows = false;
            this.dgvCarros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Modelo,
            this.marca,
            this.Placa,
            this.Quilometragem,
            this.AnoFabricacao,
            this.Cor,
            this.NumeroChassi});
            this.dgvCarros.Location = new System.Drawing.Point(22, 10);
            this.dgvCarros.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.RowHeadersVisible = false;
            this.dgvCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarros.ShowCellErrors = false;
            this.dgvCarros.ShowCellToolTips = false;
            this.dgvCarros.ShowEditingIcon = false;
            this.dgvCarros.ShowRowErrors = false;
            this.dgvCarros.Size = new System.Drawing.Size(1266, 221);
            this.dgvCarros.TabIndex = 0;
           
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Quilometragem
            // 
            this.Quilometragem.HeaderText = "Quilometragem";
            this.Quilometragem.Name = "Quilometragem";
            this.Quilometragem.ReadOnly = true;
            // 
            // AnoFabricacao
            // 
            this.AnoFabricacao.HeaderText = "Ano Fab";
            this.AnoFabricacao.Name = "AnoFabricacao";
            this.AnoFabricacao.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // NumeroChassi
            // 
            this.NumeroChassi.HeaderText = "Num Chassi";
            this.NumeroChassi.Name = "NumeroChassi";
            this.NumeroChassi.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 38);
            this.label4.TabIndex = 24;
            this.label4.Text = "UF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_UF
            // 
            this.cmb_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UF.FormattingEnabled = true;
            this.cmb_UF.Location = new System.Drawing.Point(984, 213);
            this.cmb_UF.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_UF.Name = "cmb_UF";
            this.cmb_UF.Size = new System.Drawing.Size(219, 32);
            this.cmb_UF.TabIndex = 13;
            this.cmb_UF.SelectedIndexChanged += new System.EventHandler(this.cmb_UF_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.83627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.16373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Email, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Numero, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtb_Nascimento, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Nascimento, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Bairro, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Endereco, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtb_rgie, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_rgie, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtb_cpfcnpj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cpfcnpj, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_razao, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_razaoSocial, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nomeFantasia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chx_Ativo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_tipo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.mtb_Cep, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmb_UF, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmb_cidade, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 286);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // txt_Email
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Email, 3);
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(151, 254);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(709, 29);
            this.txt_Email.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(866, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 35);
            this.label8.TabIndex = 56;
            this.label8.Text = "CEP:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(984, 146);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(101, 29);
            this.txt_Numero.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 35);
            this.label10.TabIndex = 54;
            this.label10.Text = "Numero:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_Nascimento
            // 
            this.mtb_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Nascimento.Location = new System.Drawing.Point(987, 41);
            this.mtb_Nascimento.Mask = "99/99/9999";
            this.mtb_Nascimento.Name = "mtb_Nascimento";
            this.mtb_Nascimento.Size = new System.Drawing.Size(98, 29);
            this.mtb_Nascimento.TabIndex = 4;
            // 
            // lbl_Nascimento
            // 
            this.lbl_Nascimento.AutoSize = true;
            this.lbl_Nascimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nascimento.Location = new System.Drawing.Point(866, 38);
            this.lbl_Nascimento.Name = "lbl_Nascimento";
            this.lbl_Nascimento.Size = new System.Drawing.Size(115, 35);
            this.lbl_Nascimento.TabIndex = 52;
            this.lbl_Nascimento.Text = "Nascimento:";
            this.lbl_Nascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Bairro
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Bairro, 3);
            this.txt_Bairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(151, 181);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(709, 29);
            this.txt_Bairro.TabIndex = 10;
            // 
            // txt_Endereco
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Endereco, 3);
            this.txt_Endereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(151, 146);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(709, 29);
            this.txt_Endereco.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 35);
            this.label14.TabIndex = 45;
            this.label14.Text = "Endereço:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_rgie
            // 
            this.mtb_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_rgie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_rgie.Location = new System.Drawing.Point(715, 111);
            this.mtb_rgie.Mask = "999,999,999,999";
            this.mtb_rgie.Name = "mtb_rgie";
            this.mtb_rgie.Size = new System.Drawing.Size(145, 29);
            this.mtb_rgie.TabIndex = 7;
            // 
            // lbl_rgie
            // 
            this.lbl_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rgie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rgie.Location = new System.Drawing.Point(415, 108);
            this.lbl_rgie.Name = "lbl_rgie";
            this.lbl_rgie.Size = new System.Drawing.Size(294, 35);
            this.lbl_rgie.TabIndex = 43;
            this.lbl_rgie.Text = "IE:";
            this.lbl_rgie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_cpfcnpj
            // 
            this.mtb_cpfcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpfcnpj.Location = new System.Drawing.Point(151, 111);
            this.mtb_cpfcnpj.Mask = "99,999,999/9999-99";
            this.mtb_cpfcnpj.Name = "mtb_cpfcnpj";
            this.mtb_cpfcnpj.Size = new System.Drawing.Size(258, 29);
            this.mtb_cpfcnpj.TabIndex = 6;
            // 
            // lbl_cpfcnpj
            // 
            this.lbl_cpfcnpj.AutoSize = true;
            this.lbl_cpfcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpfcnpj.Location = new System.Drawing.Point(3, 108);
            this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
            this.lbl_cpfcnpj.Size = new System.Drawing.Size(142, 35);
            this.lbl_cpfcnpj.TabIndex = 41;
            this.lbl_cpfcnpj.Text = "CNPJ:";
            this.lbl_cpfcnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_razao
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_razao, 3);
            this.txt_razao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razao.Location = new System.Drawing.Point(151, 76);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(709, 29);
            this.txt_razao.TabIndex = 5;
            // 
            // lbl_razaoSocial
            // 
            this.lbl_razaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_razaoSocial.AutoSize = true;
            this.lbl_razaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razaoSocial.Location = new System.Drawing.Point(3, 73);
            this.lbl_razaoSocial.Name = "lbl_razaoSocial";
            this.lbl_razaoSocial.Size = new System.Drawing.Size(142, 35);
            this.lbl_razaoSocial.TabIndex = 39;
            this.lbl_razaoSocial.Text = "Razão Social:";
            this.lbl_razaoSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Nome
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Nome, 3);
            this.txt_Nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(151, 41);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(709, 29);
            this.txt_Nome.TabIndex = 3;
            // 
            // lbl_nomeFantasia
            // 
            this.lbl_nomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nomeFantasia.AutoSize = true;
            this.lbl_nomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeFantasia.Location = new System.Drawing.Point(3, 38);
            this.lbl_nomeFantasia.Name = "lbl_nomeFantasia";
            this.lbl_nomeFantasia.Size = new System.Drawing.Size(142, 35);
            this.lbl_nomeFantasia.TabIndex = 37;
            this.lbl_nomeFantasia.Text = "Nome Fantasia:";
            this.lbl_nomeFantasia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chx_Ativo
            // 
            this.chx_Ativo.AutoSize = true;
            this.chx_Ativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chx_Ativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Ativo.Location = new System.Drawing.Point(715, 3);
            this.chx_Ativo.Name = "chx_Ativo";
            this.chx_Ativo.Size = new System.Drawing.Size(145, 32);
            this.chx_Ativo.TabIndex = 2;
            this.chx_Ativo.Text = "Ativo";
            this.chx_Ativo.UseVisualStyleBackColor = true;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Pessoa Juridica",
            "Pessoa Fisica"});
            this.cbx_tipo.Location = new System.Drawing.Point(151, 3);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(258, 32);
            this.cbx_tipo.TabIndex = 1;
            this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 38);
            this.label9.TabIndex = 49;
            this.label9.Text = "Cidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 35);
            this.label7.TabIndex = 47;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_Cep
            // 
            this.mtb_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Cep.Location = new System.Drawing.Point(984, 181);
            this.mtb_Cep.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mtb_Cep.Mask = "00,000-000";
            this.mtb_Cep.Name = "mtb_Cep";
            this.mtb_Cep.Size = new System.Drawing.Size(101, 29);
            this.mtb_Cep.TabIndex = 11;
            // 
            // cmb_cidade
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmb_cidade, 3);
            this.cmb_cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.ItemHeight = 24;
            this.cmb_cidade.Location = new System.Drawing.Point(151, 216);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(709, 32);
            this.cmb_cidade.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 655);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Cliente:";
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NovoCliente";
            this.Text = "Novo Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefone)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_novoTelefone;
        private System.Windows.Forms.Button btn_alterarTelefone;
        private System.Windows.Forms.Button btn_excluirTelefone;
        private System.Windows.Forms.DataGridView dgv_telefone;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_novoVeiculo;
        private System.Windows.Forms.Button btn_alterarVeiculo;
        private System.Windows.Forms.Button btn_excluirVeiculo;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quilometragem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoFabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChassi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_UF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chx_Ativo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_nomeFantasia;
        private System.Windows.Forms.TextBox txt_razao;
        private System.Windows.Forms.Label lbl_razaoSocial;
        private System.Windows.Forms.Label lbl_cpfcnpj;
        private System.Windows.Forms.MaskedTextBox mtb_cpfcnpj;
        private System.Windows.Forms.Label lbl_rgie;
        private System.Windows.Forms.MaskedTextBox mtb_rgie;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtb_Nascimento;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.MaskedTextBox mtb_Cep;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
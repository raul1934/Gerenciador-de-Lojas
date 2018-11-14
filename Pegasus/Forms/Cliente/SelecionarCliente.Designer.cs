namespace Pegasus.Controllers.Cliente
{
    partial class SelecionarCliente
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
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tsb_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.mtb_cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cpfcnpj = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.lbl_rgie = new System.Windows.Forms.Label();
            this.mtb_rgie = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ate = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbx_todasDatas = new System.Windows.Forms.CheckBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.AllowUserToResizeColumns = false;
            this.dgv_cliente.AllowUserToResizeRows = false;
            this.dgv_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.cpfcnpj,
            this.rgie,
            this.Cidade});
            this.dgv_cliente.Location = new System.Drawing.Point(12, 205);
            this.dgv_cliente.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_cliente.MultiSelect = false;
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_cliente.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.ShowCellErrors = false;
            this.dgv_cliente.ShowCellToolTips = false;
            this.dgv_cliente.ShowEditingIcon = false;
            this.dgv_cliente.ShowRowErrors = false;
            this.dgv_cliente.Size = new System.Drawing.Size(1323, 527);
            this.dgv_cliente.TabIndex = 1;
            this.dgv_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellDoubleClick);
            this.dgv_cliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_cliente_KeyUp);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.HeaderText = "CPF/CNPJ";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.ReadOnly = true;
            // 
            // rgie
            // 
            this.rgie.HeaderText = "RG/IE";
            this.rgie.Name = "rgie";
            this.rgie.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
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
            this.toolStrip1.TabIndex = 25;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txt_nome, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_nome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtb_cpfcnpj, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_cpfcnpj, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_cidade, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmb_cidade, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmb_estado, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_rgie, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.mtb_rgie, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_de, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_ate, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_tipo, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.chbx_todasDatas, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_pesquisar, 7, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1320, 111);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // txt_nome
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_nome, 3);
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nome.Location = new System.Drawing.Point(84, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(799, 29);
            this.txt_nome.TabIndex = 7;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(3, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 35);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_cpfcnpj
            // 
            this.mtb_cpfcnpj.Location = new System.Drawing.Point(84, 38);
            this.mtb_cpfcnpj.Mask = "999,999,999-99";
            this.mtb_cpfcnpj.Name = "mtb_cpfcnpj";
            this.mtb_cpfcnpj.Size = new System.Drawing.Size(187, 29);
            this.mtb_cpfcnpj.TabIndex = 9;
            // 
            // lbl_cpfcnpj
            // 
            this.lbl_cpfcnpj.AutoSize = true;
            this.lbl_cpfcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cpfcnpj.Location = new System.Drawing.Point(3, 35);
            this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
            this.lbl_cpfcnpj.Size = new System.Drawing.Size(75, 35);
            this.lbl_cpfcnpj.TabIndex = 2;
            this.lbl_cpfcnpj.Text = "CPF:";
            this.lbl_cpfcnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cidade.Location = new System.Drawing.Point(3, 70);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(75, 41);
            this.lbl_cidade.TabIndex = 12;
            this.lbl_cidade.Text = "Cidade:";
            this.lbl_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(84, 73);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(357, 32);
            this.cmb_cidade.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(447, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_estado
            // 
            this.cmb_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(526, 73);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(357, 32);
            this.cmb_estado.TabIndex = 15;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // lbl_rgie
            // 
            this.lbl_rgie.AutoSize = true;
            this.lbl_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rgie.Location = new System.Drawing.Point(447, 35);
            this.lbl_rgie.Name = "lbl_rgie";
            this.lbl_rgie.Size = new System.Drawing.Size(73, 35);
            this.lbl_rgie.TabIndex = 10;
            this.lbl_rgie.Text = "RG:";
            this.lbl_rgie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_rgie
            // 
            this.mtb_rgie.Location = new System.Drawing.Point(526, 38);
            this.mtb_rgie.Mask = "99,999,999-99";
            this.mtb_rgie.Name = "mtb_rgie";
            this.mtb_rgie.Size = new System.Drawing.Size(187, 29);
            this.mtb_rgie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(889, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_de
            // 
            this.dtp_de.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_de.Location = new System.Drawing.Point(947, 38);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(149, 29);
            this.dtp_de.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1102, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "  Ate  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_ate
            // 
            this.dtp_ate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ate.Location = new System.Drawing.Point(1166, 38);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(151, 29);
            this.dtp_ate.TabIndex = 19;
            // 
            // cmb_tipo
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmb_tipo, 2);
            this.cmb_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Todas",
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.cmb_tipo.Location = new System.Drawing.Point(1102, 3);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(215, 32);
            this.cmb_tipo.TabIndex = 23;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(947, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo Pessoa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbx_todasDatas
            // 
            this.chbx_todasDatas.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbx_todasDatas, 2);
            this.chbx_todasDatas.Location = new System.Drawing.Point(947, 73);
            this.chbx_todasDatas.Name = "chbx_todasDatas";
            this.chbx_todasDatas.Size = new System.Drawing.Size(162, 28);
            this.chbx_todasDatas.TabIndex = 22;
            this.chbx_todasDatas.Text = "Todas as Datas:";
            this.chbx_todasDatas.UseVisualStyleBackColor = true;
            this.chbx_todasDatas.CheckedChanged += new System.EventHandler(this.chbx_todasDatas_CheckedChanged);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pesquisar.Image = global::Pegasus.Properties.Resources.search;
            this.btn_pesquisar.Location = new System.Drawing.Point(1166, 73);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(151, 35);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // SelecionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_cliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SelecionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SelecionarCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelecionarCliente_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.MaskedTextBox mtb_cpfcnpj;
        private System.Windows.Forms.Label lbl_cpfcnpj;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label lbl_rgie;
        private System.Windows.Forms.MaskedTextBox mtb_rgie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ate;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbx_todasDatas;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}
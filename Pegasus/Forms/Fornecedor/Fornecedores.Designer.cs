namespace Pegasus.Controllers.Fornecedor
{
    partial class Fornecedores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.dgv_fornecedores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.chbx_todasDatas = new System.Windows.Forms.CheckBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedores)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Pegasus.Properties.Resources.error;
            this.button3.Location = new System.Drawing.Point(1232, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Excluir";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Pegasus.Properties.Resources.file;
            this.button2.Location = new System.Drawing.Point(1102, 707);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Alterar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.Image = global::Pegasus.Properties.Resources.plus;
            this.btn_Cliente.Location = new System.Drawing.Point(972, 707);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(124, 44);
            this.btn_Cliente.TabIndex = 15;
            this.btn_Cliente.Text = "Novo";
            this.btn_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // dgv_fornecedores
            // 
            this.dgv_fornecedores.AllowUserToAddRows = false;
            this.dgv_fornecedores.AllowUserToDeleteRows = false;
            this.dgv_fornecedores.AllowUserToResizeColumns = false;
            this.dgv_fornecedores.AllowUserToResizeRows = false;
            this.dgv_fornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_fornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.RazaoSocial,
            this.NomeFantasia,
            this.CNPJ,
            this.Endereco,
            this.Cidade});
            this.dgv_fornecedores.Location = new System.Drawing.Point(11, 156);
            this.dgv_fornecedores.MultiSelect = false;
            this.dgv_fornecedores.Name = "dgv_fornecedores";
            this.dgv_fornecedores.ReadOnly = true;
            this.dgv_fornecedores.RowHeadersVisible = false;
            this.dgv_fornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fornecedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fornecedores.ShowCellErrors = false;
            this.dgv_fornecedores.ShowCellToolTips = false;
            this.dgv_fornecedores.ShowRowErrors = false;
            this.dgv_fornecedores.Size = new System.Drawing.Size(1345, 545);
            this.dgv_fornecedores.TabIndex = 14;
            this.dgv_fornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazaoSocial.HeaderText = "RazaoSocial";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.HeaderText = "Nome Fantasia";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 83;
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Endereco.HeaderText = "IE";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 52;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
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
            this.tableLayoutPanel2.Controls.Add(this.chbx_todasDatas, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_pesquisar, 7, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1345, 109);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // txt_nome
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_nome, 3);
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nome.Location = new System.Drawing.Point(84, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(817, 29);
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
            this.mtb_cpfcnpj.Mask = "99,999,999/9999-99";
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
            this.lbl_cpfcnpj.Text = "CNPJ:";
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
            this.cmb_cidade.Size = new System.Drawing.Size(366, 32);
            this.cmb_cidade.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_estado
            // 
            this.cmb_estado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(535, 73);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(366, 32);
            this.cmb_estado.TabIndex = 15;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // lbl_rgie
            // 
            this.lbl_rgie.AutoSize = true;
            this.lbl_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rgie.Location = new System.Drawing.Point(456, 35);
            this.lbl_rgie.Name = "lbl_rgie";
            this.lbl_rgie.Size = new System.Drawing.Size(73, 35);
            this.lbl_rgie.TabIndex = 10;
            this.lbl_rgie.Text = "IE:";
            this.lbl_rgie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_rgie
            // 
            this.mtb_rgie.Location = new System.Drawing.Point(535, 38);
            this.mtb_rgie.Mask = "999,999,999,999";
            this.mtb_rgie.Name = "mtb_rgie";
            this.mtb_rgie.Size = new System.Drawing.Size(187, 29);
            this.mtb_rgie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(907, 35);
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
            this.dtp_de.Location = new System.Drawing.Point(965, 38);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(153, 29);
            this.dtp_de.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1124, 35);
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
            this.dtp_ate.Location = new System.Drawing.Point(1188, 38);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(154, 29);
            this.dtp_ate.TabIndex = 19;
            // 
            // chbx_todasDatas
            // 
            this.chbx_todasDatas.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbx_todasDatas, 2);
            this.chbx_todasDatas.Location = new System.Drawing.Point(965, 73);
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
            this.btn_pesquisar.Location = new System.Drawing.Point(1188, 73);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(154, 35);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(15, 726);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(60, 24);
            this.lbl_quantidade.TabIndex = 19;
            this.lbl_quantidade.Text = "label3";
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Cliente);
            this.Controls.Add(this.dgv_fornecedores);
            this.Location = new System.Drawing.Point(11, 3);
            this.Name = "Fornecedores";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fornecedores)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.DataGridView dgv_fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
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
        private System.Windows.Forms.CheckBox chbx_todasDatas;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}

namespace Pegasus.Controllers.Funcionario
{
    partial class Funcionarios
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
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.btn_AlterarCliente = new System.Windows.Forms.Button();
            this.btn_NovoCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1327, 111);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // txt_nome
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_nome, 3);
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nome.Location = new System.Drawing.Point(84, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(803, 29);
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
            this.cmb_cidade.Size = new System.Drawing.Size(359, 32);
            this.cmb_cidade.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(449, 70);
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
            this.cmb_estado.Location = new System.Drawing.Point(528, 73);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(359, 32);
            this.cmb_estado.TabIndex = 15;
            // 
            // lbl_rgie
            // 
            this.lbl_rgie.AutoSize = true;
            this.lbl_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rgie.Location = new System.Drawing.Point(449, 35);
            this.lbl_rgie.Name = "lbl_rgie";
            this.lbl_rgie.Size = new System.Drawing.Size(73, 35);
            this.lbl_rgie.TabIndex = 10;
            this.lbl_rgie.Text = "RG:";
            this.lbl_rgie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_rgie
            // 
            this.mtb_rgie.Location = new System.Drawing.Point(528, 38);
            this.mtb_rgie.Mask = "99,999,999-99";
            this.mtb_rgie.Name = "mtb_rgie";
            this.mtb_rgie.Size = new System.Drawing.Size(187, 29);
            this.mtb_rgie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(893, 35);
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
            this.dtp_de.Location = new System.Drawing.Point(951, 38);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(150, 29);
            this.dtp_de.TabIndex = 17;
            this.dtp_de.ValueChanged += new System.EventHandler(this.dtp_de_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1107, 35);
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
            this.dtp_ate.Location = new System.Drawing.Point(1171, 38);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(153, 29);
            this.dtp_ate.TabIndex = 19;
            this.dtp_ate.ValueChanged += new System.EventHandler(this.dtp_ate_ValueChanged);
            // 
            // chbx_todasDatas
            // 
            this.chbx_todasDatas.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbx_todasDatas, 2);
            this.chbx_todasDatas.Location = new System.Drawing.Point(951, 73);
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
            this.btn_pesquisar.Location = new System.Drawing.Point(1171, 73);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(153, 35);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(14, 685);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(60, 24);
            this.lbl_quantidade.TabIndex = 31;
            this.lbl_quantidade.Text = "label3";
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.AllowUserToAddRows = false;
            this.dgv_funcionarios.AllowUserToDeleteRows = false;
            this.dgv_funcionarios.AllowUserToResizeColumns = false;
            this.dgv_funcionarios.AllowUserToResizeRows = false;
            this.dgv_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funcionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_funcionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_funcionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.RazaoSocial,
            this.CNPJ,
            this.Endereco});
            this.dgv_funcionarios.Location = new System.Drawing.Point(15, 129);
            this.dgv_funcionarios.MultiSelect = false;
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.ReadOnly = true;
            this.dgv_funcionarios.RowHeadersVisible = false;
            this.dgv_funcionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_funcionarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionarios.ShowCellErrors = false;
            this.dgv_funcionarios.ShowCellToolTips = false;
            this.dgv_funcionarios.ShowRowErrors = false;
            this.dgv_funcionarios.Size = new System.Drawing.Size(1327, 539);
            this.dgv_funcionarios.TabIndex = 27;
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
            this.RazaoSocial.HeaderText = "Nome";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CNPJ.HeaderText = "CPF";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 72;
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Endereco.HeaderText = "RG";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 62;
            // 
            // btn_ExcluirCliente
            // 
            this.btn_ExcluirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCliente.Image = global::Pegasus.Properties.Resources.error;
            this.btn_ExcluirCliente.Location = new System.Drawing.Point(1214, 674);
            this.btn_ExcluirCliente.Name = "btn_ExcluirCliente";
            this.btn_ExcluirCliente.Size = new System.Drawing.Size(124, 44);
            this.btn_ExcluirCliente.TabIndex = 34;
            this.btn_ExcluirCliente.Text = "Excluir";
            this.btn_ExcluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExcluirCliente.UseVisualStyleBackColor = true;
            this.btn_ExcluirCliente.Click += new System.EventHandler(this.btn_ExcluirCliente_Click);
            // 
            // btn_AlterarCliente
            // 
            this.btn_AlterarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarCliente.Image = global::Pegasus.Properties.Resources.file;
            this.btn_AlterarCliente.Location = new System.Drawing.Point(1084, 674);
            this.btn_AlterarCliente.Name = "btn_AlterarCliente";
            this.btn_AlterarCliente.Size = new System.Drawing.Size(124, 44);
            this.btn_AlterarCliente.TabIndex = 33;
            this.btn_AlterarCliente.Text = "Alterar";
            this.btn_AlterarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AlterarCliente.UseVisualStyleBackColor = true;
            this.btn_AlterarCliente.Click += new System.EventHandler(this.btn_AlterarCliente_Click);
            // 
            // btn_NovoCliente
            // 
            this.btn_NovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoCliente.Image = global::Pegasus.Properties.Resources.plus;
            this.btn_NovoCliente.Location = new System.Drawing.Point(954, 674);
            this.btn_NovoCliente.Name = "btn_NovoCliente";
            this.btn_NovoCliente.Size = new System.Drawing.Size(124, 44);
            this.btn_NovoCliente.TabIndex = 32;
            this.btn_NovoCliente.Text = "Novo";
            this.btn_NovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NovoCliente.UseVisualStyleBackColor = true;
            this.btn_NovoCliente.Click += new System.EventHandler(this.btn_NovoCliente_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ExcluirCliente);
            this.Controls.Add(this.btn_AlterarCliente);
            this.Controls.Add(this.btn_NovoCliente);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.dgv_funcionarios);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1350, 729);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.Button btn_ExcluirCliente;
        private System.Windows.Forms.Button btn_AlterarCliente;
        private System.Windows.Forms.Button btn_NovoCliente;
    }
}
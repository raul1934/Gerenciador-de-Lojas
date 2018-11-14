namespace Pegasus.Controllers.Fornecedor
{
    partial class AlterarFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_Cep = new System.Windows.Forms.MaskedTextBox();
            this.cmb_UF = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgv_telefone = new System.Windows.Forms.DataGridView();
            this.numero_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefone)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1097, 57);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::Pegasus.Properties.Resources.plus;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txt_Email, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_Cidade, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Numero, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Bairro, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Endereco, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mtb_rgie, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_rgie, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.mtb_cpfcnpj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cpfcnpj, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_razao, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_razaoSocial, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Nome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nomeFantasia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chx_Ativo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.mtb_Cep, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmb_UF, 6, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1099, 283);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // txt_Email
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Email, 4);
            this.txt_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(151, 247);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(754, 29);
            this.txt_Email.TabIndex = 59;
            // 
            // txt_Cidade
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Cidade, 4);
            this.txt_Cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(151, 212);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(754, 29);
            this.txt_Cidade.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(911, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 24;
            this.label4.Text = "UF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(911, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 35);
            this.label8.TabIndex = 56;
            this.label8.Text = "CEP:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(998, 142);
            this.txt_Numero.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(101, 29);
            this.txt_Numero.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 35);
            this.label10.TabIndex = 54;
            this.label10.Text = "Numero:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Bairro
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Bairro, 4);
            this.txt_Bairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(151, 177);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(754, 29);
            this.txt_Bairro.TabIndex = 48;
            // 
            // txt_Endereco
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Endereco, 4);
            this.txt_Endereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(151, 142);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(754, 29);
            this.txt_Endereco.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 139);
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
            this.mtb_rgie.Location = new System.Drawing.Point(760, 107);
            this.mtb_rgie.Mask = "999.999.999.999";
            this.mtb_rgie.Name = "mtb_rgie";
            this.mtb_rgie.Size = new System.Drawing.Size(145, 29);
            this.mtb_rgie.TabIndex = 44;
            // 
            // lbl_rgie
            // 
            this.lbl_rgie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rgie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rgie.Location = new System.Drawing.Point(460, 104);
            this.lbl_rgie.Name = "lbl_rgie";
            this.lbl_rgie.Size = new System.Drawing.Size(294, 35);
            this.lbl_rgie.TabIndex = 43;
            this.lbl_rgie.Text = "IE:";
            this.lbl_rgie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_cpfcnpj
            // 
            this.mtb_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpfcnpj.Location = new System.Drawing.Point(151, 107);
            this.mtb_cpfcnpj.Mask = "99.999.999/9999-99";
            this.mtb_cpfcnpj.Name = "mtb_cpfcnpj";
            this.mtb_cpfcnpj.Size = new System.Drawing.Size(169, 29);
            this.mtb_cpfcnpj.TabIndex = 42;
            // 
            // lbl_cpfcnpj
            // 
            this.lbl_cpfcnpj.AutoSize = true;
            this.lbl_cpfcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpfcnpj.Location = new System.Drawing.Point(3, 104);
            this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
            this.lbl_cpfcnpj.Size = new System.Drawing.Size(142, 35);
            this.lbl_cpfcnpj.TabIndex = 41;
            this.lbl_cpfcnpj.Text = "CNPJ:";
            this.lbl_cpfcnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_razao
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_razao, 4);
            this.txt_razao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razao.Location = new System.Drawing.Point(151, 72);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(754, 29);
            this.txt_razao.TabIndex = 40;
            // 
            // lbl_razaoSocial
            // 
            this.lbl_razaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_razaoSocial.AutoSize = true;
            this.lbl_razaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razaoSocial.Location = new System.Drawing.Point(3, 69);
            this.lbl_razaoSocial.Name = "lbl_razaoSocial";
            this.lbl_razaoSocial.Size = new System.Drawing.Size(142, 35);
            this.lbl_razaoSocial.TabIndex = 39;
            this.lbl_razaoSocial.Text = "Razão Social:";
            this.lbl_razaoSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Nome
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Nome, 4);
            this.txt_Nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(151, 37);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(754, 29);
            this.txt_Nome.TabIndex = 38;
            // 
            // lbl_nomeFantasia
            // 
            this.lbl_nomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nomeFantasia.AutoSize = true;
            this.lbl_nomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeFantasia.Location = new System.Drawing.Point(3, 34);
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
            this.chx_Ativo.Location = new System.Drawing.Point(760, 3);
            this.chx_Ativo.Name = "chx_Ativo";
            this.chx_Ativo.Size = new System.Drawing.Size(145, 28);
            this.chx_Ativo.TabIndex = 36;
            this.chx_Ativo.Text = "Ativo";
            this.chx_Ativo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 35);
            this.label9.TabIndex = 49;
            this.label9.Text = "Cidade:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 174);
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
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 35);
            this.label3.TabIndex = 50;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtb_Cep
            // 
            this.mtb_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Cep.Location = new System.Drawing.Point(998, 177);
            this.mtb_Cep.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mtb_Cep.Mask = "00.000-000";
            this.mtb_Cep.Name = "mtb_Cep";
            this.mtb_Cep.Size = new System.Drawing.Size(101, 29);
            this.mtb_Cep.TabIndex = 57;
            // 
            // cmb_UF
            // 
            this.cmb_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UF.FormattingEnabled = true;
            this.cmb_UF.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO"});
            this.cmb_UF.Location = new System.Drawing.Point(998, 209);
            this.cmb_UF.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_UF.Name = "cmb_UF";
            this.cmb_UF.Size = new System.Drawing.Size(101, 32);
            this.cmb_UF.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 350);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 162);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.dgv_telefone);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1091, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::Pegasus.Properties.Resources.plus;
            this.button6.Location = new System.Drawing.Point(761, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 19;
            this.button6.Text = "Novo";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::Pegasus.Properties.Resources.file;
            this.button7.Location = new System.Drawing.Point(867, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 18;
            this.button7.Text = "Alterar";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Pegasus.Properties.Resources.error;
            this.button8.Location = new System.Drawing.Point(973, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 40);
            this.button8.TabIndex = 17;
            this.button8.Text = "Excluir";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
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
            this.dgv_telefone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_telefone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_telefone.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_telefone.RowHeadersVisible = false;
            this.dgv_telefone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_telefone.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_telefone.RowTemplate.Height = 50;
            this.dgv_telefone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_telefone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_telefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_telefone.Size = new System.Drawing.Size(1051, 56);
            this.dgv_telefone.TabIndex = 0;
            // 
            // numero_id
            // 
            this.numero_id.HeaderText = "id";
            this.numero_id.Name = "numero_id";
            this.numero_id.Visible = false;
            // 
            // Numero
            // 
            dataGridViewCellStyle9.NullValue = null;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle9;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Tipo
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle10;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Observação
            // 
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            // 
            // AlterarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 508);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AlterarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlterarFornecedor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtb_rgie;
        private System.Windows.Forms.Label lbl_rgie;
        private System.Windows.Forms.MaskedTextBox mtb_cpfcnpj;
        private System.Windows.Forms.Label lbl_cpfcnpj;
        private System.Windows.Forms.TextBox txt_razao;
        private System.Windows.Forms.Label lbl_razaoSocial;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_nomeFantasia;
        private System.Windows.Forms.CheckBox chx_Ativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_Cep;
        private System.Windows.Forms.ComboBox cmb_UF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgv_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
    }
}
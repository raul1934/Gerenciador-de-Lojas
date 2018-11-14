namespace Pegasus.Controllers.OrdemServico
{
    partial class OrdensServiço
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_excluirOrdemServico = new System.Windows.Forms.Button();
            this.btn_AlterarOrdemServico = new System.Windows.Forms.Button();
            this.btn_NovaOrdemServico = new System.Windows.Forms.Button();
            this.dgv_ordemServico = new System.Windows.Forms.DataGridView();
            this.NumeroOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ate = new System.Windows.Forms.DateTimePicker();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.chbx_todasDatas = new System.Windows.Forms.CheckBox();
            this.lbl_numeroOrdemServico = new System.Windows.Forms.Label();
            this.txt_numos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_situacao = new System.Windows.Forms.ComboBox();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordemServico)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_excluirOrdemServico
            // 
            this.btn_excluirOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluirOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirOrdemServico.Image = global::Pegasus.Properties.Resources.error;
            this.btn_excluirOrdemServico.Location = new System.Drawing.Point(1232, 707);
            this.btn_excluirOrdemServico.Name = "btn_excluirOrdemServico";
            this.btn_excluirOrdemServico.Size = new System.Drawing.Size(124, 44);
            this.btn_excluirOrdemServico.TabIndex = 26;
            this.btn_excluirOrdemServico.Text = "Excluir";
            this.btn_excluirOrdemServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_excluirOrdemServico.UseVisualStyleBackColor = true;
            this.btn_excluirOrdemServico.Click += new System.EventHandler(this.btn_excluirOrdemServico_Click);
            // 
            // btn_AlterarOrdemServico
            // 
            this.btn_AlterarOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AlterarOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarOrdemServico.Image = global::Pegasus.Properties.Resources.file;
            this.btn_AlterarOrdemServico.Location = new System.Drawing.Point(1102, 707);
            this.btn_AlterarOrdemServico.Name = "btn_AlterarOrdemServico";
            this.btn_AlterarOrdemServico.Size = new System.Drawing.Size(124, 44);
            this.btn_AlterarOrdemServico.TabIndex = 25;
            this.btn_AlterarOrdemServico.Text = "Alterar";
            this.btn_AlterarOrdemServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AlterarOrdemServico.UseVisualStyleBackColor = true;
            this.btn_AlterarOrdemServico.Click += new System.EventHandler(this.btn_AlterarOrdemServico_Click);
            // 
            // btn_NovaOrdemServico
            // 
            this.btn_NovaOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NovaOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaOrdemServico.Image = global::Pegasus.Properties.Resources.plus;
            this.btn_NovaOrdemServico.Location = new System.Drawing.Point(972, 707);
            this.btn_NovaOrdemServico.Name = "btn_NovaOrdemServico";
            this.btn_NovaOrdemServico.Size = new System.Drawing.Size(124, 44);
            this.btn_NovaOrdemServico.TabIndex = 24;
            this.btn_NovaOrdemServico.Text = "Novo";
            this.btn_NovaOrdemServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NovaOrdemServico.UseVisualStyleBackColor = true;
            this.btn_NovaOrdemServico.Click += new System.EventHandler(this.btn_NovaOrdemServico_Click);
            // 
            // dgv_ordemServico
            // 
            this.dgv_ordemServico.AllowUserToAddRows = false;
            this.dgv_ordemServico.AllowUserToDeleteRows = false;
            this.dgv_ordemServico.AllowUserToResizeColumns = false;
            this.dgv_ordemServico.AllowUserToResizeRows = false;
            this.dgv_ordemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ordemServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ordemServico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ordemServico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ordemServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ordemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroOs,
            this.Data,
            this.Cliente,
            this.Situação});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ordemServico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ordemServico.Location = new System.Drawing.Point(11, 156);
            this.dgv_ordemServico.MultiSelect = false;
            this.dgv_ordemServico.Name = "dgv_ordemServico";
            this.dgv_ordemServico.ReadOnly = true;
            this.dgv_ordemServico.RowHeadersVisible = false;
            this.dgv_ordemServico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ordemServico.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ordemServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ordemServico.ShowCellErrors = false;
            this.dgv_ordemServico.ShowCellToolTips = false;
            this.dgv_ordemServico.ShowRowErrors = false;
            this.dgv_ordemServico.Size = new System.Drawing.Size(1345, 545);
            this.dgv_ordemServico.TabIndex = 20;
            this.dgv_ordemServico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordemServico_CellDoubleClick);
            // 
            // NumeroOs
            // 
            this.NumeroOs.HeaderText = "Numero da OS.";
            this.NumeroOs.Name = "NumeroOs";
            this.NumeroOs.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Situação
            // 
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.tableLayoutPanel2.Controls.Add(this.lbl_Cliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_de, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_ate, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_pesquisar, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.chbx_todasDatas, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_numeroOrdemServico, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_numos, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_situacao, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Cliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_tipo, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmb_tipo, 6, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1345, 150);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(3, 0);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(85, 38);
            this.lbl_Cliente.TabIndex = 0;
            this.lbl_Cliente.Text = "Cliente:";
            this.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(913, 38);
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
            this.dtp_de.Location = new System.Drawing.Point(971, 41);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(149, 29);
            this.dtp_de.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(1126, 38);
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
            this.dtp_ate.Location = new System.Drawing.Point(1190, 41);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(152, 29);
            this.dtp_ate.TabIndex = 19;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pesquisar.Image = global::Pegasus.Properties.Resources.search;
            this.btn_pesquisar.Location = new System.Drawing.Point(1190, 110);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(152, 37);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // chbx_todasDatas
            // 
            this.chbx_todasDatas.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.chbx_todasDatas, 2);
            this.chbx_todasDatas.Location = new System.Drawing.Point(971, 76);
            this.chbx_todasDatas.Name = "chbx_todasDatas";
            this.chbx_todasDatas.Size = new System.Drawing.Size(162, 28);
            this.chbx_todasDatas.TabIndex = 22;
            this.chbx_todasDatas.Text = "Todas as Datas:";
            this.chbx_todasDatas.UseVisualStyleBackColor = true;
            this.chbx_todasDatas.CheckedChanged += new System.EventHandler(this.chbx_todasDatas_CheckedChanged);
            // 
            // lbl_numeroOrdemServico
            // 
            this.lbl_numeroOrdemServico.AutoSize = true;
            this.lbl_numeroOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_numeroOrdemServico.Location = new System.Drawing.Point(3, 38);
            this.lbl_numeroOrdemServico.Name = "lbl_numeroOrdemServico";
            this.lbl_numeroOrdemServico.Size = new System.Drawing.Size(85, 35);
            this.lbl_numeroOrdemServico.TabIndex = 25;
            this.lbl_numeroOrdemServico.Text = "Num Os:";
            this.lbl_numeroOrdemServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_numos
            // 
            this.txt_numos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_numos.Location = new System.Drawing.Point(94, 41);
            this.txt_numos.Name = "txt_numos";
            this.txt_numos.Size = new System.Drawing.Size(357, 29);
            this.txt_numos.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(457, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 27;
            this.label1.Text = "Situação:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_situacao
            // 
            this.cmb_situacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_situacao.FormattingEnabled = true;
            this.cmb_situacao.Items.AddRange(new object[] {
            "Todas",
            "Em Aberto",
            "Finalizado",
            "Cancelado",
            "Aguardando Pagamento"});
            this.cmb_situacao.Location = new System.Drawing.Point(550, 41);
            this.cmb_situacao.Name = "cmb_situacao";
            this.cmb_situacao.Size = new System.Drawing.Size(357, 32);
            this.cmb_situacao.TabIndex = 28;
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel2.SetColumnSpan(this.cmb_Cliente, 3);
            this.cmb_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(94, 3);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(813, 32);
            this.cmb_Cliente.TabIndex = 29;
            this.cmb_Cliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tipo.Location = new System.Drawing.Point(971, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(149, 38);
            this.lbl_tipo.TabIndex = 30;
            this.lbl_tipo.Text = "Tipo:";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_tipo
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmb_tipo, 2);
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Todos",
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.cmb_tipo.Location = new System.Drawing.Point(1126, 3);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(216, 32);
            this.cmb_tipo.TabIndex = 31;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(15, 726);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(60, 24);
            this.lbl_quantidade.TabIndex = 28;
            this.lbl_quantidade.Text = "label4";
            // 
            // OrdensServiço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_excluirOrdemServico);
            this.Controls.Add(this.btn_AlterarOrdemServico);
            this.Controls.Add(this.btn_NovaOrdemServico);
            this.Controls.Add(this.dgv_ordemServico);
            this.Name = "OrdensServiço";
            this.Size = new System.Drawing.Size(1366, 768);
            this.Load += new System.EventHandler(this.OrdensServiço_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordemServico)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_excluirOrdemServico;
        private System.Windows.Forms.Button btn_AlterarOrdemServico;
        private System.Windows.Forms.Button btn_NovaOrdemServico;
        private System.Windows.Forms.DataGridView dgv_ordemServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ate;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.CheckBox chbx_todasDatas;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_numeroOrdemServico;
        private System.Windows.Forms.TextBox txt_numos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_situacao;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmb_tipo;
    }
}

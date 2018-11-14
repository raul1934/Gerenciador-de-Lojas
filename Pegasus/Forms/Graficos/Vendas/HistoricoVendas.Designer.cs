namespace Pegasus.Controllers.Graficos.Vendas
{
    partial class HistoricoVendas
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Meios de Pagamento");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Movimentação de Produtos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Caixa", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ranking de Compras");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Clientes", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Vendas Analitico");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vendas Sinteticas");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Fornecedores", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Comissão por Vendedor");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Horario de Pico");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("por Categoria e Produto");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("por Produto");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("por Marca");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("por Dia");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Vendas", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pdfExport = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_ate = new System.Windows.Forms.DateTimePicker();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_imprimir,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_imprimir
            // 
            this.tsb_imprimir.Image = global::Pegasus.Properties.Resources.printer;
            this.tsb_imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_imprimir.Name = "tsb_imprimir";
            this.tsb_imprimir.Size = new System.Drawing.Size(80, 51);
            this.tsb_imprimir.Text = "Imprimir - F5";
            this.tsb_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_imprimir.Click += new System.EventHandler(this.tsb_imprimir_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfExport});
            this.toolStripDropDownButton1.Image = global::Pegasus.Properties.Resources.export;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(53, 51);
            this.toolStripDropDownButton1.Text = "Export";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pdfExport
            // 
            this.pdfExport.Name = "pdfExport";
            this.pdfExport.Size = new System.Drawing.Size(95, 22);
            this.pdfExport.Text = "PDF";
            this.pdfExport.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(16, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Meios de Pagamento";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Movimentação de Produtos";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Caixa";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Ranking de Compras";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Clientes";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Vendas Analitico";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Vendas Sinteticas";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Fornecedores";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Comissão por Vendedor";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Horario de Pico";
            treeNode11.Name = "Node13";
            treeNode11.Text = "por Categoria e Produto";
            treeNode12.Name = "Node14";
            treeNode12.Text = "por Produto";
            treeNode13.Name = "Node15";
            treeNode13.Text = "por Marca";
            treeNode14.Name = "Node1";
            treeNode14.Text = "por Dia";
            treeNode15.Name = "Node9";
            treeNode15.Text = "Vendas";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode8,
            treeNode15});
            this.treeView1.PathSeparator = "/";
            this.treeView1.Size = new System.Drawing.Size(211, 361);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // cht1
            // 
            this.cht1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "Area1";
            this.cht1.ChartAreas.Add(chartArea1);
            this.cht1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cht1.Location = new System.Drawing.Point(250, 84);
            this.cht1.Name = "cht1";
            this.cht1.Size = new System.Drawing.Size(1088, 633);
            this.cht1.TabIndex = 1;
            this.cht1.Text = "Test";
            // 
            // dtp_ate
            // 
            this.dtp_ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ate.Location = new System.Drawing.Point(250, 52);
            this.dtp_ate.Name = "dtp_ate";
            this.dtp_ate.Size = new System.Drawing.Size(101, 26);
            this.dtp_ate.TabIndex = 5;
            this.dtp_ate.ValueChanged += new System.EventHandler(this.dtp_ate_ValueChanged);
            // 
            // dtp_de
            // 
            this.dtp_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_de.Location = new System.Drawing.Point(111, 52);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(101, 26);
            this.dtp_de.TabIndex = 6;
            this.dtp_de.ValueChanged += new System.EventHandler(this.dtp_de_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Periodo de: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "a";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoricoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_de);
            this.Controls.Add(this.dtp_ate);
            this.Controls.Add(this.cht1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "HistoricoVendas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricoVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HistoricoVendas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_imprimir;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht1;
        private System.Windows.Forms.DateTimePicker dtp_ate;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pdfExport;
    }
}
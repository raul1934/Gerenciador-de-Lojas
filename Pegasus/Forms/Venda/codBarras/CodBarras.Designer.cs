namespace Pegasus.Controllers.Venda.codBarras
{
    partial class CodBarras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodBarras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_codBarras = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codBarras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo de Barras:";
            // 
            // txt_codBarras
            // 
            this.txt_codBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codBarras.Location = new System.Drawing.Point(6, 42);
            this.txt_codBarras.MaxLength = 13;
            this.txt_codBarras.Name = "txt_codBarras";
            this.txt_codBarras.Size = new System.Drawing.Size(462, 31);
            this.txt_codBarras.TabIndex = 1;
            this.txt_codBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codBarras_KeyDown);
            this.txt_codBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codBarras_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsb_salvar,
            this.tsb_cancelar,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(498, 55);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // tsb_salvar
            // 
            this.tsb_salvar.AutoToolTip = false;
            this.tsb_salvar.BackColor = System.Drawing.Color.Transparent;
            this.tsb_salvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_salvar.Image")));
            this.tsb_salvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salvar.Name = "tsb_salvar";
            this.tsb_salvar.Size = new System.Drawing.Size(86, 52);
            this.tsb_salvar.Text = "Salvar - F2";
            this.tsb_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click);
            // 
            // tsb_cancelar
            // 
            this.tsb_cancelar.AutoToolTip = false;
            this.tsb_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.tsb_cancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_cancelar.Image = global::Pegasus.Properties.Resources.error;
            this.tsb_cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancelar.Name = "tsb_cancelar";
            this.tsb_cancelar.Size = new System.Drawing.Size(110, 52);
            this.tsb_cancelar.Text = "Cancelar - F12";
            this.tsb_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_cancelar.Click += new System.EventHandler(this.tsb_cancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // CodBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 175);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CodBarras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Codigo de Barras";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodBarras_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.ToolStripButton tsb_cancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txt_codBarras;
    }
}
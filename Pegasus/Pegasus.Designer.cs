namespace Pegasus
{
    partial class Pegasus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pegasus));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.finaceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorioClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaOS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoOS = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoDeVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNFeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoNfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheques = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNFeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.finaceiroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.pontoDeVeToolStripMenuItem,
            this.notaFiscalToolStripMenuItem1,
            this.eToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1350, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProdutos,
            this.menuServicos,
            this.menuFornecedores,
            this.menuFuncionarios});
            this.menuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCadastro.ForeColor = System.Drawing.Color.Black;
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(111, 29);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(217, 30);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(217, 30);
            this.menuProdutos.Text = "Produtos";
            this.menuProdutos.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // menuServicos
            // 
            this.menuServicos.Name = "menuServicos";
            this.menuServicos.Size = new System.Drawing.Size(217, 30);
            this.menuServicos.Text = "Servicos";
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(217, 30);
            this.menuFornecedores.Text = "Fornecedores";
            this.menuFornecedores.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(217, 30);
            this.menuFuncionarios.Text = "Funcionarios";
            this.menuFuncionarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // finaceiroToolStripMenuItem
            // 
            this.finaceiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelatorioEstoque,
            this.menuRelatorioClientes});
            this.finaceiroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaceiroToolStripMenuItem.Name = "finaceiroToolStripMenuItem";
            this.finaceiroToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.finaceiroToolStripMenuItem.Text = "Relatorios";
            // 
            // menuRelatorioEstoque
            // 
            this.menuRelatorioEstoque.Name = "menuRelatorioEstoque";
            this.menuRelatorioEstoque.Size = new System.Drawing.Size(285, 30);
            this.menuRelatorioEstoque.Text = "Relatorio do Estoque";
            this.menuRelatorioEstoque.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem_Click);
            // 
            // menuRelatorioClientes
            // 
            this.menuRelatorioClientes.Name = "menuRelatorioClientes";
            this.menuRelatorioClientes.Size = new System.Drawing.Size(285, 30);
            this.menuRelatorioClientes.Text = "Relatorio de Clientes";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaOS,
            this.menuHistoricoOS});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(196, 29);
            this.vendasToolStripMenuItem.Text = "Ordem de Serviço";
            // 
            // menuNovaOS
            // 
            this.menuNovaOS.Name = "menuNovaOS";
            this.menuNovaOS.Size = new System.Drawing.Size(246, 30);
            this.menuNovaOS.Text = "Nova O.S.";
            this.menuNovaOS.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // menuHistoricoOS
            // 
            this.menuHistoricoOS.Name = "menuHistoricoOS";
            this.menuHistoricoOS.Size = new System.Drawing.Size(246, 30);
            this.menuHistoricoOS.Text = "Historico de O.S.";
            this.menuHistoricoOS.Click += new System.EventHandler(this.historicoDeVendasToolStripMenuItem_Click);
            // 
            // pontoDeVeToolStripMenuItem
            // 
            this.pontoDeVeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem});
            this.pontoDeVeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.pontoDeVeToolStripMenuItem.Name = "pontoDeVeToolStripMenuItem";
            this.pontoDeVeToolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.pontoDeVeToolStripMenuItem.Text = "Ponto de Venda";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click_1);
            // 
            // notaFiscalToolStripMenuItem1
            // 
            this.notaFiscalToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirNFeToolStripMenuItem1,
            this.historicoNfeToolStripMenuItem});
            this.notaFiscalToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.notaFiscalToolStripMenuItem1.Name = "notaFiscalToolStripMenuItem1";
            this.notaFiscalToolStripMenuItem1.Size = new System.Drawing.Size(132, 29);
            this.notaFiscalToolStripMenuItem1.Text = "Nota Fiscal";
            // 
            // emitirNFeToolStripMenuItem1
            // 
            this.emitirNFeToolStripMenuItem1.Name = "emitirNFeToolStripMenuItem1";
            this.emitirNFeToolStripMenuItem1.Size = new System.Drawing.Size(237, 30);
            this.emitirNFeToolStripMenuItem1.Text = "Emitir NFe";
            // 
            // historicoNfeToolStripMenuItem
            // 
            this.historicoNfeToolStripMenuItem.Name = "historicoNfeToolStripMenuItem";
            this.historicoNfeToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.historicoNfeToolStripMenuItem.Text = "Historico de Nfe";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFluxoCaixa,
            this.menuCheques,
            this.emitirNFeToolStripMenuItem,
            this.historicoVendasToolStripMenuItem});
            this.eToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.eToolStripMenuItem.Text = "Financeiro";
            // 
            // menuFluxoCaixa
            // 
            this.menuFluxoCaixa.Name = "menuFluxoCaixa";
            this.menuFluxoCaixa.Size = new System.Drawing.Size(247, 30);
            this.menuFluxoCaixa.Text = "Fluxo de Caixa";
            this.menuFluxoCaixa.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem1_Click);
            // 
            // menuCheques
            // 
            this.menuCheques.Name = "menuCheques";
            this.menuCheques.Size = new System.Drawing.Size(247, 30);
            this.menuCheques.Text = "Cheques";
            this.menuCheques.Click += new System.EventHandler(this.chequesToolStripMenuItem1_Click);
            // 
            // emitirNFeToolStripMenuItem
            // 
            this.emitirNFeToolStripMenuItem.Name = "emitirNFeToolStripMenuItem";
            this.emitirNFeToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.emitirNFeToolStripMenuItem.Click += new System.EventHandler(this.emitirNFeToolStripMenuItem_Click);
            // 
            // historicoVendasToolStripMenuItem
            // 
            this.historicoVendasToolStripMenuItem.Name = "historicoVendasToolStripMenuItem";
            this.historicoVendasToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.historicoVendasToolStripMenuItem.Text = "Historico Vendas";
            this.historicoVendasToolStripMenuItem.Click += new System.EventHandler(this.historicoVendasToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaFiscalToolStripMenuItem,
            this.nCMToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // nCMToolStripMenuItem
            // 
            this.nCMToolStripMenuItem.Name = "nCMToolStripMenuItem";
            this.nCMToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.nCMToolStripMenuItem.Text = "NCM";
            this.nCMToolStripMenuItem.Click += new System.EventHandler(this.nCMToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1326, 682);
            this.mainPanel.TabIndex = 1;
            // 
            // Pegasus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Pegasus";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pegasus_KeyPress);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNovaOS;
        private System.Windows.Forms.ToolStripMenuItem menuHistoricoOS;
        private System.Windows.Forms.ToolStripMenuItem finaceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuCheques;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorioClientes;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNFeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emitirNFeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historicoNfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontoDeVeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuServicos;
        private System.Windows.Forms.ToolStripMenuItem nCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoVendasToolStripMenuItem;
    }
}


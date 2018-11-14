
using NHibernate.Linq;
using Pegasus.Business.Implementation;

using Pegasus.Controllers.Cliente;
using Pegasus.Controllers.Produtos;

using Pegasus.Controllers.Venda;
using Pegasus.Controllers.Venda.codBarras;
using Pegasus.Factory.Entities;
using Pegasus.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Pegasus.Controllers.OrdemServico
{
    public partial class NovaVenda : Form
    {

        public global::Pegasus.Factory.Entities.OrdemServico ordemServico { get; set; }
        public global::Pegasus.Factory.Entities.Venda novaVenda { get; set; }

        public string code = "";
        private bool isShiftPressed = false;
        private bool ImprimirSemEnviarNFe = false;
        public NovaVenda()
        {   //novaVenda.produtos = new
            // InitializeComponent();
            // venda = new Factory.Entities.Venda();
            // venda.cliente = null;
            this.Text = "Pegasus PDV: " + FuncionarioLogado.funcionarioLogado.nome;

        }
    }
}

        
    



   
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Pegasus.Factory.Entities
{
    public class Permissoes 
    {
       public virtual int id { get; set; }
       public virtual Boolean cadastrarFuncionario { get; set; }
       public virtual Boolean editarFuncionario { get; set; }
       public virtual Boolean excluirFuncionario { get; set; }
       public virtual Boolean visualizarFuncionario { get; set; }
       public virtual Boolean cadastrarOs { get; set; }
       public virtual Boolean editarOs { get; set; }
       public virtual Boolean excluirOs { get; set; }
       public virtual Boolean visualizarOs { get; set; }
       public virtual Boolean visualizarTodasOs { get; set; }
       public virtual Boolean cadastrarProduto { get; set; }
       public virtual Boolean editarProduto { get; set; }
       public virtual Boolean excluirProduto { get; set; }
       public virtual Boolean visualizarProduto { get; set; }
       public virtual Boolean cadastrarCliente { get; set; }
       public virtual Boolean editarCliente { get; set; }
       public virtual Boolean excluirCliente { get; set; }
       public virtual Boolean visualizarCliente { get; set; }
       public virtual Boolean cadastrarFornecedor { get; set; }
       public virtual Boolean editarFornecedor { get; set; }
       public virtual Boolean excluirFornecedor { get; set; }
       public virtual Boolean visualizarFornecedor { get; set; }
       public virtual Boolean cadastrarCheque { get; set; }
       public virtual Boolean editarCheque { get; set; }
       public virtual Boolean excluirCheque { get; set; }
       public virtual Boolean visualizarCheque { get; set; }
       public virtual Boolean gerarRelatorioFluxoCaixa { get; set; }
       public virtual Boolean gerarRelatorioOs { get; set; }
       public virtual Boolean gerarRelatorioEstoque { get; set; }
       public virtual Boolean gerarRelatorioClientes { get; set; }

    }
}

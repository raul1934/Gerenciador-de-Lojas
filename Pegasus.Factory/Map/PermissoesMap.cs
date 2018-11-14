using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
    public class PermissoesMap : ClassMap<Permissoes>
    {
        public PermissoesMap()
        {
            Table("tblfuncionariopermissao");
            Id(permissao => permissao.id).GeneratedBy.Identity();
            Map(permissao => permissao.cadastrarFuncionario);
            Map(permissao => permissao.editarFuncionario);
            Map(permissao => permissao.excluirFuncionario);
            Map(permissao => permissao.visualizarFuncionario);
            Map(permissao => permissao.cadastrarOs);
            Map(permissao => permissao.editarOs);
            Map(permissao => permissao.excluirOs);
            Map(permissao => permissao.visualizarOs);
            Map(permissao => permissao.visualizarTodasOs);
            Map(permissao => permissao.cadastrarProduto);
            Map(permissao => permissao.editarProduto);
            Map(permissao => permissao.excluirProduto);
            Map(permissao => permissao.visualizarProduto);
            Map(permissao => permissao.cadastrarCliente);
            Map(permissao => permissao.editarCliente);
            Map(permissao => permissao.excluirCliente);
            Map(permissao => permissao.visualizarCliente);
            Map(permissao => permissao.cadastrarFornecedor);
            Map(permissao => permissao.editarFornecedor);
            Map(permissao => permissao.excluirFornecedor);
            Map(permissao => permissao.visualizarFornecedor);
            Map(permissao => permissao.cadastrarCheque);
            Map(permissao => permissao.editarCheque);
            Map(permissao => permissao.excluirCheque);
            Map(permissao => permissao.visualizarCheque);
            Map(permissao => permissao.gerarRelatorioFluxoCaixa);
            Map(permissao => permissao.gerarRelatorioOs);
            Map(permissao => permissao.gerarRelatorioEstoque);
            Map(permissao => permissao.gerarRelatorioClientes);

        }
    }
}

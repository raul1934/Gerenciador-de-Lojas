using System;
using System.Collections.Generic;

namespace Pegasus.Factory.Entities
{
    public class Fornecedor
    {
        public virtual int id { get; set; }
        public virtual string nomeFantasia { get; set; }
        public virtual string razaoSocial { get; set; }
        public virtual string Ie { get; set; }
        public virtual string Cnpj { get; set; }
        public virtual bool ativo { get; set; }
        public virtual string endereco { get; set; }
        public virtual int numero { get; set; }
        public virtual string bairro { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual Estado estado { get; set; }
        public virtual Pais pais { get; set; }
        public virtual string email { get; set; }
        public virtual string cep { get; set; }
        public virtual IList<Produto> produtos { get; set; }
        public virtual IList<Telefone> telefone { get; set; }
        public virtual DateTime dataCadastro { get; set; }
        public Fornecedor()
        {
            telefone = new List<Telefone>();
            produtos = new List<Produto>();
            cidade = new Cidade();
            estado = new Estado();
            pais = new Pais();
        }
    }
}
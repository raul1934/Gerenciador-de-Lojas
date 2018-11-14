
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Cliente
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string rgIe { get; set; }
        public virtual string cpfCnpj { get; set; }
        public virtual DateTime nascimento { get; set; }
        public virtual DateTime dataCadastro { get; set; }
        public virtual bool ativo { get; set; }
        public virtual bool pessoaJuridica { get; set; }
        public virtual string endereco { get; set; }
        public virtual int numero { get; set; }
        public virtual string bairro { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual Estado estado { get; set; }
        public virtual Pais pais { get; set; }
        public virtual string email { get; set; }
        public virtual string cep { get; set; }
        public virtual IList<Telefone> telefone { get; set; }
        public virtual string razaoSocial { get; set; }
        public Cliente()
        {
            telefone = new List<Telefone>();
            cidade = new Cidade();
            estado = new Estado();
            pais = new Pais();
        }
    }
}

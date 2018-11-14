using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Funcionario
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string rg { get; set; }
        public virtual string cpf { get; set; }
        public virtual bool ativo { get; set; }
        public virtual string endereco { get; set; }
        public virtual int numero { get; set; }
        public virtual string bairro { get; set; }
        public virtual string email { get; set; }
        public virtual string cep { get; set; }
        public virtual DateTime nascimento { get; set; }
        public virtual DateTime admissao { get; set; }
        public virtual DateTime dataCadastro { get; set; }
        public virtual IList<Telefone> telefone { get; set; }
        public virtual Permissoes permissoes { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual Estado estado { get; set; }
        public virtual string senha { get; set; }
        public Funcionario()
        {
            telefone = new List<Telefone>();
            permissoes = new Permissoes();
            cidade = new Cidade();
            estado = new Estado();
        }
    }
}

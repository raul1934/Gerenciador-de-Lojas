using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
  public  class Empresa
    {
        public virtual int id { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string IE { get; set; }
        public virtual string razaoSocial { get; set; }
        public virtual string nomeFantasia { get; set; }
        public virtual string telefone { get; set; }
        public virtual string endereco { get; set; }
        public virtual long numero { get; set; }
        public virtual string CEP { get; set; }
        public virtual string complemento { get; set; }
        public virtual string bairro { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual Estado estado { get; set; }
        public virtual Pais pais { get; set; }
        public virtual string CRT{ get; set; }
        public virtual byte[] logo { get; set; }
        public virtual byte[] logoDanfe { get; set; }
        public virtual int tipoCertificado { get; set; }
        public virtual string senha { get; set; }
        public virtual string path { get; set; }
        public virtual string serialNumberCert { get; set; }

        public Empresa()
        {
            cidade = new Cidade();
            estado = new Estado();
            pais = new Pais();
        }
    }
}

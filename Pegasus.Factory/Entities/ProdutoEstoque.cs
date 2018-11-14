using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
   public class ProdutoEstoque
    {
        public virtual int Id { get; set; }
        public virtual DateTime dataInicio { get; set; }
        public virtual DateTime dataFim { get; set; }
        public virtual decimal atual { get; set; }
        public virtual bool ativo { get; set; }
    }
}

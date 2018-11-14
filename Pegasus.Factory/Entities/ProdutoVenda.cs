using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
   public class ProdutoVenda
    {
        public virtual int id { get; set; }
        public virtual Decimal quantidade { get; set; }
        public virtual Decimal desconto { get; set; }
        public virtual Produto produto { get; set; }
        

        public ProdutoVenda()
        {
            produto = new Produto();
        }
    }
}

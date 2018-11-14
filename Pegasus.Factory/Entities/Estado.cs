using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
   public class Estado
    {
        public virtual int Id { get; set; }
        public virtual string nome { get; set; }
        public virtual string uf { get; set; }
        public virtual int ibge { get; set; }
        public virtual int sl { get; set; }
        public virtual string ddd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Telefone
    {
        public virtual int id { get; set; }
        public virtual string telefone { get; set; }
        public virtual string tipo { get; set; }
        public virtual string observacao { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
   public class Cidade
    {
        public virtual int Id { get; set; }
        public virtual string nome { get; set; }
        public virtual int uf { get; set; }
        public virtual int ibge { get; set; }
    }
}

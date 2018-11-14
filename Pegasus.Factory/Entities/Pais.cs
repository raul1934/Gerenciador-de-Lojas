using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Pais
    {
        public virtual int Id { get; set; }
        public virtual string nome { get; set; }
        public virtual string nomePortugues { get; set; }
        public virtual string sigla { get; set; }
        public virtual int bacen { get; set; }
    }
}

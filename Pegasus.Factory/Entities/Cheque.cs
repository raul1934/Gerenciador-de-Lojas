using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
    public class Cheque
    {
        public virtual int id { get; set; }
        public virtual string emitente { get; set; }
        public virtual string vencimento { get; set; }
        public virtual string cadastro { get; set; }
        public virtual Boolean pago { get; set; }
        public virtual string numero { get; set; }
        public virtual string numeroBanco { get; set; }
        public virtual string numeroAgencia { get; set; }
        public virtual string emissao { get; set; }
        public virtual string observacoes { get; set; }
        public virtual string baixadoem { get; set; }
        public virtual Decimal valor { get; set; }
        public virtual Decimal desconto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Entities
{
   public class ProdutoPreco
    {
        public virtual int Id { get; set; }
        public virtual DateTime dataInicio { get; set; }
        public virtual DateTime dataFim { get; set; }
        public virtual decimal precodeCompra { get; set; }
        public virtual decimal precoDeCusto { get; set; }
        public virtual decimal acrescimoDeCompra { get; set; }
        public virtual decimal precoFrete { get; set; }
        public virtual decimal acrescimoFrete { get; set; }
        public virtual decimal precoVendaVista { get; set; }
        public virtual decimal precoVendaPrazo { get; set; }
        public virtual decimal margemLucroPrazo { get; set; }
        public virtual decimal margemLucroVista { get; set; }
        public virtual bool ativo { get; set; }
        
    }
}

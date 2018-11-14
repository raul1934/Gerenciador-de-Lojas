using FluentNHibernate.Mapping;
using Pegasus.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Factory.Map
{
   public class ChequeMap  : ClassMap<Cheque>
    {
        public ChequeMap()
        {
            Table("tblCheque");
            Id(cheque => cheque.id).GeneratedBy.Identity();
            Map(cheque => cheque.numero);
            Map(cheque => cheque.cadastro);
            Map(cheque => cheque.emissao);
            Map(cheque => cheque.emitente);
            Map(cheque => cheque.numeroAgencia);
            Map(cheque => cheque.numeroBanco);
            Map(cheque => cheque.vencimento);
            Map(cheque => cheque.observacoes);
            Map(cheque => cheque.pago);
            Map(cheque => cheque.baixadoem);
            Map(cheque => cheque.valor).Scale(2).Precision(7);
            Map(cheque => cheque.desconto).Scale(2).Precision(7);


        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Business.Repository
{
    public interface ICrudDao<T>
    {
        void Inserir(T entidade);
        void Atualizar(T entidade);
        void Deletar(T entidade);
        T BuscarId(int id);
        IList<T> Buscar();
    }
}

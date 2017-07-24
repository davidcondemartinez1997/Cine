using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public interface IEntradaService
    {
        void Create(Entrada Entrada);
        Entrada Read(long Id);
        IList<Entrada> ReadAll();

        void Update(Entrada Entrada);

        void Delete(long Id);
    }
}

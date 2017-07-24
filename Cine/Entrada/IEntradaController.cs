using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public interface IEntradaController
    {
        void Create(EntradaDTO EntradaDTO);
        EntradaDTO Read(long Id);
        IList<EntradaDTO> ReadAll();

        void Update(EntradaDTO EntradaDTO);

        void Delete(long Id);

    }
}

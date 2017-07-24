using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public interface IEntradaConverter
    {
        EntradaDTO EntityToDTO(Entrada Entrada);
        Entrada DTOToEntity(EntradaDTO EntradaDTO);

    }
}

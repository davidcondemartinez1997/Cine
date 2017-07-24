using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public class EntradaConverter : IEntradaConverter
    {
        public Entrada DTOToEntity(EntradaDTO EntradaDTO)
        {
            Entrada res = new Entrada();
            res.Id = EntradaDTO.Id;
            return res;
        }

        public EntradaDTO EntityToDTO(Entrada Entrada)
        {
            EntradaDTO res = new EntradaDTO();
            res.Id = Entrada.Id;
            return res;
        }
    }
}

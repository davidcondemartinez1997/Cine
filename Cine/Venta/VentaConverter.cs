using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public class VentaConverter : IVentaConverter
    {
        public Venta DTOToEntity(VentaDTO VentaDTO)
        {
            Venta res = new Venta();
            res.Id = VentaDTO.Id;
            return res;
        }

        public VentaDTO EntityToDTO(Venta Venta)
        {
            VentaDTO res = new VentaDTO();
            res.Id = Venta.Id;
            return res;
        }
    }
}

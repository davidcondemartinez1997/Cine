using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public interface IVentaConverter
    {
        VentaDTO EntityToDTO(Venta Venta);
        Venta DTOToEntity(VentaDTO VentaDTO);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public interface IVentaController
    {
        void Create(VentaDTO VentaDTO);
        VentaDTO Read(long Id);
        IList<VentaDTO> ReadAll();

        void Update(VentaDTO VentaDTO);

        void Delete(long Id);

    }
}

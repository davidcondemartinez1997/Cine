using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public interface IVentaService
    {
        void Create(Venta Venta);
        Venta Read(long Id);
        IList<Venta> ReadAll();

        void Update(Venta Venta);

        void Delete(long Id);
    }
}

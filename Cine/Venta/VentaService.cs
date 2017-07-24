using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public class VentaService : IVentaService
    {
        private IVentaRepository VentaRepository;

        public VentaService (IVentaRepository _ventaRepository)
        {
            this.VentaRepository = _ventaRepository;
        }

        public void Create(Venta Venta)
        {
            VentaRepository.Create(Venta);
        }

        public void Delete(long Id)
        {
            VentaRepository.Delete(Id);
        }

        public Venta Read(long Id)
        {
            return VentaRepository.Read(Id);
        }

        public IList<Venta> ReadAll()
        {
            return VentaRepository.ReadAll();
        }

        public void Update(Venta Venta)
        {
            VentaRepository.Update(Venta);
        }
    }
}

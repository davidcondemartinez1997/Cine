using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public class VentaRepository : IVentaRepository
    {
        private List<Venta> repository = new List<Venta>();

        public void Create(Venta Venta)
        {
            repository.Add(Venta);
        }

        public void Delete(long Id)
        {
            repository.RemoveAll(x => x.Id == Id);
        }

        public Venta Read(long Id)
        {
            Venta venta = repository.Find(x => x.Id == Id);
            return venta;
        }

        public IList<Venta> ReadAll()
        {
            return repository;
        }

        public void Update(Venta Venta)
        {
            Venta ventaRepository = repository.FirstOrDefault(x => x.Id == Venta.Id);
            ventaRepository = Venta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Venta
{
    public class VentaController : IVentaController
    {
        private IVentaService VentaService;
        private IVentaConverter VentaConverter;
        public VentaController (IVentaService _ventaService, IVentaConverter _ventaConverter)
        {
            this.VentaConverter = _ventaConverter;
            this.VentaService = _ventaService;
        }

        public void Create(VentaDTO VentaDTO)
        {
            Venta Venta = VentaConverter.DTOToEntity(VentaDTO);
            VentaService.Create(Venta);
        }

        public void Delete(long Id)
        {
            VentaService.Delete(Id);
        }

        public VentaDTO Read(long Id)
        {
            Venta venta = VentaService.Read(Id);
            VentaDTO ventaDTO = VentaConverter.EntityToDTO(venta);
            return ventaDTO;
        }

        public IList<VentaDTO> ReadAll()
        {
            IList<VentaDTO> listaResultado = new List<VentaDTO>();
            IList<Venta> listaVenta = VentaService.ReadAll();
            foreach(Venta v in listaVenta)
            {
                VentaDTO ventaDTO = VentaConverter.EntityToDTO(v);
                listaResultado.Add(ventaDTO);
            }
            return listaResultado;
        }

        public void Update(VentaDTO VentaDTO)
        {
            Venta Venta = VentaConverter.DTOToEntity(VentaDTO);
            VentaService.Update(Venta);
        }
    }
}

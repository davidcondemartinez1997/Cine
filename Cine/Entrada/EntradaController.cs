using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public class EntradaController : IEntradaController
    {
        private IEntradaService EntradaService;
        private IEntradaConverter EntradaConverter;
        public EntradaController(IEntradaService _entradaService, IEntradaConverter _entradaConverter)
        {
            this.EntradaConverter = _entradaConverter;
            this.EntradaService = _entradaService;
        }

        public void Create(EntradaDTO EntradaDTO)
        {
            Entrada entrada = EntradaConverter.DTOToEntity(EntradaDTO);
            EntradaService.Create(entrada);
        }

        public void Delete(long Id)
        {
            EntradaService.Delete(Id);
        }

        public EntradaDTO Read(long Id)
        {
            Entrada entrada = EntradaService.Read(Id);
            EntradaDTO entradaDTO = EntradaConverter.EntityToDTO(entrada);
            return entradaDTO;
        }

        public IList<EntradaDTO> ReadAll()
        {
            IList<EntradaDTO> listaResultado = new List<EntradaDTO>();
            IList<Entrada> listaEntrada = EntradaService.ReadAll();
            foreach(Entrada v in listaEntrada)
            {
                EntradaDTO entradaDTO = EntradaConverter.EntityToDTO(v);
                listaResultado.Add(entradaDTO);
            }
            return listaResultado;
        }

        public void Update(EntradaDTO EntradaDTO)
        {
            Entrada Entrada = EntradaConverter.DTOToEntity(EntradaDTO);
            EntradaService.Update(Entrada);
        }
    }
}

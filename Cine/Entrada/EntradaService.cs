using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public class EntradaService : IEntradaService
    {
        private IEntradaRepository EntradaRepository;

        public EntradaService(IEntradaRepository _entradaRepository)
        {
            this.EntradaRepository = _entradaRepository;
        }

        public void Create(Entrada Entrada)
        {
            EntradaRepository.Create(Entrada);
        }

        public void Delete(long Id)
        {
            EntradaRepository.Delete(Id);
        }

        public Entrada Read(long Id)
        {
            return EntradaRepository.Read(Id);
        }

        public IList<Entrada> ReadAll()
        {
            return EntradaRepository.ReadAll();
        }

        public void Update(Entrada Entrada)
        {
            EntradaRepository.Update(Entrada);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Entrada
{
    public class EntradaRepository : IEntradaRepository
    {
        private List<Entrada> repository = new List<Entrada>();

        public void Create(Entrada Entrada)
        {
            repository.Add(Entrada);
        }

        public void Delete(long Id)
        {
            repository.RemoveAll(x => x.Id == Id);
        }

        public Entrada Read(long Id)
        {
            Entrada Entrada = repository.Find(x => x.Id == Id);
            return Entrada;
        }

        public IList<Entrada> ReadAll()
        {
            return repository;
        }

        public void Update(Entrada Entrada)
        {
            Entrada entradaRepository = repository.FirstOrDefault(x => x.Id == Entrada.Id);
            entradaRepository = Entrada;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    class OrdineOpzioni : Ordine
    {
        public List<Ordine> Archivio { get; set; }
        public OrdineOpzioni()
        {
            Archivio = new List<Ordine>();
        }
        public OrdineOpzioni(List<Ordine> archivio)
        {
            Archivio = archivio;
        }

        public Ordine RicercaOrdine(int idOrd)
        {
            foreach (var ord in Archivio)
                if (ord.IdOrdine == idOrd)
                    return ord;
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    class Prodotto
    {
        public int Codice { get; set; }
        public string Product { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            Console.WriteLine();
            return $"\n\nCodice: {Codice}" +
                $"\nProduct: {Product}" +
                $"\nDescrizione: {Descrizione}" +
                $"\nPrezzo: {Prezzo} euro\n";
        }
    }
}

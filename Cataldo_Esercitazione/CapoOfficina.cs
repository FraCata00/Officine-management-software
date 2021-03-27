using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    class CapoOfficina : Meccanico
    {
        public List<Ordine> Ordini { get; set; }

        public CapoOfficina()
        {
            Ordini = new List<Ordine>();
        }
        public CapoOfficina(List<Ordine> elenco)
        {
            Ordini = elenco;
        }

        public Ordine AggiungiOrdine(Ordine ordine, int index)
        {
            int count = 0;
            Ordini.Insert(index, ordine);
            count++;
            /*foreach (Object obj in Ordini)
                return (Venditore)obj;*/
            Ordini.Add(ordine);
            return ordine;
        }

        public int NoOrdini()
        {
            return Ordini.Count();
        }

        public double Tredicesima(Prodotto prodotto)
        {
            double bonusOrdine = (prodotto.Prezzo * 5) / 100;
            return (2 * Stipendio) + bonusOrdine;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return base.ToString() +
                $"\nOrdini: {string.Join("\n", Ordini)}" +
                $"\nNumero Ordini: {NoOrdini()}" +
                $"\nTredicesima: {Tredicesima()}";
        }
    }
}


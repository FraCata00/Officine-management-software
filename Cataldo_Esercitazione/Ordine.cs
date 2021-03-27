using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    class Ordine : Prodotto
    {
        public int IdOrdine { get; set; }
        public DateTime Data { get; set; }
        public List<Venditore> Venditore { get; set; }
        public List<Prodotto> ElencoProdotti { get; set; }
        public Ordine()
        {
            ElencoProdotti = new List<Prodotto>();
        }
        public Ordine(List<Prodotto> elenco)
        {
            ElencoProdotti = elenco;
        }

        public int NoProdotti()
        {
            Console.WriteLine();
            return ElencoProdotti.Count();
        }

        public double Totale()
        {
            double somma = 0;
            foreach (var p in ElencoProdotti)
                somma += p.Prezzo;
            return somma;
        }
        
        public string Scontrino(Prodotto prodotto)
        {
            return $"\nCodice Prodotto: {Codice}" +
                $"\nNome Prodotto: {Product}" +
                $"\nQuantita' ordinata: {NoProdotti()}" +
                $"\nPrezzo unitario: {Prezzo}" +
                $"\nSubTotale: " + Totale();
        }

        public string ProdottoToString(Prodotto prodotto)
        {
            Console.WriteLine();
            return prodotto.ToString();
        }
        public override string ToString()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            return $"\nID Ordine: {IdOrdine}" +
                $"\nData: {Data}" +
                $"\n\tVenditore: \n{string.Join("\n\n", Venditore)}" +
                $"\n\tElenco prodotti: \n{string.Join("\n\n", ElencoProdotti)}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    class ResponsabileVenditori : Venditore
    {
        public  List<Venditore> Venditori{ get; set; }
        public ResponsabileVenditori()
        {
            Venditori = new List<Venditore>();
        }
        public ResponsabileVenditori(List<Venditore> elenco)
        {
            Venditori = elenco;
        }

        public Venditore AggiungiVenditoreInput(string NomeV, string CognomeV, double StipendioV, int settoreV)
        {
            Venditore venditore = new Venditore()
            {
                Nome = NomeV,
                Cognome = CognomeV,
                Settore = (Settore)settoreV,
                Stipendio = StipendioV
            };

            Venditori.Add(venditore);
            return venditore;
        }

        public Venditore AggiungiVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
            return venditore;
        }

        public Venditore RestituisciVenditore(int index)
        {
            //int pos = 0;
            for (int i = 1; i < Venditori.Count; i++)
            {
                Console.WriteLine($"Indice {i}: ---> {Venditori[i]}");
            }
            return Venditori[index];
        }

        public void CancellaVenditore(int index)
        {
            Venditori.RemoveAt(index);
        }

        public override double Tredicesima()
        {
            int bonus = 1000;
            int TariffaGiornaliera = ((bonus / 22) * 15) / 100;
            return (Stipendio * 2) + TariffaGiornaliera;
        }

        public string Vendors(Venditore venditore)
        {
            //return venditore.Nome + venditore.Cognome + venditore.Stipendio;
            return venditore.ToString();
        }

        public string ToString(Venditore venditore)
        {
            Console.WriteLine();
            return base.ToString() +
                $"\n\tVenditori: \t{string.Join("\t\t", venditore)}";
        }

       
    }
}

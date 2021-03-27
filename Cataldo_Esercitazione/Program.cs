using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Cataldo_Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("[Officina Cataldo]\n");
            Console.WriteLine();

            Console.WriteLine(" d8888888b.888888888 888888888 88888888.d8888b.8888888888b    888       d8888 ");
            Console.WriteLine("d88P'' Y88b888       888         888  d88P  Y88b 888  8888b   888      d88888");
            Console.WriteLine("888     888888       888         888  888    888 888  88888b  888     d88P888");
            Console.WriteLine("888     8888888888   8888888     888  888        888  888Y88b 888    d88P 888");
            Console.WriteLine("888     888888       888         888  888        888  888 Y88b888   d88P  888");
            Console.WriteLine("888     888888       888         888  888    888 888  888  Y88888  d88P   888 ");
            Console.WriteLine("Y88b. .d88P888       888         888  Y88b  d88P 888  888   Y8888 d8888888888");
            Console.WriteLine("'Y88888P'88888       888       8888888 'Y8888P'888888888888  Y888d88P     888");
            
            Console.WriteLine("\n" +
                "Benvenuto nel software!");
            Console.WriteLine("Premi [un tasto] per far iniziare il programma.");
            Console.ReadKey();
            Console.Clear();

            int scelta = -1;

            string NomeV;
            string CognomeV;
            double StipendioV;
            int settoreV;
            int indiceOrdine;

            int idOrd;
            int sceltaInserisciVend = -1;
            int sceltaInserisciOrdine = -1;

            int index;

            Console.WriteLine("Inserisci un indice: ");
            index = Convert.ToInt32(Console.ReadLine());
            var scontrino = new List<Prodotto>();
            //var elencoScontrino = new Ordine(scontrino);

            Venditore venditore = new Venditore()
            {
                Nome = "Francesco",
                Cognome = "Cataldo",
                Settore = Settore.AUTO,
                Stipendio = 1920
            };

            Meccanico m1 = new Meccanico()
            {
                Nome = "Alessandro",
                Cognome = "Cataldo",
                Stipendio = 1500,
                Tipologia = Tipologia.CARROZZERIA
            };

            Meccanico m2 = new Meccanico()
            {
                Nome = "Paolo",
                Cognome = "Rossi",
                Stipendio = 1450,
                Tipologia = Tipologia.MECCANICA
            };

            
           
           
            var archivioVenditori = new List<Venditore>();
            var archivioMeccanici = new List<Meccanico>();

            var elencoMeccanici = new Meccanico(archivioMeccanici);

            var responsabileVenditori = new ResponsabileVenditori(archivioVenditori);

            archivioMeccanici.Add(m1);
            archivioMeccanici.Add(m2);

            var ordini = new List<Ordine>();
            var elencoOrdini = new CapoOfficina(ordini);

            var ordineOpzioni = new OrdineOpzioni(ordini);

            //var elencoOrdiniTEST = new List<Ordine>();
            var magazzino = new List<Prodotto>();



            Console.WriteLine("Vuoi inserire un altro venditore? [1 = SI | 2 = No]");
            sceltaInserisciVend = Convert.ToInt32(Console.ReadLine());
            if (sceltaInserisciVend == 1)
            {
                Console.WriteLine("\nInserisci il nome del venditore: ");
                NomeV = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome del venditore: ");
                CognomeV = Console.ReadLine();
                Console.WriteLine("Inserisci lo stipendio del venditore: ");
                StipendioV = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A quale settore appartiene? [AUTO = 0 | MOTO = 1]");
                settoreV = Convert.ToInt32(Console.ReadLine());
                if (settoreV == 0)
                    settoreV = (int)Settore.AUTO;
                else if (settoreV == 1)
                    settoreV = (int)Settore.MOTO;
                else
                    Console.WriteLine("Impossibile inserire un settore.....");
                Console.WriteLine(responsabileVenditori.AggiungiVenditoreInput(NomeV, CognomeV, StipendioV, settoreV));

            }
            else
                sceltaInserisciVend = 2;

            archivioVenditori.Add(venditore);
            //archivioVenditori.Add(venditore);

            ResponsabileVenditori r1 = new ResponsabileVenditori()
            {
                Nome = "Alessio",
                Cognome = "Cappello",
                Stipendio = 4000,
                Venditori = archivioVenditori
            };

            CapoOfficina cp1 = new CapoOfficina()
            {
                Nome = "Mister",
                Cognome = "Satan",
                Stipendio = 2500,
                Ordini = elencoOrdini.Ordini
            };

            var p1 = new Prodotto()
            {
                Codice = 1,
                Product = "Pasta",
                Descrizione = "Fusilli Barilla 1 kg",
                Prezzo = 2.95
            };

            Prodotto p2 = new Prodotto()
            {
                Codice = 2,
                Product = "Carne",
                Descrizione = "Hamburger di Ovino, 500 gr",
                Prezzo = 3.99
            };

            magazzino.Add(p1);
            
            //Ordini.Add((Ordine)p1);
            //elencoOrdini.Ordini.Add((Ordine)p1);
            //Ordini.Add((Ordine)p2);
            //elencoOrdini.AggiungiOrdine(p1, 3);
            //elencoOrdini.AggiungiOrdine((Ordine)p2, 4);
            //elencoOrdini.Ordini.Add((Ordine)p2);

            Ordine o1 = new Ordine()
            {
                IdOrdine = 1,
                Data = DateTime.Now,
                ElencoProdotti = magazzino,
                Venditore = archivioVenditori
            };

            magazzino.Add(p2);

            Ordine o2 = new Ordine()
            {
                IdOrdine = 2,
                Data = DateTime.Today,
                ElencoProdotti = magazzino,
                Venditore = archivioVenditori
            };

            elencoOrdini.AggiungiOrdine(o1, 0);
            elencoOrdini.AggiungiOrdine(o2, 1);

            do
            {
                Console.WriteLine("\nInserisci una scelta: ");
                Console.WriteLine("\n1 - Stampa l'elenco dei venditori.");
                Console.WriteLine("2 - Stampa l'elenco dei meccanici.");
                Console.WriteLine("3 - Inserisci un nuovo ordine o stampa l'archivio degli ordini gia' presenti.");
                Console.WriteLine("4 - Stampa dei dati del responsabile dei venditori.");
                Console.WriteLine("5 - Stampa dei dati del capo officina.");
                Console.WriteLine("6 - Stampa di un certo ordine.");
                Console.WriteLine("0 - Exit.\n");
                Console.Write("\nScelta: ");
                 scelta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (scelta)
                {
                    case 1:
                        foreach (Object obj in archivioVenditori)
                            Console.WriteLine(obj);
                            Console.WriteLine();
                        break;
                    case 2:
                        foreach (Object obj in archivioMeccanici)
                            Console.WriteLine(obj);
                            Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Vuoi inserire un altro ordine? [1 = SI | 2 = No]");
                        sceltaInserisciOrdine = Convert.ToInt32(Console.ReadLine());
                        if (sceltaInserisciOrdine == 1)
                        {
                            Console.WriteLine("\nInserisci l'ID dell'ordine: ");
                            idOrd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Inserisci [invio] per acquisire la data corrente: ");
                            DateTime data = DateTime.Now;
                            Console.WriteLine("{Aggiugni un venditore}");
                            Console.WriteLine("\nInserisci il nome del venditore: ");
                            NomeV = Console.ReadLine();
                            Console.WriteLine("Inserisci il cognome del venditore: ");
                            CognomeV = Console.ReadLine();
                            Console.WriteLine("Inserisci lo stipendio del venditore: ");
                            StipendioV = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("A quale settore appartiene? [AUTO = 0 | MOTO = 1]");
                            settoreV = Convert.ToInt32(Console.ReadLine());
                            if (settoreV == 0)
                                settoreV = (int)Settore.AUTO;
                            else if (settoreV == 1)
                                settoreV = (int)Settore.MOTO;
                            else
                                Console.WriteLine("Impossibile inserire un settore.....");
                            Console.WriteLine(responsabileVenditori.AggiungiVenditoreInput(NomeV, CognomeV, StipendioV, settoreV));

                            Ordine ordineNuovo = new Ordine()
                            {
                                IdOrdine = idOrd,
                                Data = data,
                                Venditore = archivioVenditori,
                                ElencoProdotti = magazzino
                            };
                            indiceOrdine = idOrd;
                            Console.WriteLine(elencoOrdini.AggiungiOrdine(ordineNuovo, indiceOrdine));
                        }
                        else
                            sceltaInserisciVend = 2;
                        Console.WriteLine(String.Join("\n\n", ordini));
                        Console.WriteLine("\n");
                        //Console.WriteLine(elencoScontrino.ProdottoToString(p1));
                        //Console.WriteLine(elencoScontrino.Scontrino(p1));
                        break;
                    case 4:
                        Console.WriteLine(r1.ToString());
                        break;
                    case 5:
                        Console.WriteLine("Nome: " + cp1.Nome);
                        Console.WriteLine("Cognome: " + cp1.Cognome);
                        Console.WriteLine("Stipendio: " + cp1.Stipendio);
                        Console.WriteLine("Tredicesima: : " + cp1.Tredicesima());
                        Console.WriteLine("Numero ordini: " + cp1.NoOrdini());
                        Console.WriteLine("Ordini:" + string.Join("-------------------------------------------------\n", ordini));
                        /*foreach (Object obj in ordini)
                        {
                            Console.WriteLine(obj);
                        }*/
                        break;
                    case 6:
                        Console.WriteLine("Inserisci l'ID dell'ordine che vuoi cercare: ");
                        Ordine ord = ordineOpzioni.RicercaOrdine(Convert.ToInt32(Console.ReadLine()));
                        if(ord != null)
                            Console.WriteLine(ord);
                        else
                            Console.WriteLine("\n{Ordine non trovato..}");
                        break;
                    case 0:
                        Console.WriteLine("Uscita in corso.....");
                        break;
                    default:
                        Console.WriteLine("Valore non corretto..");
                        break;
                }

            } while (scelta != 0);
        }
    }
}

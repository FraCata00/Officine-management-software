using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    enum Tipologia { CARROZZERIA, MECCANICA }
    class Meccanico : Persona
    {
        public Tipologia Tipologia { get; set; }
        public List<Meccanico> Elenco { get; set; }
        public Meccanico()
        {
            Elenco = new List<Meccanico>();
        }
        public Meccanico(List<Meccanico> elenco)
        {
            Elenco = elenco;
        }

        public override double Tredicesima()
        {
            return ((Stipendio * 93) / 100) + Stipendio;
        }
        public override bool Equals(object obj)
        {
            return obj is Meccanico meccanico &&
                   Nome == meccanico.Nome &&
                   Cognome == meccanico.Cognome &&
                   Stipendio == meccanico.Stipendio &&
                   Tipologia == meccanico.Tipologia;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return base.ToString() +
                $"\nTipologia: {Tipologia}";
        }
    }
}

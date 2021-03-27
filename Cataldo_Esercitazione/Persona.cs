using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Stipendio { get; set; }

        public abstract  double Tredicesima();
        public override string ToString()
        {
            return $"Nome: {Nome}" +
                $"\nCognome: {Cognome}" +
                $"\nStipendio: {Stipendio}" +
                $"\nTredicesima: {Tredicesima()}";

        }

    }
}

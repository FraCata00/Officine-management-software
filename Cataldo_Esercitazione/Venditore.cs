using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataldo_Esercitazione
{
    enum Settore { AUTO, MOTO }
    class Venditore : Persona
    {
        public Settore Settore { get; set; }

        public override double Tredicesima()
        {
            return ((Stipendio * 91) / 100) + Stipendio;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            Console.WriteLine();
            return base.ToString()+
                $"\nSettore: {Settore}";
        }
    }
}

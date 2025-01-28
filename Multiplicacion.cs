using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class Multiplicacion
    {
        public double Multiplicando { get; set; }
        public double Multiplicador { get; set; }
        public Multiplicacion(double multiplicando, double multiplicador)
        {
            Multiplicando = multiplicando;
            Multiplicador = multiplicador;
        }

        public Multiplicacion() { }

        public double Resultado()
        {
            return Multiplicando * Multiplicador;
        }
    }
}

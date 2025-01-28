using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class Division
    {
        public double Dividendo { get; set; }
        public double Divisor { get; set; }
        public Division(double dividendo, double divisor)
        {
            Dividendo = dividendo;
            Divisor = divisor;
        }

        public Division() { }

        public double Resultado()
        {
            if (!Divisor.Equals(0))
            {
                return Dividendo / Divisor;
            }
            else
            {
                throw new DivideByZeroException("No es posible dividir entre 0");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class NumeroPrimo
    {
        public int Dividendo { get; set; }

        private const int divisor = 2;
        private const int residuo = 0;
        public NumeroPrimo(int dividendo)
        {
            Dividendo = dividendo;
        }

        public NumeroPrimo() { }

        public bool EsPrimo()
        {

            if (Dividendo.Equals(2))
            {
                return true;
            }
            else if (Dividendo < divisor)
            {
                return false;
            }
            else if (Dividendo % divisor != residuo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

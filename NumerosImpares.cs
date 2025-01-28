using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class NumerosImpares
    {
        const int limite = 30;
        const int divisor = 2;
        const int residuo = 0;
        private List<int> numerosImpares = new List<int>();

        public List<int> NumerosImparesDelUnoAlTentra()
        {

            for (int inicio = 0; inicio < limite; inicio++)
            {
                if (inicio % divisor != residuo)
                {
                    numerosImpares.Add(inicio);
                }
            }

            return numerosImpares;
        }
    }
}

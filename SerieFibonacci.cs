using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class SerieFibonacci
    {
        const int limite = 50;
        private int sumado = 1;
        private List<int> numeros = new List<int>();

        public List<int> NumerosFibonacci()
        {

            for (int inicio = 0; inicio < limite; inicio++)
            {
                numeros.Add(inicio * sumado);
                sumado = inicio;
            }

            return numeros;
        }
    }
}

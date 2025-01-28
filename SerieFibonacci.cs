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
        private int variableY = 0;
        private int variableX = 1;
        private List<int> numeros = new List<int>();

        public List<int> NumerosFibonacci()
        {
            for (int inicio = 0; inicio < limite; inicio++)
            {
                numeros.Add(variableX + variableY);
                variableY = variableX;
                variableX = numeros[inicio];

                if (numeros[inicio] >=50)
                {
                    break;
                }
            }

            return numeros;
        }
    }
}

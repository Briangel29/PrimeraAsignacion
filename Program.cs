using System;

namespace PrimeraAsignacion
{
    public class CentroOperaciones
    {
        public static void Main(String[] args)
        {
            SerieFibonacci serie = new SerieFibonacci();

            foreach (var i in serie.NumerosFibonacci())
            {
                Console.WriteLine(i);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAsignacion
{
    public class EcuacionCuadratica
    {
        public double TerminoCuadratico { get; set; }
        public double TerminoLineal { get; set; }
        public double TerminoConstante { get; set; }

        public EcuacionCuadratica(double coeficienteA, double coeficienteB, double coeficienteC)
        {
            TerminoCuadratico = coeficienteA;
            TerminoLineal = coeficienteB;
            TerminoConstante = coeficienteC;
        }

        public EcuacionCuadratica() { }

        private bool TieneSoluciones()
        {
            if (TerminoCuadratico.Equals(0))
            {
                throw new ArgumentException("El coeficiente lineal no puede contener 0");
            }
            if (CalcularDiscriminante() >= 0)
            {
                return true;
            }
            return false;
        }

        private double CalcularDiscriminante()
        {
            const byte alCuadrado = 2;

            return Math.Sqrt(Math.Pow(TerminoLineal, alCuadrado) - (4 * TerminoCuadratico * TerminoConstante));
        }

        public (double? primeraRaiz, double? segundaRaiz) ObtenerRaiz()
        {
            if (TieneSoluciones() is false) return (null, null);

            double discriminante = CalcularDiscriminante();

            double primeraRaiz = (-TerminoLineal + discriminante) / (2 * TerminoCuadratico);
            double segundaRaiz = (-TerminoLineal - discriminante) / (2 * TerminoCuadratico);

            return (primeraRaiz, segundaRaiz);
        }

        public void Resultado()
        {
            (double?, double?) raiz = ObtenerRaiz();
            if (raiz.Item1 is not null && raiz.Item2 is not null)
            {
                Console.WriteLine("{0}, {1}", raiz.Item1, raiz.Item2);
            }
            else
            {
                Console.WriteLine("No tiene soluciones reales");
            }
        }

    }
}

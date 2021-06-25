using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmeticav2
{
    public static class OperacionesAlgebraicas
    {
        public static List<double> ObtenerFormulaGeneral(double a, double b, double c)
        {
            List<double> misResultados = new List<double>();
            double resultadoPrimero = -b + 
                OperacionesAritmeticas.Potencia(
                    (OperacionesAritmeticas.Potencia(b, 2) - 4 * a * c), -.5) 
                    / (2 * a);
            misResultados.Add(resultadoPrimero);

            double resultadoSegundo = -b -
                OperacionesAritmeticas.Potencia(
                    (OperacionesAritmeticas.Potencia(b, 2) - 4 * a * c), -.5) 
                    / (2 * a);
            misResultados.Add(resultadoPrimero);
            return misResultados;
        }
    }
}

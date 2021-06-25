using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmeticav2
{
    public static class OperacionesAritmeticas
    {
        static double resultado = 0;

        /// <summary>
        /// Funcion para sumar dos números.
        /// </summary>
        /// <param name="valorA">Primer numero a sumar.</param>
        /// <param name="valorB">Segundo numero a sumar.</param>
        /// <returns>La suma de los numeros.</returns>
        public static double Sumar(double valorA, double valorB)
        {
            resultado = 0;
            resultado = valorA + valorB;
            return resultado;
        }

        /// <summary>
        /// Funcion para sumar una lista de numeros.
        /// </summary>
        /// <param name="numeros">Lista contenedora de los numeros.</param>
        /// <returns>La suma de los numeros.</returns>
        public static double Sumar(List <double> numeros)
        {
            foreach (var item in numeros)
            {
                resultado = 0;
                resultado += item;
            }
            return resultado;
        }

        /// <summary>
        /// Funcion para restar dos numeros.
        /// </summary>
        /// <param name="valorA">Numero al que se le va a restar.</param>
        /// <param name="valorB">Cantidad que se resta.</param>
        /// <returns>La resta de los numeros.</returns>
        public static double Restar(double valorA, double valorB)
        {
            resultado = 0;
            resultado = valorA - valorB;
            return resultado;
        }

        /// <summary>
        /// Funcion para restar una lista de numeros. Se va restando en el orden en que se ordenaron los numeros.
        /// </summary>
        /// <param name="numeros">Lista contenedora de los numeros.</param>
        /// <returns>La resta de los numeros.</returns>
        public static double Restar(List<double> numeros)
        {
            foreach (var item in numeros)
            {
                resultado = 0;
                resultado -= item;
            }
            return resultado;
        }

        /// <summary>
        /// Funcion para multiplicar dos numeros.
        /// </summary>
        /// <param name="valorA">Primer numero a multiplicar.</param>
        /// <param name="valorB">Segundo numero a multiplicar.</param>
        /// <returns>La multiplicacion de los numeros.</returns>
        public static double Multiplicar(double valorA, double valorB)
        {
            resultado = 0;
            resultado = valorA * valorB;
            return resultado;
        }

        /// <summary>
        /// Funcion para multiplicar una lista de numeros.
        /// </summary>
        /// <param name="numeros">Lista contenedora de los numeros.</param>
        /// <returns>La multiplicacion de los numeros.</returns>
        public static double Multiplicar(List<double> numeros)
        {
            resultado = 0;
            foreach (var item in numeros)
            {

                resultado *= item;
            }
            return resultado;
        }

        /// <summary>
        /// Funcion para dividir dos numeros.
        /// </summary>
        /// <param name="valorA">Numerador.</param>
        /// <param name="valorB">Denominador.</param>
        /// <returns>La division de los numeros.</returns>
        public static double Dividir(double valorA, double valorB)
        {
            resultado = 0;
            if (valorB == 0)
            {
                throw new Exception("Error, division con resultado indefinido.");
            }
            else
            {
                resultado = valorA / valorB;
                return resultado;
            }
            
        }

        /// <summary>
        /// Funcion para dividir una lista de numeros. Se va dividiendo en el orden en que se añadieron los numeros.
        /// </summary>
        /// <param name="numeros">Lista contenedora de los numeros.</param>
        /// <returns>La division de los numeros.</returns>
        public static double Dividir(List<double> numeros)
        {
            resultado = 0;
            resultado = numeros[0];
            for (int i = 0; i <= numeros.Count; i++)
            {
                if (numeros[i] == 0)
                {
                    throw new Exception("Error, division con resultado indefinido.");
                    //resultado /= numeros[i];
                }
            }
            return resultado;
        }

        /// <summary>
        /// Funcion para sacar la n potencia de un numero.
        /// </summary>
        /// <param name="numero">Es el numero a potenciar.</param>
        /// <param name="potencia">Es la cantidad de veces a potenciar.</param>
        /// <returns>El valor resultante de haber potenciado el numero.</returns>
        public static double Potencia(double numero, double potencia)
        {
            double resultado = 0;
            resultado = numero;
            for (int i = 1; i <= potencia; i++)
            {
                resultado *= numero;
            }
            return numero;
        }

        /// <summary>
        /// Funcion para calcular la serie Fibonacci creada a partir de un numero dado.
        /// </summary>
        /// <param name="numero">El numero del que se crea la serie.</param>
        /// <returns>La serie Fibonacci a partir del valor dado.</returns>
        public static double SerieFibonacci(double numero)
        {
            if (numero > 0)
            {
                for (int i = 0; i < numero; i++)
                {

                }
            }
            return resultado;
        }

        /// <summary>
        /// Funcion para calcular la factorial de un numero.
        /// </summary>
        /// <param name="numero">El valor del cual se calcula la factorial.</param>
        /// <returns>La factorial del valor dado.</returns>
        public static double Factorial(double numero)
        {
            resultado = 0;
            double factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aritmeticav2
{
    public static class OperacionesGeometricas
    {
        const double PI = 3.1416;
        const double E = 2.71;

        /// <summary>
        /// Función para obtener el perimetro de un cuadrado.
        /// </summary>
        /// <param name="lado">Largo de los lados del cuadrado.</param>
        /// <returns>El perimetro del cuadrado.</returns>
        public static double ObtenerPerimetroCuadrado(double lado)
        {
            return OperacionesAritmeticas.Multiplicar(lado, 4);
        }

        public static double ObtenerPerimetroRectangulo(double largo, double ancho)
        {
            return OperacionesAritmeticas.Sumar(
                (OperacionesAritmeticas.Multiplicar(largo, 2)), (OperacionesAritmeticas.Multiplicar(ancho, 2)));
        }

        /// <summary>
        /// Función para obtener el perimetro de un triangulo.
        /// </summary>
        /// <param name="lado1">Largo del primer lado del triangulo.</param>
        /// <param name="lado2">Largo del segundo lado del triangulo</param>
        /// <param name="lado3">Largo del tercer lado del triangulo.</param>
        /// <returns>Perimetro del triangulo.</returns>
        public static double ObtenerPerimetroTriangulo(double lado1, double lado2, double lado3)
        {
            List<double> lados = new List<double>();
            lados.Add(lado1);
            lados.Add(lado2);
            lados.Add(lado3);

            return OperacionesAritmeticas.Sumar(lados);
        }

        /// <summary>
        /// Funcion para obtener el perimetro del circulo.
        /// </summary>
        /// <param name="radio">Largo del radio del circulo.</param>
        /// <returns>Perimetro del circulo.</returns>
        public static double ObtenerPerimetroCirculo(double radio)
        {
            return OperacionesAritmeticas.Multiplicar(OperacionesAritmeticas.Multiplicar(2, PI), radio);
        }

        /// <summary>
        /// Funcion para obtener el área del circulo.
        /// </summary>
        /// <param name="radio">Largo del radio del circulo.</param>
        /// <returns>Área del circulo.</returns>
        public static double ObtenerAreaCirculo(double radio)
        {
            return PI * OperacionesAritmeticas.Potencia(radio, 2);
        }

        // <summary>
        /// Función para obtener el área de un cuadrado.
        /// </summary>
        /// <param name="lado">Largo de los lados del cuadrado.</param>
        /// <returns>El área del cuadrado.</returns>
        public static double ObtenerAreaCuadrado(double lado)
        {
            return OperacionesAritmeticas.Potencia(lado, 2);
        }

        /// <summary>
        /// Función para obtener el área del triangulo.
        /// </summary>
        /// <param name="baseTriangulo">Largo de la base del triangulo.</param>
        /// <param name="altura">Altura del triangulo.</param>
        /// <returns>Área del triangulo.</returns>
        public static double ObtenerAreaTriangulo(double baseTriangulo, double altura)
        {
            return
                OperacionesAritmeticas.Dividir(
                    OperacionesAritmeticas.Multiplicar(baseTriangulo, altura), 2);
        }

        /// <summary>
        /// Función para obtener el área del rectangulo.
        /// </summary>
        /// <param name="longitud">Longitud del rectangulo.</param>
        /// <param name="ancho">Ancho del rectangulo.</param>
        /// <returns>Área del rectangulo.</returns>
        public static double ObtenerAreaRectangulo(double longitud, double ancho)
        {
            return OperacionesAritmeticas.Multiplicar(longitud, ancho);
        }

        /// <summary>
        /// Funcion para obtener el área del paralelogramo.
        /// </summary>
        /// <param name="baseParalelogramo">Largo de la base del paralelogramo.</param>
        /// <param name="altura">Altura del paralelogramo.</param>
        /// <returns>Área del paralelogramo.</returns>
        public static double ObtenerAreaParalelogramo(double baseParalelogramo, double altura)
        {
            return OperacionesAritmeticas.Multiplicar(baseParalelogramo, altura);
        }

        /// <summary>
        /// Función para obtener la hipotenusa del triangulo rectangulo.
        /// </summary>
        /// <param name="catetoAdyacente">Longitud del cateto adyacente.</param>
        /// <param name="catetoOpuesto">Longitud del cateto opuesto.</param>
        /// <returns>Longitud de la hipotenusa.</returns>
        public static double OptenerHipotenusa(double catetoAdyacente, double catetoOpuesto)
        {
            double resultado = OperacionesAritmeticas.Potencia(
                OperacionesAritmeticas.Potencia(catetoAdyacente, 2) +
                OperacionesAritmeticas.Potencia(catetoOpuesto, 2), 0.5);
            return resultado;
        }

        public static double ObtenerCatetoAdyacente(double hipotenusa, double catetoOpuesto)
        {
            double resultado = OperacionesAritmeticas.Potencia(
                OperacionesAritmeticas.Potencia(hipotenusa, 2) -
                OperacionesAritmeticas.Potencia(catetoOpuesto, 2), 0.5);
            return resultado;
        }

        public static double ObtenerCatetoOpuesto(double hipotenusa, double catetoAdyacente)
        {
            double resultado = OperacionesAritmeticas.Potencia(
                    OperacionesAritmeticas.Potencia(hipotenusa, 2) -
                    OperacionesAritmeticas.Potencia(catetoAdyacente, 2), 0.5);
            return resultado;
        }

        public static double ObtenerVolumenCubo(double longitudLado)
        {
            return OperacionesAritmeticas.Potencia(longitudLado, 3);
        }

        public static double ObtenerVolumenPrismaRectangular(double largo, double ancho, double altura)
        {
            List<double> dimensiones = new List<double>();
            dimensiones.Add(largo);
            dimensiones.Add(ancho);
            dimensiones.Add(altura);

            return OperacionesAritmeticas.Multiplicar(dimensiones);

        }

        public static double ObtenerVolumenPrisma(double area, double altura)
        {
            return OperacionesAritmeticas.Multiplicar(area, altura);
        }

        public static double ObtenerVolumenPiramide(double area, double altura)
        {
            return OperacionesAritmeticas.Dividir(
                    OperacionesAritmeticas.Multiplicar(area, altura), 3);
        }

        public static double ObtenerVolumenEsfera(double radio)
        {
            List<double> elementos = new List<double>();
            elementos.Add(PI);
            elementos.Add(OperacionesAritmeticas.Potencia(radio, 3));
            elementos.Add(OperacionesAritmeticas.Dividir(4, 3));

            return OperacionesAritmeticas.Multiplicar(elementos);
        }
    }
}

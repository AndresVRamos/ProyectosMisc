using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetodosCajaRegistradora
{
    public static class MetodosCaja
    {
        static double resultado;

        public static double calcularIVA(double pago)
        {
            resultado = 0;
            resultado = pago * 0.16;
            return resultado;
        }

        public static double calcularSubtotal(List<double> cantidad)
        {
            resultado = 0;
            foreach (var item in cantidad)
            {
                resultado = resultado + item;
            }
            resultado = resultado - calcularIVA(resultado);
            return resultado + calcularIVA(resultado);
        }

        public static double calcularTotal(double subtotal, double iva)
        {
            resultado = 0;
            resultado = subtotal + iva;
            return resultado;
        }

        public static double metodoPago(double monto, double total)
        {
            resultado = monto - total;
            return resultado;
        }


    }
}

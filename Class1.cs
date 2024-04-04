using Monedas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    internal class Moneda
    {
        int Moneda1 = 100;
        int Moneda2 = 20;
        int Moneda3 = 10;
        int Moneda4 = 5;
        int Moneda5 = 1;

        public void calcularMonedas()
        {
            Console.WriteLine("Ingresar Valor del producto");
            var V = Console.ReadLine();
            var valor = int.Parse(V);
            Console.WriteLine("Ingresar pago");
            var p = Console.ReadLine();
            int pago = int.Parse(p);

            while (true)
            {
                if (pago < valor)
                {
                    Console.WriteLine("Ingresar pago");
                    p = Console.ReadLine();
                    pago = int.Parse(p);
                }
                else break;
            }
            Console.WriteLine("Monto a pagar " + valor);
            Console.WriteLine("Se paga con " + pago);

            int cambio = pago - valor;

            int Cantmonedas100 = cambio / Moneda1;
            cambio %= Moneda1;

            int Cantmonedas20 = cambio / Moneda2;
            cambio %= Moneda2;

            int Cantmonedas10 = cambio / Moneda3;
            cambio %= Moneda3;

            int Cantmonedas5 = cambio / Moneda4;
            cambio %= Moneda4;

            int Cantmonedas1 = cambio / Moneda5;


            Console.WriteLine("Vuelto con: " + Cantmonedas100 + " monedas de 100," + Cantmonedas20 + " Monedas de 20," + Cantmonedas10 + " monedas de 10," + Cantmonedas5 + " Monedas de 5 y " + Cantmonedas1 + " Monedas de 1");

        }
    } 
}

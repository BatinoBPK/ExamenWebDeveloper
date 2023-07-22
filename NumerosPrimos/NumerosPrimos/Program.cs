using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor mínimo del rango:");
            int valorMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor máximo del rango:");
            int valorMaximo = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números primos en ese rango son:");

            for (int numero = valorMinimo; numero <= valorMaximo; numero++)
            {
                if (EsPrimo(numero))
                {
                    Console.Write(numero + " ");
                }
            }
            Console.Write("\n");
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
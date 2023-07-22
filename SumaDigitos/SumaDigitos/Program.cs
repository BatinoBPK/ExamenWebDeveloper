using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número entero y te regresaré la suma de sus dígitos:");
            int valor = int.Parse(Console.ReadLine());

            int suma = SumaDigitos(valor);

            Console.WriteLine("La suma es igual a " + suma);
        }

        static int SumaDigitos(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                suma += numero % 10; 
                numero /= 10; 
            }

            return suma;
        }
    }
}

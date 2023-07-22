using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cuántos números quieres de la secuencia Fibonacci");
            int n = Convert.ToInt32(Console.ReadLine());

            NumerosFibonacci(n);
        }

        static void NumerosFibonacci(int n)
        {
            int primerNumero = 0;
            int segundoNumero = 1;

            Console.WriteLine("Estos son los primeros " + n + " números de la secuencia:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(primerNumero + " ");

                int resultadoParcial = primerNumero + segundoNumero;
                primerNumero = segundoNumero;
                segundoNumero = resultadoParcial;
            }

            Console.WriteLine();
        }
    }
}

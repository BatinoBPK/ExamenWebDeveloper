using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarPalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase:");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');
            Array.Sort(palabras);

            Console.WriteLine();
            Console.WriteLine("Esta es tu frase pero con las palabras ordenadas alfabeticamente:");
            foreach (string palabra in palabras)
            {
                Console.Write(palabra + " ");
            }
            Console.WriteLine();
        }
    }
}
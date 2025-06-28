using System;
using System.Collections.Generic;

namespace Semana05
{
    internal class Ejercicio4
    {
        public static void LoteriaOrdenada()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine("Introduce 6 números ganadores de la lotería:");

            while (numeros.Count < 6)
            {
                Console.Write($"Número {numeros.Count + 1}: ");
                string? entrada = Console.ReadLine();
                if (entrada != null && int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }

            numeros.Sort();
            Console.WriteLine("Números ordenados:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();
        }
    }
}

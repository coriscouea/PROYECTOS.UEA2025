using System;
using System.Collections.Generic;

namespace Semana05
{
    internal class Ejercicio6
    {
        public static void MostrarAsignaturasReprobadas()
        {
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Dictionary<string, double> notas = new Dictionary<string, double>();

            Console.WriteLine("Ejercicio 6:");
            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Nota en {asignatura}: ");
                string? entrada = Console.ReadLine();
                if (entrada == null)
                {
                    notas[asignatura] = 0;
                }
                else if (double.TryParse(entrada, out double nota))
                {
                    notas[asignatura] = nota;
                }
                else
                {
                    notas[asignatura] = 0;
                }
            }

            asignaturas.RemoveAll(asig => notas[asig] >= 7);

            Console.WriteLine("\nDebes repetir:");
            foreach (var asig in asignaturas)
            {
                Console.WriteLine(asig);
            }
            Console.WriteLine();
        }
    }
}

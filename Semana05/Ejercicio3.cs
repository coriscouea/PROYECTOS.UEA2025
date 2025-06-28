using System;
using System.Collections.Generic;

namespace Semana05
{
    internal class Ejercicio3
    {
        public static void PedirNotas()
        {
            List<string> asignaturas = new List<string>
            {
                "Matemáticas",
                "Lengua",
                "Ciencias",
                "Historia",
                "Geografía"
            };
            Dictionary<string, double> notas = new Dictionary<string, double>();

            Console.WriteLine("Ejercicio 3");
            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Ingrese la nota de {asignatura}: ");
                string input = Console.ReadLine()!;
                if (input != null && double.TryParse(input, out double nota))

                {
                    notas[asignatura] = nota;
                }
                else
                {
                    notas[asignatura] = 0; // Asignar 0 si la entrada no es un número válido
                }
            }

            // Mostrar las notas ingresadas
            Console.WriteLine("\nNotas ingresadas:");
            foreach (var par in notas)
            {
                Console.WriteLine($"{par.Key}: Has sacado {par.Value} puntos");
            }
            Console.WriteLine();
        }
    }
}
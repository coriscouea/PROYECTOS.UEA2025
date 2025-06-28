using System;
using System.Collections.Generic;

namespace Semana05
{
    internal class Ejercicio2
    {
        public static void MostrarAsignaturasConMensaje()
        {
            // Crear una lista de asignaturas
            List<string> asignaturas = new List<string>
            {
                "Matemáticas",
                "Lengua",
                "Ciencias",
                "Historia",
                "Geografía"
            };

            // Mostrar las asignaturas con un mensaje
            Console.WriteLine("Ejercicio 2:");
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio: {asignatura}");

            }
            Console.WriteLine();
        }
    }
}
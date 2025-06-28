using System;   
using System.Collections.Generic;

namespace Semana05
{
    internal class Ejercicio1
    {
        public static void MostrarAsignaturas()
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

            // Mostrar las asignaturas
            Console.WriteLine("Ejercicio 1:");
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"- {asignatura}");
                }
            }
        }
    }
        
using System;
using ListasEnlazadas.Ejercicios;// Ejercicios de listas enlazadas

namespace ListasEnlazadas// Namespace principal para los ejercicios de listas enlazadas
{
    internal class Program// Clase principal del programa
    // Contiene el método Main que ejecuta los ejercicios
    {
        private static void Main(string[] args)// Método Main que se ejecuta al iniciar el programa
        // Muestra un menú de ejercicios y permite al usuario elegir qué ejercicio ejecutar
        {
            Console.WriteLine("Ejercicios de Listas Enlazadas\n");
            Console.WriteLine("==============================\n");

            Ejercicio3.Ejecutar();// Ejecutar el ejercicio 3: Búsqueda en lista enlazada
            Console.WriteLine("==============================\n");
            Ejercicio4.Ejecutar();// Ejecutar el ejercicio 4: Filtrar una lista enlazada por un rango de valores
            Console.WriteLine("==============================\n");

            // Terminar el programa
            Console.WriteLine("Programa finalizado. Presione una tecla para salir...");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}

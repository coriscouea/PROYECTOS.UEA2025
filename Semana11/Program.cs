using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"tiempo", "Time"},
        {"persona", "Person"},
        {"año", "Year"},
        {"camino / forma", "Way"},
        {"día", "Day"},
        {"ojo", "eye"},
        {"hombre", "Man"},
        {"mundo", "World"},
        {"vida", "Life"},

    };

    static void Main()
    {

        while (true)
        {

            Console.WriteLine("\n=== Traductor Básico Español-Inglés ===");
            Console.WriteLine("1. Traducir la frase");
            Console.WriteLine("2. Agregar palabra al diccionario");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción (1-3): ");

            string option = Console.ReadLine() ?? "3";

            if (option == "1")

                TraducirFrase(diccionario);

            else if (option == "2")

                AgregarPalabra(diccionario);

            else if (option == "3")

                break;

            else

                Console.WriteLine("Opción no válida. Intente de nuevo.");

        }
    }
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la frase en español: ");
        string frase = Console.ReadLine()?.ToLower() ?? "";

        // Dividir la frase en palabras usando Regex para manejar puntuación
        string[] palabras = Regex.Split(frase, @"(\W+)");

        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i].ToLower();// Convertir a minúsculas para la búsqueda
            if (diccionario.ContainsKey(palabra))
            {
                palabras[i] = diccionario[palabra]; // Reemplazar con la traducción
            }
            // Si la palabra no está en el diccionario, se deja igual
        }
        string fraseTraducida = string.Join("", palabras); // Unir las palabras de nuevo en una frase 
        Console.WriteLine($"Frase traducida: {fraseTraducida}");
    }
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en español: ");
        string palabraEsp = (Console.ReadLine() ?? "").Trim().ToLower(); // Eliminar espacios en blanco y convertir a minúsculas

        Console.Write("Ingrese la traducción en inglés: ");
        string palabraEng = (Console.ReadLine() ?? "").Trim();

        if (!string.IsNullOrWhiteSpace(palabraEsp) && !string.IsNullOrWhiteSpace(palabraEng))
        {
            diccionario[palabraEsp] = palabraEng; // Agregar o actualizar la palabra en el diccionario
            Console.WriteLine($"Palabra '{palabraEsp}' agregada/actualizada con la traducción '{palabraEng}'.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ambas palabras no pueden estar vacias.");
        }
    }
}

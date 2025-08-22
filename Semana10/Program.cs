using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Crear un conjunto de 500 ciudadanos
        HashSet<string> totalCiudadanos = new HashSet<string>();

        // Agregar 500 ciudadanos al conjunto
        for (int i = 1; i <= 500; i++)

            totalCiudadanos.Add("Ciudadano:" + i);

        //Crear un conjunto de 75 ciudadanos Vacunados con Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();

        // Agregar 75 ciudadanos vacunados con Pfizer
        for (int i = 1; i <= 75; i++)

            vacunadosPfizer.Add("Ciudadano:" + i);

        // Crear un conjunto de 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();

        // Agregar 75 ciudadanos vacunados con AstraZeneca
        for (int i = 76; i <= 150; i++)

            vacunadosAstraZeneca.Add("Ciudadano:" + i);


        //Operaciones con conjuntos 
        var noVacunados = new HashSet<string>(totalCiudadanos);
        noVacunados.ExceptWith(vacunadosPfizer.Union(vacunadosAstraZeneca));

        var ambosVacunados = new HashSet<string>(vacunadosPfizer);
        ambosVacunados.UnionWith(vacunadosAstraZeneca);

        var soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        var soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        //Detalles de la vacunación
        Console.WriteLine("\n=== Detalles Macro de la vacunación ===");
        Console.WriteLine($"\nTotal de ciudadanos: {totalCiudadanos.Count}");
        Console.WriteLine($"Ciudadanos vacunados con Pfizer: {vacunadosPfizer.Count}");
        Console.WriteLine($"Ciudadanos vacunados con AstraZeneca: {vacunadosAstraZeneca.Count}");
        Console.WriteLine($"Ciudadanos vacunados con ambas vacunas: {ambosVacunados.Count}");
        Console.WriteLine($"Ciudadanos no vacunados: {noVacunados.Count}");

        //Resultados por consola
        Console.WriteLine("\n=== Detalles de la vacunación por ciudadano ===");
        Console.WriteLine("\n=== Ciudadanos no vacunados ===");
        Console.WriteLine(string.Join(", ", noVacunados));

        Console.WriteLine("\n=== Ciudadanos vacunados con ambas vacunas ===");
        Console.WriteLine(string.Join(", ", ambosVacunados));

        Console.WriteLine("\n=== Ciudadanos vacunados solo con Pfizer ===");
        Console.WriteLine(string.Join(", ", soloPfizer));

        Console.WriteLine("\n=== Ciudadanos vacunados solo con AstraZeneca ===");
        Console.WriteLine(string.Join(", ", soloAstraZeneca));
    }            
}

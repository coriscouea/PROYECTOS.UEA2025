using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Crear un conjunto de 500 ciudadanos
        HashSet<string> totalCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        
            totalCiudadanos.Add("Ciudadano:" + i);

        // Crear objeto Random
        Random random = new Random();

        // Crear 75 ciudadanos vacunados con Pfizer (aleatorios)
        HashSet<string> vacunadosPfizer = GenerarVacunados("Ciudadano:", 75, 500, random);

        // Crear 75 ciudadanos vacunados con AstraZeneca (aleatorios)
        HashSet<string> vacunadosAstraZeneca = GenerarVacunados("Ciudadano:", 75, 500, random);

        // ================= Operaciones con conjuntos =================
        var noVacunados = new HashSet<string>(totalCiudadanos);
        noVacunados.ExceptWith(vacunadosPfizer.Union(vacunadosAstraZeneca));

        var ambosVacunados = new HashSet<string>(vacunadosPfizer);
        ambosVacunados.IntersectWith(vacunadosAstraZeneca);

        var vacunadosCualquiera = new HashSet<string>(vacunadosPfizer);
        vacunadosCualquiera.UnionWith(vacunadosAstraZeneca);

        var soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        var soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // ================= Reporte =================
        Console.WriteLine("\n=== Detalles Macro de la vacunación ===");

        Console.WriteLine("\n====PRIMER CORTE====");
        Console.WriteLine($"Total de ciudadanos: {totalCiudadanos.Count}");
        Console.WriteLine($"Ciudadanos vacunados con Pfizer: {vacunadosPfizer.Count}");
        Console.WriteLine($"Ciudadanos vacunados con AstraZeneca: {vacunadosAstraZeneca.Count}");

        Console.WriteLine("\n====SEGUNDO CORTE====");
        Console.WriteLine($"Ciudadanos no vacunados: {noVacunados.Count}");
        Console.WriteLine($"Ciudadanos vacunados con ambas vacunas: {ambosVacunados.Count}");
        Console.WriteLine($"Ciudadanos vacunados solo con Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Ciudadanos vacunados solo con AstraZeneca: {soloAstraZeneca.Count}");

        Console.WriteLine("\n====TERCER CORTE====");
        Console.WriteLine($"Ciudadanos vacunados con al menos una vacuna: {vacunadosCualquiera.Count}");

        // Resultados por consola
        Console.WriteLine("\n=== Detalles de la vacunación por ciudadano ==="); ;
        Console.WriteLine("\n=== Ciudadanos no vacunados ===");
        Console.WriteLine(string.Join(", ", noVacunados));

        Console.WriteLine("\n=== Ciudadanos vacunados con ambas vacunas ===");
        Console.WriteLine(string.Join(", ", ambosVacunados));

        Console.WriteLine("\n=== Ciudadanos vacunados solo con Pfizer ===");
        Console.WriteLine(string.Join(", ", soloPfizer));

        Console.WriteLine("\n=== Ciudadanos vacunados solo con AstraZeneca ===");
        Console.WriteLine(string.Join(", ", soloAstraZeneca));

        Console.WriteLine("\n=== Ciudadanos vacunados con al menos una vacuna ===");
        Console.WriteLine(string.Join(", ", vacunadosCualquiera));
        
    }

    // Método auxiliar para generar vacunados aleatoriamente
    static HashSet<string> GenerarVacunados(string prefijo, int cantidad, int maximo, Random random)
    {
        return Enumerable.Range(1, maximo)
            .OrderBy(_ => random.Next())
            .Take(cantidad)
            .Select(i => prefijo + i)
            .ToHashSet();
    }
}

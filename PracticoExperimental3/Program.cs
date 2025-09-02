using System;
using System.Collections.Generic;

namespace AplicacionDeRegistroDeJugadoresYEquipos
{
    class Program
    {
        // Diccionario principal: equipo - conjunto de jugadores
        static Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);

        static void Main(string[] args)
        {
            InicializarDatos();

            int opcion;
            do
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                string input = Console.ReadLine() ?? "";
                if (!int.TryParse(input, out opcion)) // Validación de entrada
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }
                switch (opcion)  // Selección de opción del menú
                {
                    case 1: MenuAgregarJugador(); break;
                    case 2: MenuMostrarJugadoresEquipo(); break;
                    case 3: MostrarTodosLosEquipos(); break;
                    case 4: ReporteResumen(); break;
                    case 0: Console.WriteLine("Saliendo del programa..."); break;
                    default: Console.WriteLine("Opción no válida. Intente de nuevo."); break;
                }
            } while (opcion != 0);
        }

        // --- Menú ---
        static void MostrarMenu()
        {
            Console.WriteLine("\n=== Menú de Registro de Jugadores y Equipos ===");
            Console.WriteLine("1. Agregar Jugador a un Equipo");
            Console.WriteLine("2. Mostrar Jugadores de un Equipo");
            Console.WriteLine("3. Mostrar Todos los Equipos");
            Console.WriteLine("4. Reporte Resumen");
            Console.WriteLine("0. Salir");
            Console.WriteLine("===============================================");
        }

        // --- Agregar jugador ---
        static void MenuAgregarJugador()
        {
            Console.Write("Ingrese el Nombre del Equipo: ");
            string equipo = Console.ReadLine()?.Trim() ?? "";
            Console.Write("Ingrese el Nombre del Jugador: ");
            string jugador = Console.ReadLine()?.Trim() ?? "";

            AgregarJugador(equipo, jugador);
        }

        // Agrega un jugador a un equipo, validando que no existan duplicados
        static void AgregarJugador(string equipo, string jugador)
        {
            if (string.IsNullOrWhiteSpace(equipo) || string.IsNullOrWhiteSpace(jugador))
            {
                Console.WriteLine("El nombre del equipo y del jugador no pueden estar vacíos.");
                return;
            }

            if (!equipos.ContainsKey(equipo))
            {
                equipos[equipo] = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            }

            if (equipos[equipo].Add(jugador))
            {
                Console.WriteLine($"Jugador '{jugador}' agregado al equipo '{equipo}'.");
            }
            else
            {
                Console.WriteLine($"El jugador '{jugador}' ya está registrado en el equipo '{equipo}'.");
            }
        }

        // --- Mostrar jugadores de un equipo específico ---
        static void MenuMostrarJugadoresEquipo()
        {
            Console.Write("Ingrese el Nombre del Equipo: ");
            string equipo = Console.ReadLine()?.Trim() ?? "";
            MostrarJugadoresEquipo(equipo);
        }

        static void MostrarJugadoresEquipo(string equipo)
        {
            if (equipos.ContainsKey(equipo))
            {
                Console.WriteLine($"\nJugadores en el equipo '{equipo}':");
                foreach (var jugador in equipos[equipo])
                {
                    Console.WriteLine($"- {jugador}");
                }
            }
            else
            {
                Console.WriteLine($"El equipo '{equipo}' no existe.");
            }
        }

        // --- Mostrar todos los equipos ---
        static void MostrarTodosLosEquipos()
        {
            if (equipos.Count == 0)
            {
                Console.WriteLine("No hay equipos registrados.");
            }
            else
            {
                Console.WriteLine("\nEquipos registrados:");
                foreach (var kvp in equipos)
                {
                    Console.WriteLine($"- {kvp.Key} (Jugadores: {kvp.Value.Count})");
                }
            }
        }

        // --- Reporte resumen ---
        static void ReporteResumen()
        {
            int totalEquipos = equipos.Count;
            int totalJugadores = 0;
            int equipoMaxJugadores = 0;
            string nombreEquipoMax = "N/A";

            foreach (var kvp in equipos)
            {
                totalJugadores += kvp.Value.Count;
                if (kvp.Value.Count > equipoMaxJugadores)
                {
                    equipoMaxJugadores = kvp.Value.Count;
                    nombreEquipoMax = kvp.Key;
                }
            }
            Console.WriteLine("\n=== Reporte Resumen ===");
            Console.WriteLine($"Total de Equipos: {totalEquipos}");
            Console.WriteLine($"Total de Jugadores: {totalJugadores}");
            Console.WriteLine($"Equipo con más jugadores: {nombreEquipoMax} ({equipoMaxJugadores} jugadores)");
            Console.WriteLine("=======================");
        }

        // --- Inicialización con datos de ejemplo ---
        static void InicializarDatos()
        {
            AgregarJugador("RealMadrid", "Juan Pérez");
            AgregarJugador("RealMadrid", "Luis Gómez");
            AgregarJugador("RealMadrid", "Juan Pérez"); // Duplicado, no se añade

            AgregarJugador("Barcelona", "Carlos Sánchez");
            AgregarJugador("Barcelona", "Ana Martínez");

            AgregarJugador("Sevilla", "María Rodríguez");
            AgregarJugador("Sevilla", "Pedro López");

            AgregarJugador("Valencia", "Lucía Fernández");
            AgregarJugador("Valencia", "Miguel Torres");

            AgregarJugador("Villaroel", "Cesar Villaroel");
            AgregarJugador("Villaroel", "Ana Martínez"); // Nombre repetido en diferente equipo
            AgregarJugador("Villaroel", "Cesar Risco");
        }
    }
}

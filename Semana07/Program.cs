using System;

class Program// Clase principal
{
    static void Main()// Método principal
    {
        while (true)// Bucle infinito para mostrar el menú repetidamente
        {
            Console.WriteLine("Seleccione una opción:");// Mostrar opciones al usuario
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Verificar paréntesis balanceados");// Opción para verificar paréntesis
            Console.WriteLine("2. Resolver Torre de Hanói");// Opción para resolver Torre de Hanói
            Console.WriteLine("3. Salir");// Opción para salir del programa
            Console.WriteLine("----------------------------------");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")// Verificar paréntesis balanceados
            {
                VerificadorParentesis.Verificar();// Llamar al método para verificar paréntesis
            }
            else if (opcion == "2")// Resolver Torre de Hanói
            {
                TorresDeHanoi.Ejecutar();// Llamar al método para resolver Torre de Hanói
            }
            else if (opcion == "3")// Salir del programa
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.\n");// Informar al usuario que la opción no es válida
            }

            Console.WriteLine(); // Espacio en blanco para mejorar la legibilidad
        }
    }
}

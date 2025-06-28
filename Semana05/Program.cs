using System;

namespace Semana05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios de Listas y Tuplas Semana 5\n");
            Console.WriteLine("==============================\n");

            Ejercicio1.MostrarAsignaturas();
            Console.WriteLine("================================\n");
            Ejercicio2.MostrarAsignaturasConMensaje();
            Console.WriteLine("================================\n");
            Ejercicio3.PedirNotas();
            Console.WriteLine("================================\n");
            Ejercicio4.LoteriaOrdenada();
            Console.WriteLine("================================\n");
            Ejercicio6.MostrarAsignaturasReprobadas();
            Console.WriteLine("================================\n");
        }
    }
}

using System;
using System.Collections.Generic;

public static class TorresDeHanoi// Clase para resolver el problema de las Torres de Hanói
{
    public static void Ejecutar()// Método para iniciar la resolución de las Torres de Hanói
    {
        Console.Write("\nIngrese el número de discos: ");// Solicitar al usuario el número de discos
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)// Validar la entrada del usuario
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Stack<int> torreA = new Stack<int>();// Pila para la Torre A
        Stack<int> torreB = new Stack<int>();// Pila para la Torre B
        Stack<int> torreC = new Stack<int>();// Pila para la Torre C   

        for (int i = n; i >= 1; i--)// Llenar la Torre A con discos numerados
        {
            torreA.Push(i);// Agregar discos a la Torre A
        }

        Console.WriteLine("\nMovimientos para resolver la Torre de Hanói:");// Mostrar los movimientos necesarios para resolver el problema
        Resolver(n, torreA, torreC, torreB, "A", "C", "B");// Llamar al método para resolver la Torre de Hanói
    }

    private static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                                 string nombreOrigen, string nombreDestino, string nombreAuxiliar)// Método recursivo para resolver las Torres de Hanói
    {
        if (n > 0)// Si hay discos para mover
        {
            Resolver(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);// Mover n-1 discos de la Torre de origen a la Torre auxiliar

            int disco = origen.Pop();// Sacar el disco superior de la Torre de origen
            destino.Push(disco);// Mover el disco a la Torre de destino
            Console.WriteLine($"Mover disco {disco} de Torre {nombreOrigen} a Torre {nombreDestino}");// Mostrar el movimiento realizado

            Resolver(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);// Mover los n-1 discos de la Torre auxiliar a la Torre de destino
        }
    }
}

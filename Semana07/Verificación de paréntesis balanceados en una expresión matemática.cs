using System;
using System.Collections.Generic;

public static class VerificadorParentesis// Clase para verificar paréntesis balanceados en una expresión matemática
{
    public static void Verificar()// Método para iniciar la verificación de paréntesis balanceados
    {
        Console.WriteLine("\nIngrese una expresión matemática:");// Solicitar al usuario que ingrese una expresión matemática
        string input = Console.ReadLine();// Leer la entrada del usuario

        if (EsBalanceada(input))// Verificar si la expresión tiene paréntesis balanceados
        {
            Console.WriteLine("La expresión está balanceada.");// Informar al usuario que la expresión está balanceada
        }
        else
        {
            Console.WriteLine("La expresión no está balanceada.");// Informar al usuario que la expresión no está balanceada
        }

        Console.WriteLine("La expresión ingresada es: " + input);// Mostrar la expresión ingresada por el usuario
    }

    private static bool EsBalanceada(string expresion)// Método para verificar si los paréntesis en la expresión están balanceados
    {
        Stack<char> pila = new Stack<char>();// Pila para almacenar los paréntesis abiertos

        foreach (char c in expresion)// Recorrer cada carácter de la expresión
        {
            if (c == '(' || c == '{' || c == '[')// Si el carácter es un paréntesis abierto
            {
                pila.Push(c);// Agregar el paréntesis abierto a la pila
            }
            else if (c == ')' || c == '}' || c == ']')// Si el carácter es un paréntesis cerrado
            {
                if (pila.Count == 0) return false;// Si la pila está vacía, significa que hay un paréntesis cerrado sin su correspondiente abierto

                char top = pila.Pop();// Sacar el paréntesis abierto del tope de la pila
                if (!EsParCorrespondiente(top, c))// Verificar si el paréntesis abierto corresponde al paréntesis cerrado
                {
                    return false;// Si no corresponde, la expresión no está balanceada
                }
            }
        }

        return pila.Count == 0;// Al final, la pila debe estar vacía si todos los paréntesis están balanceados
    }

    private static bool EsParCorrespondiente(char apertura, char cierre)// Método para verificar si un par de paréntesis corresponde entre sí
    {
        return (apertura == '(' && cierre == ')') ||// Verificar si el paréntesis abierto y cerrado corresponden
               (apertura == '{' && cierre == '}') ||// Verificar si el paréntesis abierto y cerrado corresponden
               (apertura == '[' && cierre == ']');// Verificar si el paréntesis abierto y cerrado corresponden
    }
}

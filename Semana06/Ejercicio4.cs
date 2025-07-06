using System;
// Ejercicio 4: Filtrar una lista enlazada por un rango de valores.

namespace ListasEnlazadas.Ejercicios
{
    public static class Ejercicio4
    {
        private class Nodo// Clase que representa un nodo de la lista enlazada
        // Contiene un valor entero y una referencia al siguiente nodo
        {
            public int Valor { get; set; }

            public Nodo? Siguiente { get; set; }
            // Constructor para inicializar el nodo con un valor

            public Nodo(int valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        private class ListaEnlazada
        // Clase que representa una lista enlazada simple
        {
            private Nodo? cabeza = null;
            // Nodo que representa el inicio de la lista

            public void Agregar(int valor)
            // Método para agregar un nuevo nodo al final de la lista
            {
                Nodo nuevo = new Nodo(valor);
                if (cabeza == null)
                {
                    cabeza = nuevo;
                }
                else
                {
                    Nodo? actual = cabeza;
                    while (actual?.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    if (actual != null)
                    {
                        actual.Siguiente = nuevo;
                    }
                }
            }

            public void EliminarFueraDeRango(int min, int max)
            {
                // Eliminar nodos al inicio que estén fuera del rango
                while (cabeza != null && (cabeza.Valor < min || cabeza.Valor > max))
                {
                    cabeza = cabeza.Siguiente;
                }

                if (cabeza == null) return;

                Nodo? actual = cabeza;

                while (actual?.Siguiente != null)// Recorrer la lista
                // y eliminar nodos que estén fuera del rango
                {
                    if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
                    {
                        actual.Siguiente = actual.Siguiente.Siguiente;
                    }
                    else
                    {
                        actual = actual.Siguiente;
                    }
                }
            }

            public void Mostrar()// Método para mostrar los valores de la lista
            // en una sola línea, separando cada 10 elementos con un salto de línea
            {
                Nodo? actual = cabeza;
                int contador = 0;
                while (actual != null)
                {
                    Console.Write(actual.Valor + " ");
                    actual = actual.Siguiente;
                    contador++;
                    if (contador % 10 == 0) Console.WriteLine();
                }
                Console.WriteLine();
            }

            public int ContarElementos()// Método para contar el número de elementos en la lista
            // Recorre la lista y cuenta los nodos
            {
                int contador = 0;
                Nodo? actual = cabeza;
                while (actual != null)
                {
                    contador++;
                    actual = actual.Siguiente;
                }
                return contador;
            }
        }

        public static void Ejecutar()// Método para ejecutar el ejercicio
        // Crea una lista enlazada, agrega 50 números aleatorios entre 1 y 999,
        // y permite al usuario filtrar la lista por un rango de valores
        {
            Console.WriteLine("EJERCICIO 4: Filtrar lista por rango");
            Console.WriteLine("-----------------------------------");

            ListaEnlazada lista = new ListaEnlazada();// Crear una nueva lista enlazada
            // Crear una instancia de Random para generar números aleatorios
            
            Random random = new Random();

            // Generar 50 números aleatorios entre 1 y 999
            for (int i = 0; i < 50; i++)
            {
                lista.Agregar(random.Next(1, 1000));// Agregar un número aleatorio a la lista
            }

            Console.WriteLine("Lista original (50 elementos):");// Mostrar la lista original
            lista.Mostrar();// Mostrar los valores de la lista en una sola línea
            // Separar cada 10 elementos con un salto de línea
            Console.WriteLine($"\nTotal elementos iniciales: {lista.ContarElementos()}");

            Console.WriteLine("\nIngrese el rango para filtrar la lista:");
            int min, max;
            
            Console.Write("Valor mínimo: ");// Solicitar al usuario el valor mínimo del rango
            while (!int.TryParse(Console.ReadLine(), out min) || min < 1 || min > 999)
            {
                Console.Write("Entrada no válida. Ingrese un número entre 1 y 999: ");
            }

            Console.Write("Valor máximo: ");// Solicitar al usuario el valor máximo del rango
            while (!int.TryParse(Console.ReadLine(), out max) || max < min || max > 999)
            {
                Console.Write($"Entrada no válida. Ingrese un número entre {min} y 999: ");
            }

            lista.EliminarFueraDeRango(min, max);// Filtrar la lista eliminando nodos fuera del rango   

            Console.WriteLine("\nLista después de filtrar:");
            lista.Mostrar();// Mostrar la lista filtrada
            Console.WriteLine($"\nTotal elementos restantes: {lista.ContarElementos()}");
        }
    }
}
using System;

namespace ListasEnlazadas.Ejercicios// Ejercicio 3: Búsqueda en lista enlazada
{
    public static class Ejercicio3
    {
        private class Nodo// Clase que representa un nodo de la lista enlazada
        // Contiene un valor entero y una referencia al siguiente nodo
        {
            public int Valor { get; set; }// Propiedad que almacena el valor del nodo
            public Nodo? Siguiente { get; set; }// Propiedad que almacena la referencia al siguiente nodo

            public Nodo(int valor)// Constructor para inicializar el nodo con un valor
            // Asigna el valor y establece la referencia al siguiente nodo como nula
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        private class ListaEnlazada// Clase que representa una lista enlazada simple
        // Contiene un nodo que representa el inicio de la lista
        {
            private Nodo? cabeza = null;

            public void Agregar(int valor)
            {
                Nodo nuevo = new Nodo(valor);
                if (cabeza == null)
                {
                    cabeza = nuevo;
                }
                else
                {
                    Nodo actual = cabeza;
                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nuevo;
                }
            }

            public int Buscar(int valor)// Método para buscar un valor en la lista
            // Recorre la lista y cuenta cuántas veces aparece el valor
            {
                int contador = 0;
                Nodo? actual = cabeza;

                while (actual != null)// Recorre la lista desde el inicio hasta el final
                // Compara el valor del nodo actual con el valor buscado
                {
                    if (actual.Valor == valor)
                    {
                        contador++;
                    }
                    actual = actual.Siguiente;
                }

                if (contador == 0)
                {
                    // Console.WriteLine("El dato no fue encontrado.");
                }

                return contador;
            }

            public void Mostrar()// Método para mostrar los valores de la lista
            // Recorre la lista desde el inicio hasta el final
            {
                Nodo? actual = cabeza;
                while (actual != null)
                {
                    Console.Write(actual.Valor + " ");
                    actual = actual.Siguiente;
                }
                Console.WriteLine();
            }
        }

        public static void Ejecutar()// Método para ejecutar el ejercicio
        // Crea una lista enlazada, agrega algunos valores y permite al usuario buscar un valor
        {
            Console.WriteLine("EJERCICIO 3: Búsqueda en lista enlazada");
            Console.WriteLine("---------------------------------------");

            ListaEnlazada lista = new ListaEnlazada();// Crear una nueva lista enlazada
            
            // Agregar valores de ejemplo
            lista.Agregar(11);
            lista.Agregar(13);
            lista.Agregar(18);
            lista.Agregar(13);
            lista.Agregar(11);
            lista.Agregar(23);

            Console.WriteLine("Lista actual:");// Mostrar la lista actual
            lista.Mostrar();

            Console.Write("\nIngrese el valor a buscar: ");// Solicitar al usuario el valor a buscar
            // Validar la entrada del usuario para asegurarse de que sea un número entero
            int valorBuscado;
            while (!int.TryParse(Console.ReadLine(), out valorBuscado))// Intentar convertir la entrada a un número entero
            // Si la conversión falla, solicitar nuevamente la entrada
            {
                Console.Write("Entrada no válida. Ingrese un número entero: ");// Solicitar al usuario que ingrese un número entero válido
            }

            int encontrados = lista.Buscar(valorBuscado);// Buscar el valor en la lista y obtener cuántas veces aparece
            // Mostrar el resultado de la búsqueda
            if (encontrados==0)
            {
                Console.WriteLine("El valor no fue encontrado en la lista.");
            }
            else
            {
                Console.WriteLine($"El valor {valorBuscado} fue encontrado {encontrados} veces.");
            }
        }
    }
}
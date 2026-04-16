using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    public class ListaVideojuegos
    {
        // Puntero al primer nodo de la lista
        private Nodo cabeza;

        private static Random random = new Random();

        public Nodo Cabeza
        {
            get { return cabeza; }
        }

        // Constructor por defecto
        // Crea una lista vacía (sin nodos)
        public ListaVideojuegos()
        {
            cabeza = null;
        }

        // Genera 'n' videojuegos automáticamente con datos aleatorios
        public ListaVideojuegos(int n)
        {
            cabeza = null;

            // Arreglo de títulos posibles
            string[] titulos = {
                "Resident evil", "Counter Strike", "Dota", "Fortnite", "Minecraft",
                "Street Fighter", "Super Mario Galaxy", "Castlevania",
                "Metal Slug", "GTA", "Tekken", "Mortal Kombat"
            };

            // Arreglo de géneros posibles
            string[] generos = {
                "Arcade", "Acción", "Plataformas", "MOBA", "Shooter", "Pelea", "Puzzle","Mundo abierto"
            };

            // Se generan 'n' videojuegos
            for (int i = 0; i < n; i++)
            {
                // Se elige un título aleatorio y se le agrega un número para evitar duplicados
                string titulo = titulos[random.Next(titulos.Length)] + " " + (i + 1);

                // Se elige un género aleatorio
                string genero = generos[random.Next(generos.Length)];

                // Se generan valores aleatorios para año, stock y precio
                int anio = random.Next(1980, 2001);
                int stock = random.Next(1, 51);
                double precio = Math.Round(random.NextDouble() * 200 + 10, 2);

                // Se crea un objeto Videojuego con esos datos
                Videojuego nuevo = new Videojuego(titulo, genero, anio, stock, precio);

                // Se agrega el videojuego al final de la lista
                AgregarAlFinal(nuevo);
            }
        }

        // Método que verifica si la lista está vacía
        public bool EstaVacia()
        {
            return cabeza == null;
        }

        // Agrega un videojuego al inicio de la lista
        public void AgregarAlInicio(Videojuego juego)
        {
            Nodo nuevo = new Nodo(juego);

            // El nuevo nodo apunta a la antigua cabeza
            nuevo.Siguiente = cabeza;

            // Ahora el nuevo nodo es la cabeza
            cabeza = nuevo;
        }

        // Agrega un videojuego al final de la lista
        public void AgregarAlFinal(Videojuego juego)
        {
            Nodo nuevo = new Nodo(juego);

            // Si la lista está vacía, el nuevo nodo es la cabeza
            if (EstaVacia())
            {
                cabeza = nuevo;
                return;
            }

            // Se recorre la lista hasta el último nodo
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            // El último nodo apunta al nuevo nodo
            actual.Siguiente = nuevo;
        }

        // Elimina un videojuego por su título
        public bool EliminarPorTitulo(string titulo)
        {
            // Si la lista está vacía, no hay nada que eliminar
            if (EstaVacia())
                return false;

            // Caso especial: el nodo a eliminar es la cabeza
            if (cabeza.Dato.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            // Se usan dos punteros: anterior y actual
            Nodo anterior = cabeza;
            Nodo actual = cabeza.Siguiente;

            // Se recorre la lista
            while (actual != null)
            {
                // Si se encuentra el título
                if (actual.Dato.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    // Se salta el nodo actual
                    anterior.Siguiente = actual.Siguiente;
                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            // Si no se encontró el videojuego
            return false;
        }

        // Método para imprimir todos los videojuegos de la lista
        public string Imprimir()
        {
            // Si la lista está vacía
            if (EstaVacia())
                return "La lista está vacía.";

            // Se usa StringBuilder para construir el texto
            StringBuilder sb = new StringBuilder();

            Nodo actual = cabeza;
            int i = 1;

            // Se recorre la lista nodo por nodo
            while (actual != null)
            {
                sb.AppendLine($"{i}. {actual.Dato}");
                actual = actual.Siguiente;
                i++;
            }

            // Se retorna el texto completo
            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba del código opcional borrar
            ListaVideojuegos lista2 = new ListaVideojuegos(5);
            Console.WriteLine(lista2.Imprimir());

            using System;

namespace CatalogoVideojuegosRetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos una lista con 10 juegos aleatorios
            ListaVideojuegos miCatalogo = new ListaVideojuegos(10);
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║        GESTIÓN DE CATÁLOGO: VIDEOJUEGOS RETRO        ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝");
                Console.ResetColor();
                
                Console.WriteLine(" 1. Ver Catálogo Completo");
                Console.WriteLine(" 2. Invertir el Orden del Catálogo");
                Console.WriteLine(" 3. Ordenar por Precio (Más barato primero)");
                Console.WriteLine(" 4. Filtrar por Género (Arcade)");
                Console.WriteLine(" 5. Ver Estadísticas de Precios");
                Console.WriteLine(" 6. Mostrar Cantidad de Juegos");
                Console.WriteLine(" 0. Salir del Sistema");
                Console.WriteLine("────────────────────────────────────────────────────────");
                Console.Write(" Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n--- LISTADO ACTUAL ---");
                        Console.WriteLine(miCatalogo.Imprimir());
                        break;
                    case "2":
                        Grupo__.InvertirLista(miCatalogo);
                        Console.WriteLine("\n[!] Se ha invertido el orden de la lista.");
                        break;
                    case "3":
                        Grupo__.OrdenarPorPrecio(miCatalogo, "asc");
                        Console.WriteLine("\n[!] Catálogo ordenado por precio de menor a mayor.");
                        break;
                    case "4":
                        Console.Write("\nIngrese el género a filtrar: ");
                        string gen = Console.ReadLine();
                        ListaVideojuegos filtrada = Grupo__.FiltrarPorGenero(miCatalogo, gen);
                        Console.WriteLine($"\n--- RESULTADOS PARA: {gen.ToUpper()} ---");
                        Console.WriteLine(filtrada.Imprimir());
                        break;
                    case "5":
                        Console.WriteLine("\n" + Grupo__.EstadisticaPrecio(miCatalogo));
                        break;
                    case "6":
                        Console.WriteLine($"\nTotal de videojuegos: {Grupo__.ContarVideojuegos(miCatalogo)}");
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}
        }
    }
}

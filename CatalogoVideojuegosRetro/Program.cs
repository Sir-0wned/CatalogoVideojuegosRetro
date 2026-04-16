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
        }
    }
}

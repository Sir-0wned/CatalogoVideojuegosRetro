using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    internal class Grupo__
    {
        //1.ContarVideojuegos(L)
        public static int ContarVideojuegos(ListaVideojuegos L)
        {
            int contador = 0;
            Nodo actual = L.Cabeza;
            //recorrer nodo por nodo
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        //2.SonIguales(L1, L2)
         public static bool SonIguales(ListaVideojuegos L1, ListaVideojuegos L2)
 {
     Nodo n1 = L1.Cabeza;
     Nodo n2 = L2.Cabeza;

     while (n1 != null && n2 != null)
     {
         if (n1.Dato.Titulo != n2.Dato.Titulo ||
             n1.Dato.Genero != n2.Dato.Genero ||
             n1.Dato.Anio != n2.Dato.Anio ||
             n1.Dato.Stock != n2.Dato.Stock ||
             n1.Dato.Precio != n2.Dato.Precio)
         {
             return false;
         }

         n1 = n1.Siguiente;
         n2 = n2.Siguiente;
     }

     // Si ambas terminaron al mismo tiempo → son iguales    
     return n1 == null && n2 == null;
 }

        //3.ConcatenarListas(L1, L2)
         public static ListaVideojuegos ConcatenarListas(ListaVideojuegos L1, ListaVideojuegos L2)
 {
     // Si L1 está vacía, retorna L2
     if (L1.Cabeza == null)
         return L2;

     Nodo actual = L1.Cabeza;

     // Ir al último nodo de L1
     while (actual.Siguiente != null)
     {
         actual = actual.Siguiente;
     }

     // Enlazar con la cabeza de L2
     actual.Siguiente = L2.Cabeza;

     return L1;
 }

        //4.InvertirLista(L) 

        //5.OrdenarPorPrecio(L, tipo) 

        //6.FiltrarPorGenero(L, genero)

        //7.RestarCatalogos(L1, L2)

        //8.EstadisticaPrecio(L)
        public static string EstadisticaPrecio(ListaVideojuegos L)
        {
            if (L.EstaVacia())
            {
                return "La lista está vacía. No se pueden calcular estadísticas.";
            }

            Nodo actual = L.Cabeza;
            double min = actual.Dato.Precio;
            double max = actual.Dato.Precio;
            double suma = 0;
            int count = 0;

            while (actual != null)
            {
                double precio = actual.Dato.Precio;

                if (precio < min) min = precio;
                if (precio > max) max = precio;

                suma += precio;
                count++;

                actual = actual.Siguiente;
            }

            double promedio = suma / count;

            string resultado =
                "─── Estadística de Precios ───\r\n" +
                $"Precio mínimo : S/ {min:F2}\r\n" +
                $"Precio máximo : S/ {max:F2}\r\n" +
                $"Precio promedio: S/ {promedio:F2}\r\n" +
                $"Total videojuegos analizados: {count}";

            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    internal class Grupo__
    {
        //creacion de las clases asignadas
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

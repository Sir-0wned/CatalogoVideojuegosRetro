using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    // Esta clase representa un videojuego dentro del catálogo
    public class Videojuego
    {
        // Propiedades del videojuego (sus atributos)

        public string Titulo { get; set; }         
        public string Genero { get; set; }        
        public int AnioLanzamiento { get; set; }    
        public int StockDisponible { get; set; }  
        public double Precio { get; set; }       

        // Constructor vacío (permite crear un objeto sin pasar datos)
        public Videojuego()
        {
        }

        // Constructor con parámetros
        public Videojuego(string titulo, string genero, int anioLanzamiento, int stockDisponible, double precio)
        {
            // Asignamos los valores recibidos a las propiedades del objeto
            Titulo = titulo;
            Genero = genero;
            AnioLanzamiento = anioLanzamiento;
            StockDisponible = stockDisponible;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Título: {Titulo} | Género: {Genero} | Año: {AnioLanzamiento} | Stock: {StockDisponible} | Precio: S/ {Precio:F2}";
            // {Precio:F2} significa que el precio se muestra con 2 decimales
        }
    }
}

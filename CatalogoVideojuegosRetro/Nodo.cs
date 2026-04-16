using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVideojuegosRetro
{
    public class Nodo
    {
        public Videojuego Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Videojuego dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Nodo
    {
        public Object dato;
        public Nodo siguiente;

        public Nodo(Object dato)
        {
            this.dato = dato;
            this.siguiente = null;

        }
        public Nodo(Object dato, Nodo nodo)
        {
            this.dato = dato;
            this.siguiente = nodo;
        }
    }
}

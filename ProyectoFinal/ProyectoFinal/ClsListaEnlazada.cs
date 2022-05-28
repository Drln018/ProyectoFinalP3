using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ClsListaEnlazada
    {
        public Nodo primer;
        public Nodo final;
        int tam;

        public int num;

        public int numelementos()
        {
            return num;
        }

        //constructor
        public ClsListaEnlazada()
        {
            primer = null;
            final = null;
        }

        //verificar si la cola está vacía
        public bool ColaVacia()
        {
            return primer == null;
        }

        //obtener el ultimo el ultimo elemento de la cola
        public Object finalCola()
        {
            if (!ColaVacia())
            {
                return (final.dato);//regresa el dato del ultimo nodo

            }
            throw new Exception("Cola Vacia");
        }

        //insertar el elemento de la cola
        public void insertarValor(Object elemento)
        {
            num++;
            Nodo nuevo = new Nodo(elemento);//Se crea el nodo
            if (!ColaVacia())
            {
                final.siguiente = nuevo;//El ultimo nodo apunta al nuevo nodo
            }
            else
            {
                primer = nuevo;//de lo contrario primero apunta al nuevo nodo
            }
            final = nuevo;//El ultimo nodo apunta al nuevo nodo
            tam++;
        }

        //quitar elemento de la cola
        public Object quitarValor()
        {
            num--;
            Object aux;//aux, guarda el dato que va a quitar
            if (!ColaVacia())
            {
                aux = primer.dato;//Guarda el dato del primer nodo
                primer = primer.siguiente;//El primer nodo apunta al segundo nodo
                tam--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return aux;
        }
    }
}



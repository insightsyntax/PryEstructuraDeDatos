using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    class ClsListaDobleEnlazada
    {
        public ClsNodo Primero;
        public ClsNodo ultimo;
        /*Agregar
         * 1)si la lista esta vacia
         * 2)si el nvo es menor al 1er
         * 3)si el nvo es mayor al ult
         * 4)cuando el nvo esta en el medio
         */
        public void Agregar(ClsNodo Nuevo)
        {
            if (Primero == null) //primer caso: si la lista esta vacia
            {
                //si la lista esta vacia el nvo es primero y ultimo al mismo tiempo
                Primero = Nuevo;
                ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.codigo < Primero.codigo) //Segundo caso: Si el nuevo es menor al 1er
                {
                    Nuevo.siguiente = Primero;
                    Primero.anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.codigo > ultimo.codigo) //Tercer caso: Si el nuevo es mayor al ult
                    {
                        Nuevo.anterior = ultimo;
                        ultimo.siguiente = Nuevo;
                        ultimo = Nuevo;
                    }
                    else //Cuarto caso: cuando el nvo esta en el medio
                    {
                        ClsNodo aux = Primero;
                        ClsNodo ant = Primero;
                        while (Nuevo.codigo > aux.codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }
                        ant.siguiente = Nuevo;
                        aux.anterior = Nuevo;
                        Nuevo.anterior = ant;
                        Nuevo.siguiente = aux;
                    }
                }
            }
        }
        public void Eliminar (Int32 Codigo)
        {

        }

    }
}

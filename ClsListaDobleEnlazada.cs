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
        /*Eliminar
         * 1) cuando 1 solo nodo
         * 2) cuando quiero borrar el primero 
         * 3) Cuando quiero borrar el ultimo
         * 4)cuando es uno intermedio
         */
        public void Eliminar(Int32 Codigo)
        {
            if (Codigo == Primero.codigo && Primero == ultimo) //Primer caso
            {
                Primero = null;
                ultimo = null;
            }
            else
            {
                if (Primero.codigo == Codigo) //Segundo caso
                {
                    Primero = Primero.siguiente;
                    Primero.anterior = null;
                }
                else
                {
                    if (ultimo.codigo == Codigo) //Tercer caso
                    {
                        ultimo = ultimo.anterior;
                        ultimo.siguiente = null;
                    }
                    else //Ultimo caso
                    {
                        ClsNodo ant = Primero;
                        ClsNodo aux = Primero;
                        while (aux.codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;

                        }
                        ant.siguiente = aux.siguiente;
                        aux = aux.siguiente;
                        aux.anterior = ant;
                    }
                }

            }
        }
        public void Recorrer(ComboBox Combo)
        {
            ClsNodo aux = ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            ClsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo + " " + aux.nombre + " " +
                aux.tramite);
                aux = aux.siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            ClsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.siguiente;
            }
        }
        public void RecorrerDesc(DataGridView Grilla)
        {
            ClsNodo aux = ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.nombre, aux.tramite);
                aux = aux.anterior;
            }
        }
        public void RecorrerDesc(ListBox Lista)
        {
            ClsNodo aux = ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo + " " + aux.nombre + " " + aux.tramite);
                aux = aux.anterior;
            }
        }
        public void RecorrerDesc(ComboBox Combo)
        {
            ClsNodo aux = ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.codigo);
                aux = aux.anterior;
            }
        }
    }
} 


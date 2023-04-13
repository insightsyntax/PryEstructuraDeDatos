using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    class ClsCola
    {
        public ClsNodo Primero;
        public ClsNodo Ultimo;

        public void Agregar (ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.siguiente;
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
        public void Recorrer (ListBox Lista)
        {
            ClsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo + "" + aux.nombre + "" + aux.tramite);
                aux = aux.siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            ClsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.nombre);
                aux = aux.siguiente;
            }
        }



    }
}

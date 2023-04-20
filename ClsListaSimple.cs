using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    class ClsListaSimple
    {
        public ClsNodo Primero;

        public void Agregar(ClsNodo Nuevo)
        {
            try
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.codigo < Primero.codigo)
                    {
                        Nuevo.siguiente = Primero;
                        Primero = Nuevo; 
                    }
                    else
                    {
                        ClsNodo aux = Primero;
                        ClsNodo ant = Primero;
                        while (Nuevo.codigo > aux.codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                            if (aux == null)
                            {
                                break;
                            }
                        }
                        ant.siguiente = Nuevo;
                        Nuevo.siguiente = aux;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.codigo == Codigo)
            {
                Primero = Primero.siguiente;
            }
            else
            {
                ClsNodo ant = Primero;
                ClsNodo aux = Primero;
                while (aux.codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.siguiente;
                }
                ant.siguiente = aux.siguiente;
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
        public void Recorrer(ListBox Lista)
        {
            ClsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add("Codigo:" + aux.codigo + " Nombre:" + aux.nombre + " Tramite:" + aux.tramite);
                aux = aux.siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            ClsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.codigo);
                aux = aux.siguiente;
            }
        }


    }
}

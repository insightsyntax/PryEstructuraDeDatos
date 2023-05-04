using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PryEstructuraDeDatos
{
    class ClsArbolBinario
    {
        //Campo inicial del arbol
        private ClsNodo Inicio;
        //Propiedad
        public ClsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
        public void Agregar (ClsNodo nuevo)
        {
            nuevo.izquierdo = null;
            nuevo.derecho = null;   
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                ClsNodo padre = Raiz;
                ClsNodo aux = Raiz;
                while (aux != null)
                {
                    padre = aux;
                    if (nuevo.codigo < aux.codigo)
                    {
                        aux = aux.izquierdo;
                    }
                    else
                    {
                        aux = aux.derecho;
                    }
                }
                if (nuevo.codigo < padre.codigo)
                {
                    padre.izquierdo = nuevo;
                }
                else
                {
                    padre.derecho = nuevo;
                }
            }
        }
        /* Recorrido en orden
         * Primero se recorre el nodo izquierdo 
         * Despues se muestra el nodo raiz 
         * y despues se recorre el nodo derecho
         */
        public void RecorrerAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }
        public void InOrderAsc(DataGridView DGV, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                InOrderAsc(DGV, R.izquierdo);
            }
            DGV.Rows.Add(R.codigo, R.nombre, R.tramite);
            if (R.derecho != null)
            {
                InOrderAsc(DGV, R.derecho);
            }
        }
        public void RecorrerAsc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrderAsc(Lista, Raiz);
        }
        public void InOrderAsc(ListBox Lst, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                InOrderAsc(Lst, R.izquierdo);
            }
            Lst.Items.Add(R.codigo);
            if (R.derecho != null)
            {
                InOrderAsc(Lst, R.derecho);
            }
        }
        public void RecorrerAsc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrderAsc(Combo, Raiz);
        }
        public void InOrderAsc(ComboBox Cmb, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                InOrderAsc(Cmb, R.izquierdo);
            }
            Cmb.Items.Add(R.codigo);
            if (R.derecho != null)
            {
                InOrderAsc(Cmb, R.derecho);
            }
        }
        /*Recorrido descendiente 
         * 1)Derecho
         * 2)Raiz
         * 3)Izquierdo
         */
        public void RecorrerDesc (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderDesc(Grilla, Raiz);
        }
        public void InOrderDesc(DataGridView DGV, ClsNodo R)
        {
            if (R.derecho != null)
            {
                InOrderDesc(DGV, R.derecho);
            }
            DGV.Rows.Add(R.codigo);
            if (R.izquierdo != null)
            {
                InOrderDesc(DGV, R.izquierdo);
            }
        }
        public void RecorrerDesc(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrderDesc(Lista, Raiz);
        }
        public void InOrderDesc(ListBox Lst, ClsNodo R)
        {
            if (R.derecho != null)
            {
                InOrderDesc(Lst, R.derecho);
            }
            Lst.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                InOrderDesc(Lst, R.izquierdo);
            }
        }
        public void RecorrerDesc(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrderDesc(Combo, Raiz);
        }
        public void InOrderDesc(ComboBox Cmb, ClsNodo R)
        {
            if (R.derecho != null)
            {
                InOrderDesc(Cmb, R.derecho);
            }
            Cmb.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                InOrderDesc(Cmb, R.izquierdo);
            }
        }
        /* Recorrido Pre-Orden
         * Consiste en:
         * Mostrar el nodo raíz.
         * Recorrer el subárbol izquierdo.
         * Recorrer el subárbol derecho.
         */
        public void RecorrerPreOrden (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrder(Grilla, Raiz);
        }
        public void PreOrder(DataGridView DGV, ClsNodo R)
        {
            DGV.Rows.Add(R.codigo);
            if (R.izquierdo != null)
            {
                PreOrder(DGV, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PreOrder(DGV, R.derecho);
            }
        }
        public void RecorrerPre(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrder(Lista, Raiz);
        }
        public void PreOrder(ListBox Lst, ClsNodo R)
        {
            Lst.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                PreOrder(Lst, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PreOrder(Lst, R.derecho);
            }
        }
        public void RecorrerPre(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrder(Combo, Raiz);
        }
        public void PreOrder(ComboBox Cmb, ClsNodo R)
        {
            Cmb.Items.Add(R.codigo);
            if (R.izquierdo != null)
            {
                PreOrder(Cmb, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PreOrder(Cmb, R.derecho);
            }
        }
        /*Recorrido Post-Orden
         * 1)Izquierdo
         * 2)Derecho
         * 3)Raiz
         */
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrder(Grilla, Raiz);
        }
        public void PostOrder(DataGridView DGV, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                PostOrder(DGV, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PostOrder(DGV, R.derecho);
            }
            DGV.Rows.Add(R.codigo);
        }
        public void RecorrerPost(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrder(Lista, Raiz);
        }
        public void PostOrder(ListBox Lst, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                PostOrder(Lst, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PostOrder(Lst, R.derecho);
            }
            Lst.Items.Add(R.codigo);
        }
        public void RecorrerPost(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrder(Combo, Raiz);
        }
        public void PostOrder(ComboBox Cmb, ClsNodo R)
        {
            if (R.izquierdo != null)
            {
                PostOrder(Cmb, R.izquierdo);
            }
            if (R.derecho != null)
            {
                PostOrder(Cmb, R.derecho);
            }
            Cmb.Items.Add(R.codigo);
        }

        /*Equilibrar
         * 
         * 
         */
        private ClsNodo[] vector = new ClsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void CargarVectorInOrden(ClsNodo Raiz)
        {
            if (Raiz.izquierdo != null)
            {
                CargarVectorInOrden(Raiz.izquierdo);
            }
            vector[i] = Raiz;
            i = i + 1;
            if (Raiz.derecho != null)
            {
                CargarVectorInOrden(Raiz.derecho);
            }
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vector[m]);
                EquilibrarArbol(ini, m - i);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar()
        {

        }
    }
}

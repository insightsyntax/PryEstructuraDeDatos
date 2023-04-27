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
    }
}

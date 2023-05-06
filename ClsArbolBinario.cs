using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;


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
        public void InOrderAscArchivo(ClsNodo nodo, List<ClsNodo> ListaNodos)
        {
            if (nodo != null)
            {
                InOrderAscArchivo(nodo.izquierdo, ListaNodos);
                ListaNodos.Add(nodo);
                InOrderAscArchivo(nodo.derecho, ListaNodos);
            }
        }
        public void ExportarAsc (string NombreArchivo, Form formulario)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "data.csv";
            saveFileDialog.DefaultExt = ".csv";

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            DialogResult result = saveFileDialog.ShowDialog(formulario);
            if (result == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("codigo;nombre;tramite");

                        List<ClsNodo> ListaNodos = new List<ClsNodo>();
                        InOrderAscArchivo(Raiz, ListaNodos);

                        foreach (ClsNodo nodo in ListaNodos)
                        {
                            writer.WriteLine($"{nodo.codigo};{nodo.nombre};{nodo.tramite}");
                        }
                    }
                }           
        }
        public void MostrarEnTreeView(ClsNodo nodo, TreeNode NodoPadre)
        {
            if (nodo != null)
            {
                TreeNode treenode = new TreeNode(nodo.codigo.ToString());

                NodoPadre.Nodes.Add(treenode);

                MostrarEnTreeView(nodo.izquierdo, treenode);
                MostrarEnTreeView(nodo.derecho, treenode);
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
            DGV.Rows.Add(R.codigo, R.nombre, R.tramite);
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
        public void InOrderDescArchivo(ClsNodo nodo, List<ClsNodo> ListaNodos)
        {
            if (nodo != null)
            {
                InOrderDescArchivo(nodo.derecho, ListaNodos);
                ListaNodos.Add(nodo);
                InOrderDescArchivo(nodo.izquierdo, ListaNodos);
            }
        }
        public void ExportarDesc(string NombreArchivo, Form formulario)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "data.csv";
            saveFileDialog.DefaultExt = ".csv";

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            DialogResult result = saveFileDialog.ShowDialog(formulario);
            if (result == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("codigo;nombre;tramite");

                    List<ClsNodo> ListaNodos = new List<ClsNodo>();
                    InOrderDescArchivo(Raiz, ListaNodos);

                    foreach (ClsNodo nodo in ListaNodos)
                    {
                        writer.WriteLine($"{nodo.codigo};{nodo.nombre};{nodo.tramite}");
                    }
                }
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
            DGV.Rows.Add(R.codigo, R.nombre, R.tramite);
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
        public void PreOrderArchivo(ClsNodo nodo, List<ClsNodo> ListaNodos)
        {
            if (nodo != null)
            {
                ListaNodos.Add(nodo);
                PreOrderArchivo(nodo.izquierdo, ListaNodos);
                PreOrderArchivo(nodo.derecho, ListaNodos);
            }
        }
        public void ExportarPre(string NombreArchivo, Form formulario)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "data.csv";
            saveFileDialog.DefaultExt = ".csv";

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            DialogResult result = saveFileDialog.ShowDialog(formulario);
            if (result == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("codigo;nombre;tramite");

                    List<ClsNodo> ListaNodos = new List<ClsNodo>();
                    PreOrderArchivo (Raiz, ListaNodos);

                    foreach (ClsNodo nodo in ListaNodos)
                    {
                        writer.WriteLine($"{nodo.codigo};{nodo.nombre};{nodo.tramite}");
                    }
                }
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
            DGV.Rows.Add(R.codigo, R.nombre, R.tramite);
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
        private void PostOrderArchivo(ClsNodo Raiz, List<ClsNodo> listanodos)
        {
            if (Raiz != null)
            {
                PostOrderArchivo(Raiz.izquierdo, listanodos);
                PostOrderArchivo(Raiz.derecho, listanodos);
                listanodos.Add(Raiz);
            }
        }
        public void ExportarPost(string NombreArchivo, Form form)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "data.csv";
            saveFileDialog.DefaultExt = ".csv";

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            DialogResult result = saveFileDialog.ShowDialog(form);

            if (result == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Codigo;Nombre;Tramite");

                    List<ClsNodo> nodeList = new List<ClsNodo>();
                    PostOrderArchivo(Raiz, nodeList);
                    foreach (ClsNodo node in nodeList)
                    {
                        writer.WriteLine($"{node.codigo};{node.nombre};{node.tramite}");
                    }
                }
            }
        }
        /*
         * Equilibrar
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
        public void CargarVectorInOrden(ClsNodo Raiz)
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
        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vector[m]);
                EquilibrarArbol(ini, m - i);
                EquilibrarArbol(m + 1, fin);
            }
        }
        /*
         * Busqueda
         */
        public ClsNodo BuscarMinimo(ClsNodo nodo)
        {
            ClsNodo actual = nodo;
            while (actual.izquierdo != null)
            {
                actual = actual.izquierdo;
            }
            return actual;
        }
        public ClsNodo BuscarNodo(ClsNodo raiz, int codigo)
        {
            if (raiz == null || raiz.codigo == codigo)
            {
                return raiz;
            }

            if (codigo < raiz.codigo)
            {
                return BuscarNodo(raiz.izquierdo, codigo);
            }
            else
            {
                return BuscarNodo(raiz.derecho, codigo);
            }
        }
        //Eliminar
        public void Eliminar(int codigo)
        {
            ClsNodo actual = Raiz;
            ClsNodo anterior = null;

            // Buscar el nodo a eliminar
            while (actual != null && actual.codigo != codigo)
            {
                anterior = actual;
                if (codigo < actual.codigo)
                {
                    actual = actual.izquierdo;
                }
                else
                {
                    actual = actual.derecho;
                }
            }
            // Si no se encontró el nodo, salir del método
            if (actual == null)
            {
                return;
            }
            // Si el nodo a eliminar es una hoja
            if (actual.izquierdo == null && actual.derecho == null)
            {
                // Si el nodo es la raíz
                if (anterior == null)
                {
                    Raiz = null;
                }
                else if (anterior.izquierdo == actual)
                {
                    anterior.izquierdo = null;
                }
                else
                {
                    anterior.derecho = null;
                }
            }
            // Si el nodo a eliminar tiene un solo hijo
            else if (actual.izquierdo == null)
            {
                // Si el nodo es la raíz
                if (anterior == null)
                {
                    Raiz = actual.derecho;
                }
                else if (anterior.izquierdo == actual)
                {
                    anterior.izquierdo = actual.derecho;
                }
                else
                {
                    anterior.derecho = actual.derecho;
                }
            }
            else if (actual.derecho == null)
            {
                // Si el nodo es la raíz
                if (anterior == null)
                {
                    Raiz = actual.izquierdo;
                }
                else if (anterior.izquierdo == actual)
                {
                    anterior.izquierdo = actual.izquierdo;
                }
                else
                {
                    anterior.derecho = actual.izquierdo;
                }
            }
            // Si el nodo a eliminar tiene dos hijos
            else
            {
                // Buscar el nodo más a la izquierda del subárbol derecho
                ClsNodo sucesor = actual.derecho;
                anterior = null;
                while (sucesor.izquierdo != null)
                {
                    anterior = sucesor;
                    sucesor = sucesor.izquierdo;
                }

                // Copiar el valor del sucesor al nodo a eliminar
                actual.codigo = sucesor.codigo;
                actual.nombre = sucesor.nombre;
                // Eliminar el sucesor
                if (anterior == null)
                {
                    actual.derecho = sucesor.derecho;
                }
                else
                {
                    anterior.izquierdo = sucesor.derecho;
                }
            }
        }

        public void RecorrerEnOrden(ClsNodo node, TreeNodeCollection treeNode)
        {
            if (node != null)
            {
                TreeNode newNode = new TreeNode(node.codigo.ToString());
                // Recorre la izquierda
                RecorrerEnOrden(node.izquierdo, newNode.Nodes);
                //Añade el nodo actual al treeview
                treeNode.Add(newNode);
                // Recorre la derecha
                RecorrerEnOrden(node.derecho, newNode.Nodes);
            }
        }

    }
}

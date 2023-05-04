using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    public partial class FrmEstructuraRamificadaArbolBinario : Form
    {
        public FrmEstructuraRamificadaArbolBinario()
        {
            InitializeComponent();
        }
        ClsArbolBinario Arbol = new ClsArbolBinario();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo ObjNodo = new ClsNodo();
            ObjNodo.codigo = Convert.ToInt32(TxtCodigo.Text);
            ObjNodo.nombre = TxtNombre.Text;
            ObjNodo.tramite = TxtTramite.Text;


            Arbol.Agregar(ObjNodo);
            Arbol.RecorrerAsc(DgvArbolBinario);
            Arbol.RecorrerAsc(LstArbolBinario);
            Arbol.RecorrerAsc(CboCodigo);

            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }
    }
}

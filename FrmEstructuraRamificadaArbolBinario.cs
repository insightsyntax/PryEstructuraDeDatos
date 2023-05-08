using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PryEstructuraDeDatos
{
    public partial class FrmEstructuraRamificadaArbolBinario : Form
    {
        public FrmEstructuraRamificadaArbolBinario()
        {
            InitializeComponent();
        }

        ClsArbolBinario Arbol = new ClsArbolBinario();
        private void FrmEstructuraRamificadaArbolBinario_Load(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = true;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsNodo ObjNodo = new ClsNodo();
                ObjNodo.codigo = Convert.ToInt32(TxtCodigo.Text);
                ObjNodo.nombre = TxtNombre.Text;
                ObjNodo.tramite = TxtTramite.Text;
                Arbol.Agregar(ObjNodo);
                Arbol.RecorrerAsc(DgvArbolBinario);
                Arbol.RecorrerAsc(LstArbolBinario);
                Arbol.RecorrerAsc(CboCodigo);
                TrvArbolBinario.Nodes.Clear();
                Arbol.RecorrerEnOrden(Arbol.Raiz, TrvArbolBinario.Nodes);
                TxtCodigo.Text = "";
                TxtNombre.Text = "";
                TxtTramite.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void BtnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerAsc(DgvArbolBinario);
            Arbol.RecorrerAsc(LstArbolBinario);
            Arbol.RecorrerAsc(CboCodigo);
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (RdbAscendiente.Checked)
            {
                Arbol.ExportarAsc("data.csv", this);
            }
            else if (RdbDescendiente.Checked)
            {
                Arbol.ExportarDesc("data.csv", this);
            }
            else if (RdbPostOrder.Checked)
            {
                Arbol.ExportarPost("data.csv", this);
            }
            else if (RdbPreOrder.Checked)
            {
                Arbol.ExportarPre("data.csv", this);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 cod = 0;
                cod = Int32.Parse(CboCodigo.Text);
                Arbol.Eliminar(cod);
                Arbol.RecorrerAsc(DgvArbolBinario);
                Arbol.RecorrerAsc(LstArbolBinario);
                Arbol.RecorrerAsc(CboCodigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            TrvArbolBinario.Nodes.Clear();
            LstArbolBinario.Items.Clear();
            DgvArbolBinario= null;
            if (RdbAscendiente.Checked)
            {
                Arbol.RecorrerAsc(DgvArbolBinario);
                Arbol.RecorrerAsc(CboCodigo);
                Arbol.RecorrerAsc(LstArbolBinario);
                Arbol.RecorrerEnOrden(Arbol.Raiz, TrvArbolBinario.Nodes);
            }
            else if (RdbDescendiente.Checked)
            {
                Arbol.RecorrerDesc(DgvArbolBinario);
                Arbol.RecorrerDesc(CboCodigo) ;
                Arbol.RecorrerDesc(LstArbolBinario) ;
            }
            else if (RdbPostOrder.Checked)
            {
                Arbol.RecorrerPost(DgvArbolBinario);
                Arbol.RecorrerPost(CboCodigo);
                Arbol.RecorrerPost(LstArbolBinario);
            }
            else if (RdbPreOrder.Checked)
            {
                Arbol.RecorrerPreOrden(DgvArbolBinario);
                Arbol.RecorrerPre(LstArbolBinario);
                Arbol.RecorrerPre(CboCodigo);
            }
        }
    }

}

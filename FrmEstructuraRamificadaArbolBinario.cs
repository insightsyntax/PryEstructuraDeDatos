using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void ButtonCheck()
        {
            if (RdbDescendiente.Checked || RdbAscendiente.Checked || RdbPreOrder.Checked || RdbPostOrder.Checked )
            {
                BtnAgregar.Enabled = true;
            }
            else
            {
                BtnAgregar.Enabled = false;
            }
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
                

                if (RdbAscendiente.Checked)
                {
                    Arbol.RecorrerAsc(DgvArbolBinario);
                    Arbol.RecorrerAsc(LstArbolBinario);
                    Arbol.RecorrerAsc(CboCodigo);
                    
                }
                else if (RdbDescendiente.Checked)
                {
                    Arbol.RecorrerDesc(DgvArbolBinario);
                    Arbol.RecorrerDesc(LstArbolBinario);
                    Arbol.RecorrerDesc(CboCodigo);
                }
                else if (RdbPostOrder.Checked)
                {
                    Arbol.RecorrerPost(DgvArbolBinario);
                    Arbol.RecorrerPost(LstArbolBinario);
                    Arbol.RecorrerPost(CboCodigo);
                }
                else if (RdbPreOrder.Checked)
                {
                    Arbol.RecorrerPreOrden(DgvArbolBinario);
                    Arbol.RecorrerPre(LstArbolBinario);
                    Arbol.RecorrerPre(CboCodigo);
                    
                }

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
        }

        private void FrmEstructuraRamificadaArbolBinario_Load(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = false;
        }

        private void RdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck();
        }
        private void RdbDescendiente_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck();
        }
        private void RdbPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck();
        }
        private void RdbPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck();
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

        }
    }
}

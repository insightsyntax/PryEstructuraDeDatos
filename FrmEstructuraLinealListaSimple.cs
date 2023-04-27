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
    public partial class FrmEstructuraLinealListaSimple : Form
    {
        public FrmEstructuraLinealListaSimple()
        {
            InitializeComponent();
        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ClsListaSimple FilaDePersonas = new ClsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo Nodo = new ClsNodo();
            ClsNodo ObjNodo = new ClsNodo();
            ObjNodo.codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.nombre = txtNombre.Text;
            ObjNodo.tramite = txtTramite.Text;

            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvListaSimple);
            FilaDePersonas.Recorrer(LstListaSimple);
            FilaDePersonas.Recorrer(cboCodigo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 Cod = Convert.ToInt32(cboCodigo.Text);
                if (FilaDePersonas.Primero != null)
                {
                    FilaDePersonas.Eliminar(Cod);
                    FilaDePersonas.Recorrer(dgvListaSimple);
                    FilaDePersonas.Recorrer(LstListaSimple);
                    FilaDePersonas.Recorrer(cboCodigo);
                }
            }
            catch (Exception exc)
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                MessageBox.Show(exc.Message);
            }
            btnEliminar.Enabled = false;
        }

        private void FrmEstructuraDinamicaListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
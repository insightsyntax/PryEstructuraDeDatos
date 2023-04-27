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
    public partial class FrmEstructuraLinealListaDoblementeEnlazada : Form
    {
        public FrmEstructuraLinealListaDoblementeEnlazada()
        {
            InitializeComponent();
        }

        ClsListaDobleEnlazada ListaDoble = new ClsListaDobleEnlazada();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsNodo Nodo = new ClsNodo();
                ClsNodo ObjNodo = new ClsNodo();
                ObjNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.nombre = txtNombre.Text;
                ObjNodo.tramite = txtTramite.Text;
                if (RdbAscendiente.Checked == true)
                {
                    ListaDoble.Agregar(ObjNodo);
                    ListaDoble.Recorrer(dgvListaDoble);
                    ListaDoble.Recorrer(LstListaDoble);
                    ListaDoble.Recorrer(cboCodigo);
                }
                else if (RdbDescendiente.Checked == true)
                {
                    ListaDoble.Agregar(ObjNodo);
                    ListaDoble.RecorrerDesc(dgvListaDoble);
                    ListaDoble.RecorrerDesc(LstListaDoble);
                    ListaDoble.RecorrerDesc(cboCodigo);
                }
                else
                {
                    MessageBox.Show("Porfavor elija una opcion de orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 Cod = Convert.ToInt32(cboCodigo.Text);
                if (ListaDoble.Primero != null)
                {
                    ListaDoble.Eliminar(Cod);
                    ListaDoble.Recorrer(dgvListaDoble);
                    ListaDoble.Recorrer(LstListaDoble);
                    ListaDoble.Recorrer(cboCodigo);
                }
            }
            catch (Exception exc)
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                MessageBox.Show(exc.Message);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
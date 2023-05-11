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
    public partial class FrmEstructuraLinealPila : Form
    {
        public FrmEstructuraLinealPila()
        {
            InitializeComponent();
        }

        private void FrmEstructuraDinamicaLinealPila1_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }
        ClsPila FilaDePersonas = new ClsPila();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilaDePersonas.Primero !=null)
                {
                    TxtCodigoEliminar.Text = FilaDePersonas.Primero.codigo.ToString();
                    TxtNombreEliminar.Text = FilaDePersonas.Primero.nombre;
                    TxtTramiteEliminar.Text = FilaDePersonas.Primero.tramite;
                    FilaDePersonas.Eliminar();
                    FilaDePersonas.Recorrer(dgvPila);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
                {
                    ClsNodo ObjNodo = new ClsNodo();
                    ObjNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                    ObjNodo.nombre = txtNombre.Text;
                    ObjNodo.tramite = txtTramite.Text;

                    FilaDePersonas.Agregar(ObjNodo);
                    FilaDePersonas.Recorrer(dgvPila);
                    FilaDePersonas.Recorrer(LstPila);
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtTramite.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    MessageBox.Show("Campos incompletos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void ValidarCampos()
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtTramite.Text))
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}

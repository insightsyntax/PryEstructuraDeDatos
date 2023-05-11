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
    public partial class FrmEstructuraLinealCola : Form
    {
        public FrmEstructuraLinealCola()
        {
            InitializeComponent();
        }
        private void FrmEstructuraDinamicaLinealCola_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;

        }

        ClsCola FilaDePersonas = new ClsCola();
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
                    FilaDePersonas.Recorrer(dgvCola);
                    FilaDePersonas.Recorrer(LstCola);
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtTramite.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    MessageBox.Show("Campos sin llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                TxtCodigoEliminar.Text = FilaDePersonas.Primero.codigo.ToString();
                TxtNombreEliminar.Text = FilaDePersonas.Primero.nombre;
                TxtTramiteEliminar.Text = FilaDePersonas.Primero.tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(LstCola);
            }
            else
            {
                MessageBox.Show("No quedan datos en la cola", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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
    }
}

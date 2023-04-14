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
    public partial class FrmEstructuraDinamicaLinealPila : Form
    {
        public FrmEstructuraDinamicaLinealPila()
        {
            InitializeComponent();
        }

        private void FrmEstructuraDinamicaLinealPila1_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilaDePersonas.Primero !=null)
                {
                    txtCodigo.Text = FilaDePersonas.Primero.codigo.ToString();
                    txtNombre.Text = FilaDePersonas.Primero.nombre;
                    txtTramite.Text = FilaDePersonas.Primero.tramite;
                    FilaDePersonas.Eliminar();
                    FilaDePersonas.Recorrer(dgvPila);
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

        ClsPila FilaDePersonas = new ClsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsNodo Nodo = new ClsNodo();
                ClsNodo ObjNodo = new ClsNodo();
                ObjNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.nombre = txtNombre.Text;
                ObjNodo.tramite = txtTramite.Text;

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(LstPila);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}

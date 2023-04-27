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

        }

        ClsCola FilaDePersonas = new ClsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsNodo ObjNodo = new ClsNodo();
                ObjNodo.codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.nombre = txtNombre.Text;
                ObjNodo.tramite = txtTramite.Text;

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(LstCola);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
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
                txtCodigo.Text = FilaDePersonas.Primero.codigo.ToString();
                txtNombre.Text = FilaDePersonas.Primero.nombre;
                txtTramite.Text = FilaDePersonas.Primero.tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
            }
            else
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }
    }
}

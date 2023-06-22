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
    public partial class FrmBaseDatosLista : Form
    {
        ClsBaseDatos BaseDatos = new ClsBaseDatos();

        public FrmBaseDatosLista()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void FrmRepasoBaseDatos_Load(object sender, EventArgs e)
        {
            CboInstrucciones.Items.Add("Diferencia");
            CboInstrucciones.Items.Add("Intersección");
            CboInstrucciones.Items.Add("Juntar");
            CboInstrucciones.Items.Add("Proyección simple");
            CboInstrucciones.Items.Add("Proyección multiatributo");
            CboInstrucciones.Items.Add("Seleccion multiatributo con operador AND");
            CboInstrucciones.Items.Add("Seleccion multiatributo con operador OR");
            CboInstrucciones.Items.Add("Seleccion multiatributo por convolucion");
            CboInstrucciones.Items.Add("Seleccion simple");
            CboInstrucciones.Items.Add("Union");
        }

        private void CboInstrucciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la operación seleccionada
            string operacion = CboInstrucciones.SelectedItem.ToString();

            // Ejecutar la operación y mostrar los resultados en la DataGridView
            DataTable resultados = BaseDatos.EjecutarOperacion(operacion);
            DgvListar.DataSource = resultados;

            // Mostrar la descripción de la operación en el Label
            string descripcion = BaseDatos.ObtenerDescripcionOperacion(operacion);
            TxtDescripcion.Text = descripcion;
        }
    }
}

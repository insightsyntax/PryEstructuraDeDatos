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
    public partial class FrmConsultaEnBaseDeDatos : Form
    {
        ClsBaseDatos BaseDatos = new ClsBaseDatos();

        public FrmConsultaEnBaseDeDatos()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            string Consulta = TxtConsulta.Text;

            try
            {
                DataTable DT = BaseDatos.EjecutarConsulta(Consulta);
                DgvDatos.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message);
            }
        }
    }
}

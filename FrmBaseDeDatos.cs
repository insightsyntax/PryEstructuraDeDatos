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
    public partial class FrmBaseDeDatos : Form
    {
        public FrmBaseDeDatos()
        {
            InitializeComponent();
        }
        ClsBaseDatos BaseDatos = new ClsBaseDatos();
        private void BtnProySimple_Click(object sender, EventArgs e)
        {
            BaseDatos.Listar(DgvBaseDatos);
        }

        private void BtnProyMulti_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT Titulo, IdIdioma FROM LIBRO";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnJuntar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT Titulo, Nombre FROM Libro";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }
    }
}

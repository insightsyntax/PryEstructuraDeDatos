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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLinealCola estructuraDinamicaLinealCola = new FrmEstructuraDinamicaLinealCola();
            estructuraDinamicaLinealCola.Show();

        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaLinealPila estructuraDinamicaLinealPila1 = new FrmEstructuraDinamicaLinealPila();
            estructuraDinamicaLinealPila1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraDinamicaListaSimple estructuraDinamicaListaSimple = new FrmEstructuraDinamicaListaSimple();
            estructuraDinamicaListaSimple.Show();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosdelProgramador datosdelProgramador = new FrmDatosdelProgramador();
            datosdelProgramador.Show();    
        }
    }
}

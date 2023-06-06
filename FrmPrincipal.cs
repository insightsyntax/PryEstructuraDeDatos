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
            FrmEstructuraLinealCola estructuraDinamicaLinealCola = new FrmEstructuraLinealCola();
            estructuraDinamicaLinealCola.Show();

        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraLinealPila estructuraDinamicaLinealPila1 = new FrmEstructuraLinealPila();
            estructuraDinamicaLinealPila1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraLinealListaSimple estructuraDinamicaListaSimple = new FrmEstructuraLinealListaSimple();
            estructuraDinamicaListaSimple.Show();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosdelProgramador datosdelProgramador = new FrmDatosdelProgramador();
            datosdelProgramador.Show();    
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraLinealListaDoblementeEnlazada listaDoblementeEnlazada = new FrmEstructuraLinealListaDoblementeEnlazada();
            listaDoblementeEnlazada.Show();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstructuraRamificadaArbolBinario ArbolBinario = new FrmEstructuraRamificadaArbolBinario();
            ArbolBinario.Show();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaseDeDatos BaseDatos = new FrmBaseDeDatos();
            BaseDatos.Show();
        }
    }
}

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
            String VarSQL = "SELECT Titulo, Año " +
                "FROM LIBRO " +
                "ORDER BY 1 ASC";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnJuntar_Click(object sender, EventArgs e)
        {
            //String VarSQL = "SELECT * " +
            //    "FROM Libro, Autor " +
            //    "WHERE Libro.IdAutor = Autor.IdAutor";
            String VarSQL = "SELECT * " +
                "FROM Libro INNER JOIN Autor " +
                "ON Libro.IdAutor = Autor.IdAutor";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT Titulo, IdAutor " +//Select siempre primero
                "FROM Libro " +
                "WHERE IdAutor <> 5 " +
                "ORDER BY Titulo DESC";//ORDER BY siempre va al final
            BaseDatos.Listar(DgvBaseDatos, VarSQL);

        }

        private void BtnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT Titulo, IdAutor, IdIdioma " +//Select siempre primero
                "FROM Libro " +
                "WHERE IdAutor <> 5 AND IdIdioma = 1 " +
                "ORDER BY Titulo ASC";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnUnion_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro WHERE IdIdioma = 1 " +
                "UNION " +
                "SELECT * FROM Libro WHERE IdIdioma = 2";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnInterseccion_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro " +
                "WHERE IdIdioma = 2 AND " +
               "IdLibro IN " +
               "(SELECT IdLibro FROM Libro WHERE IdPais = 3 )" +
               "ORDER BY 1 ASC";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnDiferencia_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro " +
                "WHERE IdIdioma = 2 AND IdLibro NOT IN " +
                "(SELECT IdLibro FROM Libro WHERE IdPais = 3 ) " +
                "ORDER BY 1 ASC";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);
        }

        private void BtnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * " +
                "FROM (SELECT * FROM Libro WHERE IdAutor = 4) AS LIB1 " +
                "WHERE LIB1.IdIdioma = 1 " +
                "ORDER BY LIB1.Titulo";
            BaseDatos.Listar(DgvBaseDatos, VarSQL);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    class ClsBaseDatos
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Libreria.mdb";
        //public String VarSql = "SELECT * FROM Libro";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Libro";

                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();

                Adaptador.Fill(DS, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libro"];

                Conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }
        }

        public void Listar(DataGridView Grilla, String VarInstruccionSQL)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = VarInstruccionSQL;

                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];
                
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }
        }

    }
}

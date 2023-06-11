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

        public DataTable EjecutarConsulta(string ConsultaSQL)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = ConsultaSQL;

                OleDbDataAdapter adapter = new OleDbDataAdapter(Comando);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
            finally
            {
                Conexion.Close();
            }
        }

        public DataTable EjecutarOperacion(string operacion)
        {
            string consulta = ObtenerQueryOperacion(operacion);
            DataTable resultados = new DataTable();

            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, conexion))
                {
                    adapter.Fill(resultados);
                }
            }

            return resultados;
        }

        public string ObtenerDescripcionOperacion(string operacion)
        {
            // Aquí puedes retornar la descripción correspondiente a la operación
            string descripcion = "";

            switch (operacion)
            {
                case "Diferencia":
                    descripcion = "Realiza la diferencia entre dos conjuntos";
                    break;
                case "Intersección":
                    descripcion = "Encuentra los elementos comunes entre dos conjuntos";
                    break;
                case "Juntar":
                    descripcion = "Combina dos conjuntos en uno solo";
                    break;
                case "Proyección simple":
                    descripcion = "Selecciona una lista de atributos de los elementos";
                    break;
                case "Proyección multiatributo":
                    descripcion = "Selecciona múltiples listas de atributos de los elementos";
                    break;
                case "Seleccion multiatributo con operador AND":
                    descripcion = "";
                    break;
                case "Seleccion multiatributo con operador OR":
                    descripcion = "";
                    break;
                case "Seleccion multiatributo por convolucion":
                    descripcion = "";
                    break;
                case "Seleccion simple":
                    descripcion = "";
                    break;
                case "Union":
                    descripcion = "";
                    break;
            }

            return descripcion;
        }

        private string ObtenerQueryOperacion(string operacion)
        {
            // Aquí puedes retornar la consulta SQL correspondiente a la operación
            string query = "";

            switch (operacion)
            {
                case "Diferencia":
                    query = "SELECT * FROM Libro " +
                        "WHERE IdIdioma = 2 AND IdLibro NOT IN " +
                        "(SELECT IdLibro FROM Libro WHERE IdPais = 3 ) " +
                        "ORDER BY 1 ASC";
                    break;
                case "Intersección":
                    query = "SELECT * FROM Libro " +
                        "WHERE IdIdioma = 2 AND " +
                        "IdLibro IN " +
                        "(SELECT IdLibro FROM Libro WHERE IdPais = 3 )" +
                        "ORDER BY 1 ASC"; ;
                    break;
                case "Juntar":
                    query = "SELECT * " +
                        "FROM Libro INNER JOIN Autor " +
                        "ON Libro.IdAutor = Autor.IdAutor";
                    break;
                case "Proyección simple":
                    query = "SELECT * " +
                        "FROM Libro";
                    break;
                case "Proyección multiatributo":
                    query = "SELECT Titulo, Año " +
                        "FROM LIBRO " +
                        "ORDER BY 1 ASC";
                    break;
                case "Union":
                    query = "SELECT * FROM Libro WHERE IdIdioma = 1 " +
                        "UNION " +
                        "SELECT * FROM Libro WHERE IdIdioma = 2";
                    break;
                case "Seleccion simple":
                    query = "SELECT Titulo, IdAutor " +
                        "FROM Libro " +
                        "WHERE IdAutor <> 5 " +
                        "ORDER BY Titulo DESC";
                    break;
                case "Seleccion multiatributo":

            }

            return query;
        }
    }
}

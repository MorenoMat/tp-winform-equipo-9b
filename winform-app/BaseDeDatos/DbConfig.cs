using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Json;

namespace winform_app.baseDeDatos
{
    // Implementación de AccesoDatos basada en el ejemplo proporcionado.
    // La conexión permanece privada; la clase expone operaciones para consultas/acciones y
    // el lector (SqlDataReader) cuando corresponde. Implementa IDisposable para liberar recursos.
    public class AccesoDatos : IDisposable
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // AppSettings moved to a separate file (EnvironmentVariables.cs)
        public AccesoDatos()
        {
            // Leer connection string directamente desde config/appsettings.json

            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var configPath = Path.Combine(baseDir, "config", "appsettings.json");
            string connectionString = null;
            if (File.Exists(configPath))
            {
                using (var fs = File.OpenRead(configPath))
                {
                    var ser = new DataContractJsonSerializer(typeof(EnvironmentVariables));
                    var settings = ser.ReadObject(fs) as EnvironmentVariables;
                    connectionString = settings?.ConnectionString;
                }
            }

            /*
            EN CASO DE NO TENER GANAS DE CONFIGURAR EL JSON PARA VARIABLES DE ENTORNO HARDCODEAR EL
            STRING DE CONEXION ACA, PERO RECOMIENDO CONFIGURARLO EN EL JSON PARA NO 
            TENER QUE COMPARTIRLO EN EL CODIGO
            */
            if (string.IsNullOrWhiteSpace(connectionString))
                connectionString = "";


            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
        }


        public void setearConsulta(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor ?? DBNull.Value);
        }

        public void cerrarConexion()
        {
            try
            {
                if (lector != null && !lector.IsClosed)
                {
                    lector.Close();
                    lector = null;
                }
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                comando.Parameters.Clear();
            }
        }

        public void Dispose()
        {
            cerrarConexion();
            comando?.Dispose();
            conexion?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

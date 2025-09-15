using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using SQL;

//server =.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true

namespace SQL
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return Lector; }
        }

        public SqlDataReader Lector
        {
            get
            {
                return lector;
            }

        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true");
            comando = new SqlCommand();


        }
        public void setearConsulta(string consulta, string codigo)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        internal void ejecutarAccion()
        {
            throw new NotImplementedException();
        }

        internal void setearConsulta(string v)
        {
            throw new NotImplementedException();
        }

        public void ejecutarAccion;
        {

            comando.Connection = conexion;

         try
            {
                conexion.Open();
                lector = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
}






        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            lector?.Close();
            conexion.Close();

        }











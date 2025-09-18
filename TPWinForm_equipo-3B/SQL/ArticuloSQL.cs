using Dominio;
using SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQL

{
    public class ArticuloSQL
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Money { get; set; }
        public int Id { get; internal set; }
        public Elemento ImagenArt { get; set; }
        public Marca Marca { get; set; }
    }

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;


                comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.ImagenUrl FROM ARTICULOS A LEFT JOIN IMAGENES I ON A.Codigo = I.IdArticulo;";

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.Money = (decimal)lector["Precio"];
                    aux.ImagenArt.ImagenUrl = (string)lector["ImagenUrl"]

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(ArticuloSQL nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS(Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria)VALUES(" + nuevo.Codigo + ", '' " + nuevo.Nombre + " , " + nuevo.Descripcion ", ''" + nuevo.IdMarca ", '' " + nuevo.IdCategoria", '' " + nuevo.Precio") ");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();

            }


            }
        public void modificar(ArticuloSQL modificar)

        {


        }

        public void eliminar(string Codigo)

        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete FROM ARTICULOS Where Id = @id");
                datos.setearConsulta("@id", Codigo);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public static void agregar(Articulo art)
        {
            throw new NotImplementedException();
        }
    }
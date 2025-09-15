using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using SQL;

namespace SQL
{
    public class Elemento
    {
        public List<Elemento> Listar()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.ImagenUrl FROM ARTICULOS A  INNER JOIN IMAGENES I ON A.Codigo = I.IdArticulo;");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {

                Elemento articulo = new Elemento();

                articulo.Id = (int)AccesoDatos.Lector["Id"];
                articulo.CodigoArticulo = (string)AccesoDatos.Lector["Codigo"];
                articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];

                lista.Add(aux);


            }


            try
            {

                ruturn lista;
            }
            catch (Exception ex)

            {
                throw ex;
            }

            finally

            {
                datos.cerrarConexion();
            }
        }







    }
}


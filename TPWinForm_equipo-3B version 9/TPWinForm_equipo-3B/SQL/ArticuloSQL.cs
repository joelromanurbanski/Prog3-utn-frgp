using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using SQL;
namespace SQL
{
    public class ArticuloSQL
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"
                    SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio,
                           M.Id AS IdMarca, M.Descripcion AS Marca,
                           C.Id AS IdCategoria, C.Descripcion AS Categoria,
                           (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id) AS ImagenUrl
                    FROM ARTICULOS A
                    LEFT JOIN MARCAS M ON A.IdMarca = M.Id
                    LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id
                    ORDER BY A.Id");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = datos.Lector["Codigo"] as string;
                    aux.Nombre = datos.Lector["Nombre"] as string;
                    aux.Descripcion = datos.Lector["Descripcion"] as string;
                    aux.Money = datos.Lector["Precio"] != DBNull.Value ? (decimal)datos.Lector["Precio"] : 0m;

                    aux.IdMarca = datos.Lector["IdMarca"] != DBNull.Value ? (int)datos.Lector["IdMarca"] : 0;
                    aux.IdCategoria = datos.Lector["IdCategoria"] != DBNull.Value ? (int)datos.Lector["IdCategoria"] : 0;

                    aux.Marca = new Marca
                    {
                        Id = aux.IdMarca,
                        Descripcion = datos.Lector["Marca"] != DBNull.Value ? (string)datos.Lector["Marca"] : null
                    };

                    aux.Categoria = new Categoria
                    {
                        Id = aux.IdCategoria,
                        Descripcion = datos.Lector["Categoria"] != DBNull.Value ? (string)datos.Lector["Categoria"] : null
                    };

                    aux.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value ? (string)datos.Lector["ImagenUrl"] : null;

                    lista.Add(aux);
                }

                return lista;
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

   
        public int Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"INSERT INTO ARTICULOS
                    (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                    OUTPUT INSERTED.Id
                    VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria);
                datos.setearParametro("@Precio", nuevo.Money);

                object resultado = datos.ejecutarEscalar();
                int idGenerado = resultado != null ? Convert.ToInt32(resultado) : 0;
                return idGenerado;
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

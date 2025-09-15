using System.Xml.Linq;

namespace Dominio

{
    public class Articulo
    {
        internal string UrlImagen;

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
}
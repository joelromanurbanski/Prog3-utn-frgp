using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Money { get; set; } 
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string UrlImagen { get; set; }  
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}

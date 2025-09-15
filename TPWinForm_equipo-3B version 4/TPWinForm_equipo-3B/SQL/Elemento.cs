using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Elemento
    {
        public int Id { get; set; }
        public string UrlImagen { get; set; }
        public string ImagenUrl { get; internal set; }
    }
}

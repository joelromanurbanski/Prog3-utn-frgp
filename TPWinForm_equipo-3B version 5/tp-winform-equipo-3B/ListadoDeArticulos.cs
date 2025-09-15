using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_3B
{
    public partial class ListadoDeArticulos : Form
    {
        private List<Articulo> ListaArticulos;

        public ListadoDeArticulos()
        {
            InitializeComponent();
        }

        private void ListadoDeArticulos_Load(object sender, EventArgs e)
        {
            ArticuloSQL articuloSQL = new ArticuloSQL();
            ListaArticulos = articuloSQL.Listar();
            ListadoLista.DataSource = ListaArticulos;

      
            if (ListaArticulos.Count > 0)
                cargarImagen(ListaArticulos[0].UrlImagen);
        }

        private void ListadoLista_SelectionChanged(object sender, EventArgs e)
        {
            if (ListadoLista.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)ListadoLista.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                    PictureBoxArt.Load(imagen);  
                else
                    PictureBoxArt.Load("https://via.placeholder.com/200x200?text=Sin+Imagen");
            }
            catch
            {
                PictureBoxArt.Load("https://static.vecteezy.com/system/resources/previews/017/173/007/non_2x/can-not-load-corrupted-image-concept-illustration-flat-design-eps10-modern-graphic-element-for-landing-page-empty-state-ui-infographic-icon-vector.jpg");
            }
        }
    }
}

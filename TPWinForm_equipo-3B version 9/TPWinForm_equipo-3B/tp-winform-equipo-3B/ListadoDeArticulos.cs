using Dominio;
using SQL;
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

            ListadoLista.AutoGenerateColumns = false;

            ListadoLista.Columns.Clear();

            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });
            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción"
            });
            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Money",
                HeaderText = "Precio $"
            });
            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Marca",
                HeaderText = "Marca"
            });
            ListadoLista.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoría"
            });

            ListadoLista.DataSource = ListaArticulos;

            ListadoLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (ListaArticulos.Count > 0)
                cargarImagen(ListaArticulos[0].UrlImagen);
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
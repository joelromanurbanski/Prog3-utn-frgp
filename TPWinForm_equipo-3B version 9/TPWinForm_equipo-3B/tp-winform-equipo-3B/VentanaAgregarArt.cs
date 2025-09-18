using Dominio;
using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace tp_winform_equipo_3B
{
    public partial class VentanaAgregarArt : Form
    {
        public VentanaAgregarArt()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloSQL articuloSQL = new ArticuloSQL();

            try
            {
                art.Codigo = CodigoText.Text;
                art.Nombre = NombreText.Text;
                art.Descripcion = DescripcionText.Text;
                art.IdMarca = (int)MarcaBox.SelectedValue;
                art.IdCategoria = (int)CategoriaBox.SelectedValue;
                art.Money = Convert.ToDecimal(PrecioText.Text);

                // Insertar artículo
                articuloSQL.Agregar(art);

                MessageBox.Show("✅ PRODUCTO AGREGADO CON ÉXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void VentanaAgregarArt_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaSQL marcaSQL = new MarcaSQL();
                CategoriaSQL categoriaSQL = new CategoriaSQL();

                MarcaBox.DataSource = marcaSQL.Listar();
                MarcaBox.ValueMember = "Id";
                MarcaBox.DisplayMember = "Descripcion";

                CategoriaBox.DataSource = categoriaSQL.Listar();
                CategoriaBox.ValueMember = "Id";
                CategoriaBox.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }
    }
}

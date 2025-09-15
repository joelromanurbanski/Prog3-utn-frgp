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

            Articulo Art=new Articulo();
            ArticuloSQL articuloSQL = new ArticuloSQL();


            try
            {
                Art.Codigo = (CodigoText.Text);
                Art.Nombre = (NombreText.Text);
                Art.Descripcion = (DescripcionText.Text);
                Art.IdMarca = (IdMarca)MarcaBox.SelectedItem;
                Art.IdCategoria = (IdCategoria)CategoriaBox.SelectedItem;
                Art.Money = Convert.ToDecimal(PrecioText.Text);
                //imagen.UrlImagen = txtUrlImagen.Text;

                ArticuloSQL.agregar(Art);
                
                MessageBox.Show("PRODUCTO AGREGADO CON EXITO");

                Close();
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}

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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Button1_click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void AgregarArticuloClick(object sender, EventArgs e)
        {
            VentanaAgregarArt ventana = new VentanaAgregarArt();
            ventana.Show();
        }

        private void BuscarArticuloClick(object sender, EventArgs e)
        {
            BuscarArticulo ventana = new BuscarArticulo();
            ventana.Show();
        }

        private void ListadoDeArticulosClick(object sender, EventArgs e)
        {
            ListadoDeArticulos ventana = new ListadoDeArticulos();
            ventana.Show();
        }

        private void VerUnArticuloClick(object sender, EventArgs e)
        {
            VerArticulo ventana = new VerArticulo();
            ventana.Show();
        }

        private void ModificarClick(object sender, EventArgs e)
        {
            Modificar ventana = new Modificar();
            ventana.Show();
        }

        private void EliminarClick(object sender, EventArgs e)
        {
            Eliminar ventana = new Eliminar();
            ventana.Show();
        }
    }
}

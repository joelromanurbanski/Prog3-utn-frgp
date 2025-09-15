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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void EliminarArtBoton_Click(object sender, EventArgs e)
        {

            ArticuloSQL articuloSQL = new ArticuloSQL();
            ArticuloSQL seleccionado
            try
            {
                seleccionado = (ArticuloSQL)EliminarArtTextBox.CurrentRow.DataBoundItem;
                articuloSQL.eliminar(seleccionado.Id);
                cargar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}

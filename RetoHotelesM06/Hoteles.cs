using RetoHotelesM06.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoHotelesM06
{
    public partial class Hoteles : Form
    {
        public Boolean hotelBoo = true;
        public Hoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (hotelBoo)
                {
                    hoteles hotel = (hoteles)dataGridView1.CurrentRow.DataBoundItem;
                    añadirHotel f = new añadirHotel(false);
                    f.ShowDialog();
                }
                else
                {
                    cadenas cadena = (cadenas)dataGridView1.CurrentRow.DataBoundItem;
                    AñadirCadena f = new AñadirCadena(false);
                    f.ShowDialog();
                }
            }
        }

        private void ButtonHoteles_Click(object sender, EventArgs e)
        {
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
            hotelBoo = true;
        }

        private void bindingSourceHoteles_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCadenasHoteles_Click(object sender, EventArgs e)
        {
            bindingSourceHoteles.DataSource = CadenasOrm.Select();
            hotelBoo = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (hotelBoo)
            {
                hoteles hotel = (hoteles)dataGridView1.CurrentRow.DataBoundItem;
                String msg = HotelesOrm.DeleteHotel(hotel);
                MessageBox.Show("Eliminado");
                actualizar();
            }
            else
            {
                cadenas cadena = (cadenas)dataGridView1.CurrentRow.DataBoundItem;
                String msg = CadenasOrm.DeleteCadena(cadena);
                MessageBox.Show("Eliminado");
                actualizar();
            }
            
        }

        private void actualizar()
        {
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (hotelBoo)
                {
                    hoteles hotel = (hoteles)dataGridView1.CurrentRow.DataBoundItem;
                    añadirHotel f = new añadirHotel(hotel);
                    f.ShowDialog();
                }
                else
                {
                    cadenas cadena = (cadenas)dataGridView1.CurrentRow.DataBoundItem;
                    AñadirCadena f = new AñadirCadena(cadena);
                    f.ShowDialog();
                }
            }
        }
    }
}

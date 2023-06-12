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
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            actualizarHotel();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count > 0)
            {
                if (hotelBoo)
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    hoteles hotel = (hoteles)dataGridView1.CurrentRow.DataBoundItem;
                    añadirHotel f = new añadirHotel(false);
                    f.ShowDialog();
                    actualizarHotel();
                }
                else
                {
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    cadenas cadena = (cadenas)dataGridView2.CurrentRow.DataBoundItem;
                    AñadirCadena f = new AñadirCadena(false);
                    f.ShowDialog();
                    actualizarCadenas();
                }
            }
        }

        private void ButtonHoteles_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
            hotelBoo = true;
        }

        private void bindingSourceHoteles_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCadenasHoteles_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            cadenasBindingSource.DataSource = CadenasOrm.Select();
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
                if (msg == "")
                {
                    MessageBox.Show("Eliminado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                actualizarHotel();
            }
            else
            {
                cadenas cadena = (cadenas)dataGridView2.CurrentRow.DataBoundItem;
                String msg = CadenasOrm.DeleteCadena(cadena);
                if (msg == "")
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarCadenas();
            }
        }

        private void actualizarHotel()
        {
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
        }
        private void actualizarCadenas()
        {
            cadenasBindingSource.DataSource = CadenasOrm.Select();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count > 0)
            {

                if (hotelBoo)
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    hoteles hotel = (hoteles)dataGridView1.CurrentRow.DataBoundItem;
                    añadirHotel f = new añadirHotel(hotel);
                    f.ShowDialog();
                    actualizarHotel();
                }
                else
                {
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    cadenas cadena = (cadenas)dataGridView2.CurrentRow.DataBoundItem;
                    AñadirCadena f = new AñadirCadena(cadena);
                    f.ShowDialog();
                    actualizarCadenas();
                }
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Verifica que se esté formateando la columna de identificador de cadena
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string nombreCadena = CadenasOrm.SelectNombreCadenaById(id); // Obtener el nombre de la cadena según el identificador
                e.Value = nombreCadena; // Asignar el nombre de la cadena al valor de la celda
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Verifica que se esté formateando la columna de cif de la cadena
            {
                string cif = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                string nombreCiudad = GetNombreCiudadByCif(cif); // Obtener el nombre de la ciudad según el cif
                e.Value = nombreCiudad; // Asignar el nombre de la ciudad al valor de la celda
            }
        }

        private string GetNombreCiudadByCif(string cif)
        {
            var hotel = bindingSourceHoteles.List.OfType<hoteles>().FirstOrDefault(h => h.cif == cif);
            if (hotel != null)
            {
                return hotel.ciudades.nombre;
            }
            return string.Empty;
        }
    }
    
}

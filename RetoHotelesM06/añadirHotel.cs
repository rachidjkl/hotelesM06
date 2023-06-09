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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RetoHotelesM06
{
    public partial class añadirHotel : Form
    {
        public hoteles hotelSelec;
        public Boolean relleno = true;
        public añadirHotel(hoteles hotel)
        {
            InitializeComponent();
            hotelSelec = hotel;
        }

        public añadirHotel(Boolean relleno)
        {
            InitializeComponent();
            this.relleno = relleno;
        }

        private void añadirHotel_Load(object sender, EventArgs e)
        {

            actividadesBindingSource.DataSource = ActividadesOrm.SelectActividades();
            cadenasBindingSource.DataSource = CadenasOrm.Select();
            ciudadesBindingSource.DataSource = CiudadesOrm.SelectCiudades();

            if (relleno == true)
            {
                textBoxNombre.Text = hotelSelec.nombre.ToString();
                comboBoxCadenaHotel.SelectedItem = hotelSelec.cadenas;
                comboBoxCiudad.SelectedItem = hotelSelec.ciudades;
                comboBoxCiudad.DropDownStyle = ComboBoxStyle.Simple;
                comboBoxCiudad.Enabled = false;
                textBoxUbicacion.Text = hotelSelec.tipo.ToString();
                textBoxTelefono.Text = hotelSelec.telefono.ToString();
                textBoxCategoria.Text = hotelSelec.categoria.ToString();
                textBoxDireccion.Text = hotelSelec.direccion.ToString();
                CargarActHotel(hotelSelec.act_hotel.ToList());
            }   
        }

        private void ciudadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void actividadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (relleno == true)
            {
                hoteles hotelToUpdate = cogerHotel();

                string msgError = HotelesOrm.UpdateHotel(hotelSelec, hotelToUpdate);
                if (msgError == "")
                {
                    MessageBox.Show("Updated", "actualizado", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                hoteles hotel = new hoteles();
                hotel.nombre = textBoxNombre.Text;
                hotel.id_ciudad = (int)comboBoxCiudad.SelectedValue;
                hotel.act_hotel = GetActHotel();
                hotel.categoria = int.Parse(textBoxCategoria.Text);
                hotel.telefono = int.Parse(textBoxTelefono.Text);
                hotel.direccion = textBoxDireccion.Text;
                hotel.cadenas = (cadenas)comboBoxCadenaHotel.SelectedItem;
                hotel.ciudades = (ciudades)comboBoxCiudad.SelectedItem;
                hotel.cif = comboBox1.SelectedValue.ToString();
                hotel.tipo = textBoxUbicacion.Text;


                string msgError = HotelesOrm.Add(hotel);
                if (msgError == "")
                {
                    MessageBox.Show("Saved", "guardado", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private hoteles cogerHotel()
        {
            hoteles hotelToUpdate = new hoteles()
            {
                id_ciudad = hotelSelec.id_ciudad,
                direccion = textBoxDireccion.Text,
                telefono = int.Parse(textBoxTelefono.Text),
                tipo = textBoxUbicacion.Text,
                categoria = int.Parse(textBoxCategoria.Text),
                cadenas = (cadenas)comboBoxCadenaHotel.SelectedItem,
                ciudades = (ciudades)comboBoxCiudad.SelectedItem,
                act_hotel = GetActHotel()
            };

            return hotelToUpdate;
        }

        private List<act_hotel> GetActHotel()
        {
            List<act_hotel> listaActividades = new List<act_hotel>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                act_hotel actividad = new act_hotel();

                actividad.id_act = Convert.ToInt32(row.Cells[0].Value);
                actividad.nombre = row.Cells[1].Value.ToString();
                actividad.grado = Convert.ToInt32(row.Cells[2].Value);
                actividad.id_ciudad = (int)comboBoxCiudad.SelectedValue;
                listaActividades.Add(actividad);   
            }

            return listaActividades;
        }

        private void CargarActHotel(List<act_hotel> act_Hotel)
        {
            foreach (act_hotel act in act_Hotel)
            {
                dataGridView1.Rows.Add();
                int rowIndex = dataGridView1.Rows.Count - 1;

                dataGridView1.Rows[rowIndex].Cells[0].Value = act.id_act;
                dataGridView1.Rows[rowIndex].Cells[1].Value = act.actividades.descripcion;
                dataGridView1.Rows[rowIndex].Cells[2].Value = act.grado;
            }
        }

        private void actividadesBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actividades selectedActividad = comboBox1.SelectedItem as actividades;

            if (selectedActividad != null)
            {
                textBox9.Text = ActividadesOrm.SelectGrado(selectedActividad).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idAct = (int)comboBox1.SelectedValue;
            string nombre = comboBox1.Text;
            int grado = int.Parse(textBox9.Text);

            if (!comprobacionRepit(idAct))
            {
                dataGridView1.Rows.Add();

                int rowIndex = dataGridView1.Rows.Count - 1;

                dataGridView1.Rows[rowIndex].Cells[0].Value = idAct;
                dataGridView1.Rows[rowIndex].Cells[1].Value = nombre;
                dataGridView1.Rows[rowIndex].Cells[2].Value = grado;
            }
        }

        private Boolean comprobacionRepit(int idAct)
        {
            Boolean result = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && (int)row.Cells[0].Value == idAct)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow act = dataGridView1.CurrentRow;

            if (act != null)
            {
                dataGridView1.Rows.Remove(act);
            }
        }
    }
}

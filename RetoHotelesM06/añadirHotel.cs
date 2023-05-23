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
        public añadirHotel(hoteles hotel)
        {
            InitializeComponent();
            hotelSelec = hotel;
        }

        private void añadirHotel_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = hotelSelec.nombre.ToString();
            comboBoxCadenaHotel.SelectedItem = hotelSelec.cadenas;
            comboBoxCiudad.SelectedItem = hotelSelec.ciudades;
            textBoxUbicacion.Text = hotelSelec.tipo.ToString();
            textBoxTelefono.Text = hotelSelec.telefono.ToString();
            textBoxCategoria.Text = hotelSelec.categoria.ToString();
            textBoxDireccion.Text = hotelSelec.direccion.ToString();
            actividadesBindingSource.DataSource = ActividadesOrm.SelectActividades(hotelSelec);
            cadenasBindingSource.DataSource = CadenasOrm.Select();
            ciudadesBindingSource.DataSource = CiudadesOrm.SelectCiudades();
        }

        private void ciudadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void actividadesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

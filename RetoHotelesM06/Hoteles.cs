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
        public Hoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHoteles_Click(object sender, EventArgs e)
        {
            bindingSourceHoteles.DataSource = HotelesOrm.Select();
        }

        private void bindingSourceHoteles_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadenasHoteles_Click(object sender, EventArgs e)
        {
            bindingSourceHoteles.DataSource = CadenasOrm.Select();

        }
    }
}

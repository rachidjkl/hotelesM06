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
    public partial class AñadirCadena : Form
    {
        cadenas cadenaSele;
        Boolean relleno = true;
        public AñadirCadena(cadenas cadena)
        {
            InitializeComponent();
            cadenaSele = cadena;
        }
        public AñadirCadena(Boolean relleno)
        {
            InitializeComponent();
            this.relleno = relleno;
        }

        private void AñadirCadena_Load(object sender, EventArgs e)
        {
            if (relleno == true) 
            {
                cargarCadena(cadenaSele);
            }

        }

        private void cargarCadena(cadenas cadena)
        {
            textBox3.Text = cadena.cif;
            textBox2.Text = cadena.dir_fis;
            textBox1.Text = cadena.nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadenas update = cogerCadena();
            if (relleno == true)
            {
                string msgError = CadenasOrm.UpdateCadena(cadenaSele, update);
                if (msgError == "")
                {
                    MessageBox.Show("Updated", "actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String msgError = CadenasOrm.AddCadena(update);
                if (msgError == "")
                {
                    MessageBox.Show("Saved", "guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private cadenas cogerCadena()
        {
            cadenas cadenaToUpdate = new cadenas()
            {
                cif = textBox3.Text,
                dir_fis = textBox2.Text,
                nombre = textBox1.Text
            };

            return cadenaToUpdate;
        }
    }
}

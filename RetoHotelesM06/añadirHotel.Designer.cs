namespace RetoHotelesM06
{
    partial class añadirHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCadenaHotel = new System.Windows.Forms.ComboBox();
            this.cadenasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.DataSource = this.ciudadesBindingSource;
            this.comboBoxCiudad.DisplayMember = "nombre";
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(109, 174);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudad.TabIndex = 41;
            this.comboBoxCiudad.ValueMember = "id_ciudad";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataSource = typeof(RetoHotelesM06.Models.ciudades);
            this.ciudadesBindingSource.CurrentChanged += new System.EventHandler(this.ciudadesBindingSource_CurrentChanged);
            // 
            // comboBoxCadenaHotel
            // 
            this.comboBoxCadenaHotel.DataSource = this.cadenasBindingSource;
            this.comboBoxCadenaHotel.DisplayMember = "nombre";
            this.comboBoxCadenaHotel.FormattingEnabled = true;
            this.comboBoxCadenaHotel.Location = new System.Drawing.Point(110, 86);
            this.comboBoxCadenaHotel.Name = "comboBoxCadenaHotel";
            this.comboBoxCadenaHotel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCadenaHotel.TabIndex = 40;
            this.comboBoxCadenaHotel.ValueMember = "cif";
            // 
            // cadenasBindingSource
            // 
            this.cadenasBindingSource.DataSource = typeof(RetoHotelesM06.Models.cadenas);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(692, 416);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 39;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(653, 211);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 20);
            this.textBox9.TabIndex = 37;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(477, 211);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(170, 20);
            this.textBox8.TabIndex = 36;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(515, 92);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 35;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(515, 11);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoria.TabIndex = 34;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(109, 350);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(122, 20);
            this.textBoxTelefono.TabIndex = 33;
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Location = new System.Drawing.Point(109, 258);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(122, 20);
            this.textBoxUbicacion.TabIndex = 32;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(109, 11);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(122, 20);
            this.textBoxNombre.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Grado dificultad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cadena hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Actividades del hotel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(738, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataSource = typeof(RetoHotelesM06.Models.act_hotel);
            this.actividadesBindingSource.CurrentChanged += new System.EventHandler(this.actividadesBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actividadesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(442, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 127);
            this.dataGridView1.TabIndex = 44;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // añadirHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxCiudad);
            this.Controls.Add(this.comboBoxCadenaHotel);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "añadirHotel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.añadirHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.ComboBox comboBoxCadenaHotel;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private System.Windows.Forms.BindingSource cadenasBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
    }
}
﻿namespace RetoHotelesM06
{
    partial class Hoteles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.ButtonAñadir = new System.Windows.Forms.Button();
            this.buttonCadenasHoteles = new System.Windows.Forms.Button();
            this.ButtonHoteles = new System.Windows.Forms.Button();
            this.bindingSourceHoteles = new System.Windows.Forms.BindingSource(this.components);
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acthotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadenasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1009, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(851, 127);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idciudadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.acthotelDataGridViewTextBoxColumn,
            this.cadenasDataGridViewTextBoxColumn,
            this.ciudadesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceHoteles;
            this.dataGridView1.Location = new System.Drawing.Point(41, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 459);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hoteles";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(1009, 127);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // ButtonAñadir
            // 
            this.ButtonAñadir.Location = new System.Drawing.Point(770, 127);
            this.ButtonAñadir.Name = "ButtonAñadir";
            this.ButtonAñadir.Size = new System.Drawing.Size(75, 23);
            this.ButtonAñadir.TabIndex = 5;
            this.ButtonAñadir.Text = "Añadir";
            this.ButtonAñadir.UseVisualStyleBackColor = true;
            this.ButtonAñadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // buttonCadenasHoteles
            // 
            this.buttonCadenasHoteles.Location = new System.Drawing.Point(99, 127);
            this.buttonCadenasHoteles.Name = "buttonCadenasHoteles";
            this.buttonCadenasHoteles.Size = new System.Drawing.Size(118, 23);
            this.buttonCadenasHoteles.TabIndex = 6;
            this.buttonCadenasHoteles.Text = "Cadenas Hoteles";
            this.buttonCadenasHoteles.UseVisualStyleBackColor = true;
            // 
            // ButtonHoteles
            // 
            this.ButtonHoteles.Location = new System.Drawing.Point(236, 127);
            this.ButtonHoteles.Name = "ButtonHoteles";
            this.ButtonHoteles.Size = new System.Drawing.Size(75, 23);
            this.ButtonHoteles.TabIndex = 7;
            this.ButtonHoteles.Text = "Hoteles";
            this.ButtonHoteles.UseVisualStyleBackColor = true;
            this.ButtonHoteles.Click += new System.EventHandler(this.ButtonHoteles_Click);
            // 
            // bindingSourceHoteles
            // 
            this.bindingSourceHoteles.DataSource = typeof(RetoHotelesM06.Models.hoteles);
            this.bindingSourceHoteles.CurrentChanged += new System.EventHandler(this.bindingSourceHoteles_CurrentChanged);
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "cif";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            // 
            // acthotelDataGridViewTextBoxColumn
            // 
            this.acthotelDataGridViewTextBoxColumn.DataPropertyName = "act_hotel";
            this.acthotelDataGridViewTextBoxColumn.HeaderText = "act_hotel";
            this.acthotelDataGridViewTextBoxColumn.Name = "acthotelDataGridViewTextBoxColumn";
            // 
            // cadenasDataGridViewTextBoxColumn
            // 
            this.cadenasDataGridViewTextBoxColumn.DataPropertyName = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.HeaderText = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.Name = "cadenasDataGridViewTextBoxColumn";
            // 
            // ciudadesDataGridViewTextBoxColumn
            // 
            this.ciudadesDataGridViewTextBoxColumn.DataPropertyName = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.HeaderText = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.Name = "ciudadesDataGridViewTextBoxColumn";
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 707);
            this.Controls.Add(this.ButtonHoteles);
            this.Controls.Add(this.buttonCadenasHoteles);
            this.Controls.Add(this.ButtonAñadir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.button1);
            this.Name = "Hoteles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button ButtonAñadir;
        private System.Windows.Forms.Button buttonCadenasHoteles;
        private System.Windows.Forms.Button ButtonHoteles;
        private System.Windows.Forms.BindingSource bindingSourceHoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acthotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadenasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadesDataGridViewTextBoxColumn;
    }
}

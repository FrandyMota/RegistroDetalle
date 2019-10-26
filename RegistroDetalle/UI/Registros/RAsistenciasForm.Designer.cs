namespace RegistroDetalle.UI.Registros
{
    partial class RAsistenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAsistenciasForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AsistenciasdataGridView = new System.Windows.Forms.DataGridView();
            this.REstudiantesFormbutton = new System.Windows.Forms.Button();
            this.AgregarAsistenciabutton = new System.Windows.Forms.Button();
            this.PresentecheckBox = new System.Windows.Forms.CheckBox();
            this.EstudiantecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AsignaturacomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AsistenciaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AsistenciasdataGridView);
            this.groupBox1.Controls.Add(this.REstudiantesFormbutton);
            this.groupBox1.Controls.Add(this.AgregarAsistenciabutton);
            this.groupBox1.Controls.Add(this.PresentecheckBox);
            this.groupBox1.Controls.Add(this.EstudiantecomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 249);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(64, 218);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(93, 20);
            this.CantidadtextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad:";
            // 
            // AsistenciasdataGridView
            // 
            this.AsistenciasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistenciasdataGridView.Location = new System.Drawing.Point(9, 59);
            this.AsistenciasdataGridView.Name = "AsistenciasdataGridView";
            this.AsistenciasdataGridView.Size = new System.Drawing.Size(325, 150);
            this.AsistenciasdataGridView.TabIndex = 11;
            // 
            // REstudiantesFormbutton
            // 
            this.REstudiantesFormbutton.Image = ((System.Drawing.Image)(resources.GetObject("REstudiantesFormbutton.Image")));
            this.REstudiantesFormbutton.Location = new System.Drawing.Point(208, 31);
            this.REstudiantesFormbutton.Name = "REstudiantesFormbutton";
            this.REstudiantesFormbutton.Size = new System.Drawing.Size(27, 23);
            this.REstudiantesFormbutton.TabIndex = 10;
            this.REstudiantesFormbutton.UseVisualStyleBackColor = true;
            this.REstudiantesFormbutton.Click += new System.EventHandler(this.REstudiantesFormbutton_Click);
            // 
            // AgregarAsistenciabutton
            // 
            this.AgregarAsistenciabutton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAsistenciabutton.Image")));
            this.AgregarAsistenciabutton.Location = new System.Drawing.Point(307, 31);
            this.AgregarAsistenciabutton.Name = "AgregarAsistenciabutton";
            this.AgregarAsistenciabutton.Size = new System.Drawing.Size(27, 23);
            this.AgregarAsistenciabutton.TabIndex = 9;
            this.AgregarAsistenciabutton.UseVisualStyleBackColor = true;
            this.AgregarAsistenciabutton.Click += new System.EventHandler(this.AgregarAsistenciabutton_Click);
            // 
            // PresentecheckBox
            // 
            this.PresentecheckBox.AutoSize = true;
            this.PresentecheckBox.Location = new System.Drawing.Point(241, 36);
            this.PresentecheckBox.Name = "PresentecheckBox";
            this.PresentecheckBox.Size = new System.Drawing.Size(68, 17);
            this.PresentecheckBox.TabIndex = 5;
            this.PresentecheckBox.Text = "Presente";
            this.PresentecheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudiantecomboBox
            // 
            this.EstudiantecomboBox.FormattingEnabled = true;
            this.EstudiantecomboBox.Location = new System.Drawing.Point(9, 32);
            this.EstudiantecomboBox.Name = "EstudiantecomboBox";
            this.EstudiantecomboBox.Size = new System.Drawing.Size(193, 21);
            this.EstudiantecomboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estudiante:";
            // 
            // AsignaturacomboBox
            // 
            this.AsignaturacomboBox.FormattingEnabled = true;
            this.AsignaturacomboBox.Location = new System.Drawing.Point(86, 45);
            this.AsignaturacomboBox.Name = "AsignaturacomboBox";
            this.AsignaturacomboBox.Size = new System.Drawing.Size(277, 21);
            this.AsignaturacomboBox.TabIndex = 14;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(284, 14);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.FechadateTimePicker.TabIndex = 13;
            // 
            // AsistenciaIdnumericUpDown
            // 
            this.AsistenciaIdnumericUpDown.Location = new System.Drawing.Point(45, 14);
            this.AsistenciaIdnumericUpDown.Name = "AsistenciaIdnumericUpDown";
            this.AsistenciaIdnumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.AsistenciaIdnumericUpDown.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Asignatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(124, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(29, 347);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(165, 347);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(288, 347);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // RAsistenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 396);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AsignaturacomboBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.AsistenciaIdnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RAsistenciasForm";
            this.Text = "Registro Asistencias";
            this.Load += new System.EventHandler(this.RAsistenciasForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView AsistenciasdataGridView;
        private System.Windows.Forms.Button REstudiantesFormbutton;
        private System.Windows.Forms.Button AgregarAsistenciabutton;
        private System.Windows.Forms.CheckBox PresentecheckBox;
        private System.Windows.Forms.ComboBox EstudiantecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AsignaturacomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown AsistenciaIdnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}
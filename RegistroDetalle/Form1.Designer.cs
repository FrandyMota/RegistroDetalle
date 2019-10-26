namespace RegistroDetalle
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAsistenciasToolStripMenuItem,
            this.registroAsignaturasToolStripMenuItem,
            this.registroEstudiantesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaAsistenciasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // registroAsistenciasToolStripMenuItem
            // 
            this.registroAsistenciasToolStripMenuItem.Name = "registroAsistenciasToolStripMenuItem";
            this.registroAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroAsistenciasToolStripMenuItem.Text = "Registro Asistencias";
            this.registroAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.registroAsistenciasToolStripMenuItem_Click);
            // 
            // registroAsignaturasToolStripMenuItem
            // 
            this.registroAsignaturasToolStripMenuItem.Name = "registroAsignaturasToolStripMenuItem";
            this.registroAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroAsignaturasToolStripMenuItem.Text = "Registro Asignaturas";
            this.registroAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.registroAsignaturasToolStripMenuItem_Click);
            // 
            // registroEstudiantesToolStripMenuItem
            // 
            this.registroEstudiantesToolStripMenuItem.Name = "registroEstudiantesToolStripMenuItem";
            this.registroEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroEstudiantesToolStripMenuItem.Text = "Registro Estudiantes";
            this.registroEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.registroEstudiantesToolStripMenuItem_Click);
            // 
            // consultaAsistenciasToolStripMenuItem
            // 
            this.consultaAsistenciasToolStripMenuItem.Name = "consultaAsistenciasToolStripMenuItem";
            this.consultaAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaAsistenciasToolStripMenuItem.Text = "Consulta Asistencias";
            this.consultaAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.consultaAsistenciasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAsistenciasToolStripMenuItem;
    }
}


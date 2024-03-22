namespace HistoriasClinicas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarHistorialClinicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPacientesYOSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verConsultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.cuentaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.cuentaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.cuentaToolStripMenuItem.Text = "CUENTA";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacientesToolStripMenuItem,
            this.agregarObraSocialToolStripMenuItem,
            this.agregarHistorialClinicoToolStripMenuItem,
            this.agregarEstudiosToolStripMenuItem,
            this.agregarMedicacionToolStripMenuItem1,
            this.modificarPacientesToolStripMenuItem,
            this.eliminarPacientesYOSocialesToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.pacientesToolStripMenuItem.Text = "PACIENTES";
            // 
            // agregarPacientesToolStripMenuItem
            // 
            this.agregarPacientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.agregarPacientesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarPacientesToolStripMenuItem.Name = "agregarPacientesToolStripMenuItem";
            this.agregarPacientesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.agregarPacientesToolStripMenuItem.Text = "Agregar Pacientes";
            this.agregarPacientesToolStripMenuItem.Click += new System.EventHandler(this.agregarPacientesToolStripMenuItem_Click);
            // 
            // agregarObraSocialToolStripMenuItem
            // 
            this.agregarObraSocialToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.agregarObraSocialToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.agregarObraSocialToolStripMenuItem.Name = "agregarObraSocialToolStripMenuItem";
            this.agregarObraSocialToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.agregarObraSocialToolStripMenuItem.Text = "Agregar Obra Social";
            this.agregarObraSocialToolStripMenuItem.Click += new System.EventHandler(this.agregarObraSocialToolStripMenuItem_Click);
            // 
            // agregarHistorialClinicoToolStripMenuItem
            // 
            this.agregarHistorialClinicoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregarHistorialClinicoToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.agregarHistorialClinicoToolStripMenuItem.Name = "agregarHistorialClinicoToolStripMenuItem";
            this.agregarHistorialClinicoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.agregarHistorialClinicoToolStripMenuItem.Text = "Agregar Historial Clinico";
            this.agregarHistorialClinicoToolStripMenuItem.Click += new System.EventHandler(this.agregarHistorialClinicoToolStripMenuItem_Click);
            // 
            // agregarEstudiosToolStripMenuItem
            // 
            this.agregarEstudiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregarEstudiosToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.agregarEstudiosToolStripMenuItem.Name = "agregarEstudiosToolStripMenuItem";
            this.agregarEstudiosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.agregarEstudiosToolStripMenuItem.Text = "Agregar Estudios";
            this.agregarEstudiosToolStripMenuItem.Click += new System.EventHandler(this.agregarEstudiosToolStripMenuItem_Click);
            // 
            // agregarMedicacionToolStripMenuItem1
            // 
            this.agregarMedicacionToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.agregarMedicacionToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.agregarMedicacionToolStripMenuItem1.Name = "agregarMedicacionToolStripMenuItem1";
            this.agregarMedicacionToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.agregarMedicacionToolStripMenuItem1.Text = "Agregar Medicacion";
            this.agregarMedicacionToolStripMenuItem1.Click += new System.EventHandler(this.agregarMedicacionToolStripMenuItem1_Click);
            // 
            // modificarPacientesToolStripMenuItem
            // 
            this.modificarPacientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.modificarPacientesToolStripMenuItem.Name = "modificarPacientesToolStripMenuItem";
            this.modificarPacientesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.modificarPacientesToolStripMenuItem.Text = "Modificar Pacientes";
            this.modificarPacientesToolStripMenuItem.Click += new System.EventHandler(this.modificarPacientesToolStripMenuItem_Click);
            // 
            // eliminarPacientesYOSocialesToolStripMenuItem
            // 
            this.eliminarPacientesYOSocialesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eliminarPacientesYOSocialesToolStripMenuItem.Name = "eliminarPacientesYOSocialesToolStripMenuItem";
            this.eliminarPacientesYOSocialesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.eliminarPacientesYOSocialesToolStripMenuItem.Text = "Eliminar Pacientes y OSociales";
            this.eliminarPacientesYOSocialesToolStripMenuItem.Click += new System.EventHandler(this.eliminarPacientesYOSocialesToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPacientesToolStripMenuItem,
            this.verConsultasToolStripMenuItem1});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // verPacientesToolStripMenuItem
            // 
            this.verPacientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verPacientesToolStripMenuItem.Name = "verPacientesToolStripMenuItem";
            this.verPacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPacientesToolStripMenuItem.Text = "Ver Pacientes";
            this.verPacientesToolStripMenuItem.Click += new System.EventHandler(this.verPacientesToolStripMenuItem_Click);
            // 
            // verConsultasToolStripMenuItem1
            // 
            this.verConsultasToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.verConsultasToolStripMenuItem1.Name = "verConsultasToolStripMenuItem1";
            this.verConsultasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verConsultasToolStripMenuItem1.Text = "Ver Consultas";
            this.verConsultasToolStripMenuItem1.Click += new System.EventHandler(this.verConsultasToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIAS CLINICAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HistoriasClinicas.Properties.Resources.UTN;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(383, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(677, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "INTEGRANTES: ALVAREZ LUCAS - ENORA JOEL - ZARATE FRANCO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "MATERIA: LABORATORIO III";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(205, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "PROFESOR: PLACIDO EMILIO MAIDANA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(348, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "AÑO: 2023";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(649, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "FECHA Y HORA";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HistoriasClinicas.Properties.Resources.FondoMadera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AGENDA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarHistorialClinicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEstudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarObraSocialToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem modificarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacientesYOSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verConsultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verPacientesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}


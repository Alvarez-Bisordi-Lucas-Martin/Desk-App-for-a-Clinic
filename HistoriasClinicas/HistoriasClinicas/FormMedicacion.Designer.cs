namespace HistoriasClinicas
{
    partial class FormMedicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicacion));
            this.buttonGuardarMedicacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDMedicacion = new System.Windows.Forms.TextBox();
            this.txtDroga = new System.Windows.Forms.TextBox();
            this.txtPrescripcion = new System.Windows.Forms.TextBox();
            this.txtReceta = new System.Windows.Forms.TextBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonGuardarMedicacion
            // 
            this.buttonGuardarMedicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuardarMedicacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonGuardarMedicacion.Location = new System.Drawing.Point(34, 274);
            this.buttonGuardarMedicacion.Name = "buttonGuardarMedicacion";
            this.buttonGuardarMedicacion.Size = new System.Drawing.Size(384, 37);
            this.buttonGuardarMedicacion.TabIndex = 0;
            this.buttonGuardarMedicacion.Text = "GUARDAR";
            this.buttonGuardarMedicacion.UseVisualStyleBackColor = false;
            this.buttonGuardarMedicacion.Click += new System.EventHandler(this.buttonGuardarMedicacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label2.Location = new System.Drawing.Point(146, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "DROGA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label3.Location = new System.Drawing.Point(94, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label4.Location = new System.Drawing.Point(141, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "RECETA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label5.Location = new System.Drawing.Point(148, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "FECHA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label6.Location = new System.Drawing.Point(34, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "HISTORIAL CLINICO ID";
            // 
            // txtIDMedicacion
            // 
            this.txtIDMedicacion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtIDMedicacion.Location = new System.Drawing.Point(205, 21);
            this.txtIDMedicacion.Name = "txtIDMedicacion";
            this.txtIDMedicacion.Size = new System.Drawing.Size(213, 26);
            this.txtIDMedicacion.TabIndex = 7;
            // 
            // txtDroga
            // 
            this.txtDroga.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtDroga.Location = new System.Drawing.Point(205, 63);
            this.txtDroga.Name = "txtDroga";
            this.txtDroga.Size = new System.Drawing.Size(213, 26);
            this.txtDroga.TabIndex = 8;
            // 
            // txtPrescripcion
            // 
            this.txtPrescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtPrescripcion.Location = new System.Drawing.Point(205, 105);
            this.txtPrescripcion.Name = "txtPrescripcion";
            this.txtPrescripcion.Size = new System.Drawing.Size(213, 26);
            this.txtPrescripcion.TabIndex = 9;
            // 
            // txtReceta
            // 
            this.txtReceta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtReceta.Location = new System.Drawing.Point(205, 147);
            this.txtReceta.Name = "txtReceta";
            this.txtReceta.Size = new System.Drawing.Size(213, 26);
            this.txtReceta.TabIndex = 10;
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.White;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(205, 231);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(213, 26);
            this.comboBoxID.TabIndex = 24;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(330, 189);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(88, 25);
            this.dateTimePickerHora.TabIndex = 26;
            this.dateTimePickerHora.Value = new System.DateTime(2023, 7, 5, 0, 0, 0, 0);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarFont = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(205, 189);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFecha.Size = new System.Drawing.Size(115, 25);
            this.dateTimePickerFecha.TabIndex = 25;
            // 
            // FormMedicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(459, 333);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.txtReceta);
            this.Controls.Add(this.txtPrescripcion);
            this.Controls.Add(this.txtDroga);
            this.Controls.Add(this.txtIDMedicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarMedicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedicacion";
            this.Text = "MEDICACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarMedicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDMedicacion;
        private System.Windows.Forms.TextBox txtDroga;
        private System.Windows.Forms.TextBox txtPrescripcion;
        private System.Windows.Forms.TextBox txtReceta;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
    }
}
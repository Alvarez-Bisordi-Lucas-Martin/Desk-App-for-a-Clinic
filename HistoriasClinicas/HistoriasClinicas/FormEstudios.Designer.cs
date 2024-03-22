namespace HistoriasClinicas
{
    partial class FormEstudios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudios));
            this.txtIDEstudios = new System.Windows.Forms.TextBox();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGuardarEstudios = new System.Windows.Forms.Button();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtIDEstudios
            // 
            this.txtIDEstudios.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtIDEstudios.Location = new System.Drawing.Point(207, 23);
            this.txtIDEstudios.Name = "txtIDEstudios";
            this.txtIDEstudios.Size = new System.Drawing.Size(213, 26);
            this.txtIDEstudios.TabIndex = 0;
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtEspecificaciones.Location = new System.Drawing.Point(207, 106);
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(213, 26);
            this.txtEspecificaciones.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtTipo.Location = new System.Drawing.Point(207, 65);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(213, 26);
            this.txtTipo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label1.Location = new System.Drawing.Point(177, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label2.Location = new System.Drawing.Point(160, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "TIPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ESPECIFICACIONES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label4.Location = new System.Drawing.Point(150, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.label5.Location = new System.Drawing.Point(36, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "HISTORIAL CLINICO ID";
            // 
            // buttonGuardarEstudios
            // 
            this.buttonGuardarEstudios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuardarEstudios.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonGuardarEstudios.Location = new System.Drawing.Point(36, 232);
            this.buttonGuardarEstudios.Name = "buttonGuardarEstudios";
            this.buttonGuardarEstudios.Size = new System.Drawing.Size(384, 37);
            this.buttonGuardarEstudios.TabIndex = 11;
            this.buttonGuardarEstudios.Text = "GUARDAR";
            this.buttonGuardarEstudios.UseVisualStyleBackColor = false;
            this.buttonGuardarEstudios.Click += new System.EventHandler(this.buttonGuardarEstudios_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.White;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(207, 190);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(213, 26);
            this.comboBoxID.TabIndex = 25;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(332, 149);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.ShowUpDown = true;
            this.dateTimePickerHora.Size = new System.Drawing.Size(88, 25);
            this.dateTimePickerHora.TabIndex = 27;
            this.dateTimePickerHora.Value = new System.DateTime(2023, 7, 5, 0, 0, 0, 0);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarFont = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(207, 149);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFecha.Size = new System.Drawing.Size(115, 25);
            this.dateTimePickerFecha.TabIndex = 26;
            // 
            // FormEstudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.buttonGuardarEstudios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtEspecificaciones);
            this.Controls.Add(this.txtIDEstudios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstudios";
            this.Text = "ESTUDIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDEstudios;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuardarEstudios;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
    }
}
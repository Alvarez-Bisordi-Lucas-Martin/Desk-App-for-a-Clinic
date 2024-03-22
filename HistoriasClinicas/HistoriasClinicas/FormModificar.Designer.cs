namespace HistoriasClinicas
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.comboBoxObjetos = new System.Windows.Forms.ComboBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOpciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxObjetos
            // 
            this.comboBoxObjetos.BackColor = System.Drawing.Color.White;
            this.comboBoxObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjetos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxObjetos.FormattingEnabled = true;
            this.comboBoxObjetos.Location = new System.Drawing.Point(96, 31);
            this.comboBoxObjetos.Name = "comboBoxObjetos";
            this.comboBoxObjetos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxObjetos.Size = new System.Drawing.Size(221, 26);
            this.comboBoxObjetos.TabIndex = 0;
            this.comboBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjetos_SelectedIndexChanged);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonModificar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(30, 201);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(287, 37);
            this.buttonModificar.TabIndex = 10;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // comboBoxOpciones
            // 
            this.comboBoxOpciones.BackColor = System.Drawing.Color.White;
            this.comboBoxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxOpciones.FormattingEnabled = true;
            this.comboBoxOpciones.Location = new System.Drawing.Point(96, 116);
            this.comboBoxOpciones.Name = "comboBoxOpciones";
            this.comboBoxOpciones.Size = new System.Drawing.Size(221, 26);
            this.comboBoxOpciones.TabIndex = 11;
            this.comboBoxOpciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpciones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "TIPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "CAMPO";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtNuevo.Location = new System.Drawing.Point(136, 158);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(181, 26);
            this.txtNuevo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "NUEVO CAMPO";
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.White;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(96, 74);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(221, 26);
            this.comboBoxID.TabIndex = 17;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(351, 266);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOpciones);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxObjetos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificar";
            this.Text = "MODIFICAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxObjetos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOpciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxID;
    }
}
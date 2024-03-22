namespace HistoriasClinicas
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEliminarOSocial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxOSocialID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEliminar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(29, 70);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(287, 37);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "ELIMINAR PACIENTE";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEliminarOSocial
            // 
            this.buttonEliminarOSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEliminarOSocial.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarOSocial.Location = new System.Drawing.Point(343, 70);
            this.buttonEliminarOSocial.Name = "buttonEliminarOSocial";
            this.buttonEliminarOSocial.Size = new System.Drawing.Size(287, 37);
            this.buttonEliminarOSocial.TabIndex = 10;
            this.buttonEliminarOSocial.Text = "ELIMINAR OBRA SOCIAL";
            this.buttonEliminarOSocial.UseVisualStyleBackColor = false;
            this.buttonEliminarOSocial.Click += new System.EventHandler(this.buttonEliminarOSocial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // comboBoxID
            // 
            this.comboBoxID.BackColor = System.Drawing.Color.White;
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(95, 25);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(221, 26);
            this.comboBoxID.TabIndex = 18;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // comboBoxOSocialID
            // 
            this.comboBoxOSocialID.BackColor = System.Drawing.Color.White;
            this.comboBoxOSocialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOSocialID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.comboBoxOSocialID.FormattingEnabled = true;
            this.comboBoxOSocialID.Location = new System.Drawing.Point(343, 25);
            this.comboBoxOSocialID.Name = "comboBoxOSocialID";
            this.comboBoxOSocialID.Size = new System.Drawing.Size(221, 26);
            this.comboBoxOSocialID.TabIndex = 19;
            this.comboBoxOSocialID.SelectedIndexChanged += new System.EventHandler(this.comboBoxOSocialID_SelectedIndexChanged);
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(662, 134);
            this.Controls.Add(this.comboBoxOSocialID);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.buttonEliminarOSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminar";
            this.Text = "ELIMINAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEliminarOSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxOSocialID;
    }
}
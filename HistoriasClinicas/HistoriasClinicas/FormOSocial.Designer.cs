﻿namespace HistoriasClinicas
{
    partial class FormOSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSocial));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOSocialID = new System.Windows.Forms.TextBox();
            this.txtNombreOSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtOSocialID
            // 
            this.txtOSocialID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtOSocialID.Location = new System.Drawing.Point(91, 21);
            this.txtOSocialID.Name = "txtOSocialID";
            this.txtOSocialID.Size = new System.Drawing.Size(221, 26);
            this.txtOSocialID.TabIndex = 0;
            // 
            // txtNombreOSocial
            // 
            this.txtNombreOSocial.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtNombreOSocial.Location = new System.Drawing.Point(91, 62);
            this.txtNombreOSocial.Name = "txtNombreOSocial";
            this.txtNombreOSocial.Size = new System.Drawing.Size(221, 26);
            this.txtNombreOSocial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(25, 105);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(287, 37);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormOSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(346, 156);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreOSocial);
            this.Controls.Add(this.txtOSocialID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOSocial";
            this.Text = "OBRA SOCIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOSocialID;
        private System.Windows.Forms.TextBox txtNombreOSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuardar;
    }
}
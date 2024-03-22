using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HistoriasClinicas
{
    public partial class FormOSocial : Form
    {
        public FormOSocial()
        {
            InitializeComponent();
        }

        private void AgregarOSocial()
        {
            ObraSocial OSocial = new ObraSocial()
            {
                ID = int.Parse(txtOSocialID.Text),
                Nombre = txtNombreOSocial.Text
            };

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO ObraSocial (ID, Nombre) VALUES ({OSocial.ID}, '{OSocial.Nombre}')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
        }

        private void Limpiar()
        {
            txtOSocialID.Text = "";
            txtNombreOSocial.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            AgregarOSocial();
            Limpiar();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormInicio : Form
    {
        bool inicio = false;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string sqlUsuarioModel = "SELECT * FROM UsuarioAgenda";
                using (SqlCommand command = new SqlCommand(sqlUsuarioModel, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(reader.GetOrdinal("Usuario")) == txtUsuario.Text)
                            {
                                if (reader.GetString(reader.GetOrdinal("Contraseña")) == txtContraseña.Text)
                                {
                                    inicio = true;
                                }
                            }
                        }
                    }
                }
            }

            if (inicio == true)
            {
                Form form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                Form formError = new FormError();
                formError.ShowDialog();
            }
            Limpiar();
        }

        public void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Form formCrearCuenta = new FormCrearCuenta();
            formCrearCuenta.ShowDialog();
        }
    }
}
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
    public partial class FormCrearCuenta : Form
    {
        public FormCrearCuenta()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO UsuarioAgenda (Usuario, Contraseña) VALUES ('{txtUsuario.Text}', '{txtContraseña.Text}')", cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();

            Limpiar();

            this.Close();
        }

        public void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}
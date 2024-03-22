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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HistoriasClinicas
{
    public partial class FormPaciente : Form
    {
        string idOSocial;
        
        public FormPaciente()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string comando = "SELECT * FROM ObraSocial";
                using (SqlCommand command = new SqlCommand(comando, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxOSocialID.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} - {reader.GetString(reader.GetOrdinal("Nombre"))}");
                        }
                    }
                }

                connection.Close();
            }
        }

        private void AgregarPaciente()
        {
            char ID = idOSocial[0];
            int oSocialID = int.Parse(ID.ToString());

            UsuarioModel paciente = new UsuarioModel()
            {
                ID = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = int.Parse(txtDNI.Text),
                Nacimiento = DateTime.Parse(dateTimePickerNacimiento.Text),
                Sexo = txtSexo.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text,
                Consulta = DateTime.Parse($"{dateTimePickerFecha.Text} {dateTimePickerHora.Text}"),
                ObraSocialFK = oSocialID
            };

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO UsuarioModel (ID, Nombre, Apellido, DNI, Nacimiento, Sexo, Telefono, Direccion, Correo, Consulta, ObraSocialFK) VALUES (@ID, @Nombre, @Apellido, @DNI, @Nacimiento, @Sexo, @Telefono, @Direccion, @Correo, @Consulta, @ObraSocialFK)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", paciente.ID);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("@DNI", paciente.DNI);
                cmd.Parameters.AddWithValue("@Nacimiento", paciente.Nacimiento);
                cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                cmd.Parameters.AddWithValue("@Correo", paciente.Correo);
                cmd.Parameters.AddWithValue("@Consulta", paciente.Consulta);
                cmd.Parameters.AddWithValue("@ObraSocialFK", paciente.ObraSocialFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
        }

        private void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtSexo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            dateTimePickerNacimiento.Value = DateTime.Now;
            dateTimePickerFecha.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTimePicker.MinimumDateTime.Date + new TimeSpan(0, 0, 0);
        }

        private void buttonGuardarPaciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
            Limpiar();
        }

        private void comboBoxOSocialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idOSocial = comboBoxOSocialID.SelectedItem.ToString();
        }
    }
}
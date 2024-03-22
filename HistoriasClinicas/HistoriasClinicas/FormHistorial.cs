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
    public partial class FormHistorial : Form
    {
        string idPacientes;

        public FormHistorial()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string comando = "SELECT * FROM UsuarioModel";
                using (SqlCommand command = new SqlCommand(comando, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxID.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} - {reader.GetString(reader.GetOrdinal("Nombre"))} {reader.GetString(reader.GetOrdinal("Apellido"))}");
                        }
                    }
                }

                connection.Close();
            }
        }

        private void buttonGuardarHistorial_Click(object sender, EventArgs e)
        {
            AgregarHistorial();
            Limpiar();
        }

        private void AgregarHistorial()
        {
            char ID = idPacientes[0];
            int PacientesID = int.Parse(ID.ToString());

            HistoriasClinicas historial = new HistoriasClinicas()
            {
                ID = int.Parse(txtIDHistorial.Text),
                Fecha = DateTime.Parse($"{dateTimePickerFecha.Text} {dateTimePickerHora.Text}"),
                MotivoVisita = txtMotivoVisita.Text,
                Sintomas = txtSintomas.Text,
                Diagnostico = txtDiagnostico.Text,
                Tratamiento = txtTratamiento.Text,
                UsuarioModelFK = PacientesID
            };

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO HistoriasClinicas (ID, Fecha, MotivoVisita, Sintomas, Diagnostico, Tratamiento, UsuarioModelFK) VALUES (@ID, @Fecha, @MotivoVisita, @Sintomas, @Diagnostico, @Tratamiento, @UsuarioModelFK)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", historial.ID);
                cmd.Parameters.AddWithValue("@Fecha", historial.Fecha);
                cmd.Parameters.AddWithValue("@MotivoVisita", historial.MotivoVisita);
                cmd.Parameters.AddWithValue("@Sintomas", historial.Sintomas);
                cmd.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                cmd.Parameters.AddWithValue("@Tratamiento", historial.Tratamiento);
                cmd.Parameters.AddWithValue("@UsuarioModelFK", historial.UsuarioModelFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
        }

        private void Limpiar()
        {
            txtIDHistorial.Text = "";
            dateTimePickerFecha.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTimePicker.MinimumDateTime.Date + new TimeSpan(0, 0, 0);
            txtMotivoVisita.Text = "";
            txtSintomas.Text = "";
            txtDiagnostico.Text = "";
            txtTratamiento.Text = "";
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPacientes = comboBoxID.SelectedItem.ToString();
        }
    }
}
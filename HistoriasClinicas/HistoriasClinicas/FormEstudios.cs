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
    public partial class FormEstudios : Form
    {
        string idHistorias;

        public FormEstudios()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string comando = "SELECT * FROM HistoriasClinicas";
                using (SqlCommand command = new SqlCommand(comando, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxID.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} - Paciente asociado: {reader.GetInt32(reader.GetOrdinal("UsuarioModelFK"))}");
                        }
                    }
                }

                connection.Close();
            }
        }

        private void AgregarEstudio()
        {
            char ID = idHistorias[0];
            int HistriasID = int.Parse(ID.ToString());

            Estudios estudio = new Estudios()
            {
                ID = int.Parse(txtIDEstudios.Text),
                Tipo = txtTipo.Text,
                Especificaciones = txtEspecificaciones.Text,
                Fecha = DateTime.Parse($"{dateTimePickerFecha.Text} {dateTimePickerHora.Text}"),
                HistoriasClinicasFK = HistriasID
            };

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Estudios (ID, Tipo, Especificaciones, Fecha, HistoriasClinicasFK) VALUES (@ID, @Tipo, @Especificaciones, @Fecha, @HistoriasClinicasFK)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", estudio.ID);
                cmd.Parameters.AddWithValue("@Tipo", estudio.Tipo);
                cmd.Parameters.AddWithValue("@Especificaciones", estudio.Especificaciones);
                cmd.Parameters.AddWithValue("@Fecha", estudio.Fecha);
                cmd.Parameters.AddWithValue("@HistoriasClinicasFK", estudio.HistoriasClinicasFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
        }

        private void Limpiar()
        {
            txtIDEstudios.Text = "";
            txtTipo.Text = "";
            txtEspecificaciones.Text = "";
            dateTimePickerFecha.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTimePicker.MinimumDateTime.Date + new TimeSpan(0, 0, 0);
        }

        private void buttonGuardarEstudios_Click(object sender, EventArgs e)
        {
            AgregarEstudio();
            Limpiar();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHistorias = comboBoxID.SelectedItem.ToString();
        }
    }
}
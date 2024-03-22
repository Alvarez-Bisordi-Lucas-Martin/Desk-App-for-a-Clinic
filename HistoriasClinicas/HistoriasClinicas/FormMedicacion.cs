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
    public partial class FormMedicacion : Form
    {
        string idHistorias;

        public FormMedicacion()
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

        private void AgregarMedicacion()
        {
            char ID = idHistorias[0];
            int HistriasID = int.Parse(ID.ToString());

            Medicacion medicacion = new Medicacion()
            {
                ID = int.Parse(txtIDMedicacion.Text),
                Droga = txtDroga.Text,
                Prescripcion = txtPrescripcion.Text,
                Receta = txtReceta.Text,
                Fecha = DateTime.Parse($"{dateTimePickerFecha.Text} {dateTimePickerHora.Text}"),
                HistoriasClinicasFK = HistriasID
            };

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Medicacion (ID, Droga, Prescripcion, Receta, Fecha, HistoriasClinicasFK) VALUES (@ID, @Droga, @Prescripcion, @Receta, @Fecha, @HistoriasClinicasFK)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", medicacion.ID);
                cmd.Parameters.AddWithValue("@Droga", medicacion.Droga);
                cmd.Parameters.AddWithValue("@Prescripcion", medicacion.Prescripcion);
                cmd.Parameters.AddWithValue("@Receta", medicacion.Receta);
                cmd.Parameters.AddWithValue("@Fecha", medicacion.Fecha);
                cmd.Parameters.AddWithValue("@HistoriasClinicasFK", medicacion.HistoriasClinicasFK);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
        }

        private void Limpiar()
        {
            txtIDMedicacion.Text = "";
            txtDroga.Text = "";
            txtPrescripcion.Text = "";
            txtReceta.Text = "";
            dateTimePickerFecha.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTimePicker.MinimumDateTime.Date + new TimeSpan(0, 0, 0);
        }

        private void buttonGuardarMedicacion_Click(object sender, EventArgs e)
        {
            AgregarMedicacion();
            Limpiar();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHistorias = comboBoxID.SelectedItem.ToString();
        }
    }
}
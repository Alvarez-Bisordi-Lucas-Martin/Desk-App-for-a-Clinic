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
    public partial class FormModificar : Form
    {
        string objetoSeleccionado, opcionSeleccionada, idSelecciondo, nombreAsociado, formatoLista;
        bool entero = false;

        public FormModificar()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            comboBoxObjetos.Items.Add("UsuarioModel");
            comboBoxObjetos.Items.Add("HistoriasClinicas");
            comboBoxObjetos.Items.Add("Estudios");
            comboBoxObjetos.Items.Add("Medicacion");
            comboBoxObjetos.Items.Add("ObraSocial");
        }

        private void comboBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            objetoSeleccionado = comboBoxObjetos.SelectedItem.ToString();

            comboBoxOpciones.Items.Clear();

            switch (objetoSeleccionado)
            {
                case "UsuarioModel":
                    comboBoxOpciones.Items.Add("Nombre");
                    comboBoxOpciones.Items.Add("Apellido");
                    comboBoxOpciones.Items.Add("DNI");
                    comboBoxOpciones.Items.Add("Nacimiento");
                    comboBoxOpciones.Items.Add("Sexo");
                    comboBoxOpciones.Items.Add("Telefono");
                    comboBoxOpciones.Items.Add("Direccion");
                    comboBoxOpciones.Items.Add("Correo");
                    comboBoxOpciones.Items.Add("Consulta");
                    comboBoxOpciones.Items.Add("ObraSocialFK");

                    comboBoxOpciones.SelectedIndex = 0;

                    nombreAsociado = "Apellido";
                    formatoLista = "-";
                    entero = false;
                    break;
                case "HistoriasClinicas":
                    comboBoxOpciones.Items.Add("Fecha");
                    comboBoxOpciones.Items.Add("MotivoVisita");
                    comboBoxOpciones.Items.Add("Sintomas");
                    comboBoxOpciones.Items.Add("Diagnostico");
                    comboBoxOpciones.Items.Add("Tratamiento");
                    comboBoxOpciones.Items.Add("UsuarioModelFK");

                    comboBoxOpciones.SelectedIndex = 0;

                    nombreAsociado = "UsuarioModelFK";
                    formatoLista = "- Paciente asociado:";
                    entero = true;
                    break;
                case "Estudios":
                    comboBoxOpciones.Items.Add("Tipo");
                    comboBoxOpciones.Items.Add("Especificaciones");
                    comboBoxOpciones.Items.Add("Fecha");
                    comboBoxOpciones.Items.Add("HistoriasClinicasFK");

                    comboBoxOpciones.SelectedIndex = 0;

                    nombreAsociado = "HistoriasClinicasFK";
                    formatoLista = "- Historia Clinica asociada:";
                    entero = true;
                    break;
                case "Medicacion":
                    comboBoxOpciones.Items.Add("Droga");
                    comboBoxOpciones.Items.Add("Prescripcion");
                    comboBoxOpciones.Items.Add("Receta");
                    comboBoxOpciones.Items.Add("Fecha");
                    comboBoxOpciones.Items.Add("HistoriasClinicasFK");

                    comboBoxOpciones.SelectedIndex = 0;

                    nombreAsociado = "HistoriasClinicasFK";
                    formatoLista = "- Historia Clinica asociada:";
                    entero = true;
                    break;
                case "ObraSocial":
                    comboBoxOpciones.Items.Add("Nombre");

                    comboBoxOpciones.SelectedIndex = 0;

                    nombreAsociado = "Nombre";
                    formatoLista = "-";
                    entero = false;
                    break;
                default:
                    MessageBox.Show("Error inesperado!");
                    this.Close();
                    break;
            }

            comboBoxID.Items.Clear();

            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string comando = $"SELECT * FROM {objetoSeleccionado}";
                using (SqlCommand command = new SqlCommand(comando, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (entero == false)
                        {
                            while (reader.Read())
                            {
                                comboBoxID.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} {formatoLista} {reader.GetString(reader.GetOrdinal(nombreAsociado))}");
                            }
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                comboBoxID.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} {formatoLista} {reader.GetInt32(reader.GetOrdinal(nombreAsociado))}");
                            }
                        }
                    }
                    connection.Close();
                }
            }

            comboBoxID.SelectedIndex = 0;
        }

        private void comboBoxOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeleccionada = comboBoxOpciones.SelectedItem.ToString();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSelecciondo = comboBoxID.SelectedItem.ToString();
        }

        private void Limpiar()
        {
            comboBoxObjetos.Items.Clear();
            comboBoxOpciones.Items.Clear();
            comboBoxID.Items.Clear();
            txtNuevo.Clear();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            object nuevoValor;

            if (opcionSeleccionada == "Fecha" || opcionSeleccionada == "Consulta" || opcionSeleccionada == "Nacimiento")
            {
                nuevoValor = DateTime.Parse(txtNuevo.Text);
            }
            else if (opcionSeleccionada == "UsuarioModelFK" || opcionSeleccionada == "HistoriasClinicasFK" || opcionSeleccionada == "DNI" || opcionSeleccionada == "ObraSocialFK")
            {
                nuevoValor = int.Parse(txtNuevo.Text);
            }
            else
            {
                nuevoValor = txtNuevo.Text;
            }

            char ID = idSelecciondo[0];
            int id = int.Parse(ID.ToString());
            
            string query = "";

            switch (objetoSeleccionado)
            {
                case "ObraSocial":
                    query = $"UPDATE ObraSocial SET {opcionSeleccionada} = @NuevoValor WHERE ID = @ID";
                    break;
                case "UsuarioModel":
                    query = $"UPDATE UsuarioModel SET {opcionSeleccionada} = @NuevoValor WHERE ID = @ID";
                    break;
                case "HistoriasClinicas":
                    query = $"UPDATE HistoriasClinicas SET {opcionSeleccionada} = @NuevoValor WHERE ID = @ID";
                    break;
                case "Estudios":
                    query = $"UPDATE Estudios SET {opcionSeleccionada} = @NuevoValor WHERE ID = @ID";
                    break;
                case "Medicacion":
                    query = $"UPDATE Medicacion SET {opcionSeleccionada} = @NuevoValor WHERE ID = @ID";
                    break;
                default:
                    MessageBox.Show("Error inesperado!");
                    this.Close();
                    return;
            }

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@NuevoValor", nuevoValor);
                cmd.Parameters.AddWithValue("@ID", id);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
            Limpiar();
            Iniciar();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace HistoriasClinicas
{
    public partial class FormInformes : Form
    {
        DataTable tablaPaciente, tablaHistorial, tablaEstudios, tablaMedicacion, tablaOSocial;
        string pacienteSelecciondo;

        public FormInformes()
        {
            InitializeComponent();
            Iniciar();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string txtNombrePDF = "InformePaciente";
            string extension = ".pdf";
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = ($"{txtNombrePDF}{pacienteSelecciondo[0]}{extension}");
            guardar.ShowDialog();

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    string textoAdicional = $"Informe Paciente N° {pacienteSelecciondo[0]}";
                    pdfDoc.Add(new Paragraph(textoAdicional, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));

                    pdfDoc.Add(new Paragraph(" "));

                    AgregarContenidoTabla(pdfDoc, "Datos del Paciente", tablaPaciente);
                    AgregarContenidoTabla(pdfDoc, "Historial Clínico", tablaHistorial);
                    AgregarContenidoTabla(pdfDoc, "Estudios", tablaEstudios);
                    AgregarContenidoTabla(pdfDoc, "Medicación", tablaMedicacion);
                    AgregarContenidoTabla(pdfDoc, "Obra Social", tablaOSocial);

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void AgregarContenidoTabla(Document document, string titulo, DataTable tabla)
        {
            document.Add(new Paragraph(titulo, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));

            document.Add(new Paragraph(" "));

            PdfPTable pdfTable = new PdfPTable(tabla.Columns.Count);

            foreach (DataColumn column in tabla.Columns)
            {
                pdfTable.AddCell(column.ColumnName);
            }

            foreach (DataRow row in tabla.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    pdfTable.AddCell(item.ToString());
                }
            }

            document.Add(pdfTable);

            document.Add(new Paragraph(" "));
        }

        private void comboBoxObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSelecciondo = comboBoxObjetos.SelectedItem.ToString();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Consultar();
        }

        private void Iniciar()
        {
            tablaPaciente = new DataTable();
            tablaPaciente.Columns.Add("PACIENTE");
            tablaPaciente.Columns.Add("DATOS");
            grillaPaciente.DataSource = tablaPaciente;

            tablaHistorial = new DataTable();
            tablaHistorial.Columns.Add("HISTORIAL CLINICO");
            tablaHistorial.Columns.Add("DATOS");
            grillaHistorial.DataSource = tablaHistorial;

            tablaEstudios = new DataTable();
            tablaEstudios.Columns.Add("ESTUDIOS");
            tablaEstudios.Columns.Add("DATOS");
            grillaEstudios.DataSource = tablaEstudios;

            tablaMedicacion = new DataTable();
            tablaMedicacion.Columns.Add("MEDICACION");
            tablaMedicacion.Columns.Add("DATOS");
            grillaMedicacion.DataSource = tablaMedicacion;

            tablaOSocial = new DataTable();
            tablaOSocial.Columns.Add("OBRA SOCIAL");
            tablaOSocial.Columns.Add("DATOS");
            grillaOSocial.DataSource = tablaOSocial;

            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string sqlUsuarioModel = "SELECT * FROM UsuarioModel";
                using (SqlCommand command = new SqlCommand(sqlUsuarioModel, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxObjetos.Items.Add($"{reader.GetInt32(reader.GetOrdinal("ID"))} - {reader.GetString(reader.GetOrdinal("Nombre"))} {reader.GetString(reader.GetOrdinal("Apellido"))}");
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void Consultar()
        {
            List<UsuarioModel> ListaPacientes = new List<UsuarioModel>();
            List<HistoriasClinicas> ListaHistorial = new List<HistoriasClinicas>();
            List<Estudios> ListaEstudios = new List<Estudios>();
            List<Medicacion> ListaMedicacion = new List<Medicacion>();
            List<ObraSocial> ListaOSocial = new List<ObraSocial>();

            using (SqlConnection connection = new SqlConnection(Form1.coneccion))
            {
                connection.Open();

                string sqlUsuarioModel = "SELECT * FROM UsuarioModel";
                using (SqlCommand command = new SqlCommand(sqlUsuarioModel, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsuarioModel paciente = new UsuarioModel();

                            paciente.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            paciente.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                            paciente.Apellido = reader.GetString(reader.GetOrdinal("Apellido"));
                            paciente.DNI = reader.GetInt32(reader.GetOrdinal("DNI"));
                            paciente.Nacimiento = reader.GetDateTime(reader.GetOrdinal("Nacimiento"));
                            paciente.Sexo = reader.GetString(reader.GetOrdinal("Sexo"));
                            paciente.Telefono = reader.GetString(reader.GetOrdinal("Telefono"));
                            paciente.Direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                            paciente.Correo = reader.GetString(reader.GetOrdinal("Correo"));
                            paciente.Consulta = reader.GetDateTime(reader.GetOrdinal("Consulta"));
                            paciente.ObraSocialFK = reader.GetInt32(reader.GetOrdinal("ObraSocialFK"));

                            ListaPacientes.Add(paciente);
                        }
                    }
                }

                string sqlObraSocial = "SELECT * FROM ObraSocial";
                using (SqlCommand command = new SqlCommand(sqlObraSocial, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ObraSocial obraSocial = new ObraSocial();

                            obraSocial.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            obraSocial.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));

                            ListaOSocial.Add(obraSocial);
                        }
                    }
                }

                string sqlMedicacion = "SELECT * FROM Medicacion";
                using (SqlCommand command = new SqlCommand(sqlMedicacion, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medicacion medicacion = new Medicacion();

                            medicacion.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            medicacion.Droga = reader.GetString(reader.GetOrdinal("Droga"));
                            medicacion.Prescripcion = reader.GetString(reader.GetOrdinal("Prescripcion"));
                            medicacion.Receta = reader.GetString(reader.GetOrdinal("Receta"));
                            medicacion.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));
                            medicacion.HistoriasClinicasFK = reader.GetInt32(reader.GetOrdinal("HistoriasClinicasFK"));

                            ListaMedicacion.Add(medicacion);
                        }
                    }
                }

                string sqlHistorialClinico = "SELECT * FROM HistoriasClinicas";
                using (SqlCommand command = new SqlCommand(sqlHistorialClinico, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HistoriasClinicas historial = new HistoriasClinicas();

                            historial.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            historial.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));
                            historial.MotivoVisita = reader.GetString(reader.GetOrdinal("MotivoVisita"));
                            historial.Sintomas = reader.GetString(reader.GetOrdinal("Sintomas"));
                            historial.Diagnostico = reader.GetString(reader.GetOrdinal("Diagnostico"));
                            historial.Tratamiento = reader.GetString(reader.GetOrdinal("Tratamiento"));
                            historial.UsuarioModelFK = reader.GetInt32(reader.GetOrdinal("UsuarioModelFK"));

                            ListaHistorial.Add(historial);
                        }
                    }
                }

                string sqlEstudio = "SELECT * FROM Estudios";
                using (SqlCommand command = new SqlCommand(sqlEstudio, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudios estudio = new Estudios();

                            estudio.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            estudio.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                            estudio.Especificaciones = reader.GetString(reader.GetOrdinal("Especificaciones"));
                            estudio.Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));
                            estudio.HistoriasClinicasFK = reader.GetInt32(reader.GetOrdinal("HistoriasClinicasFK"));

                            ListaEstudios.Add(estudio);
                        }
                    }
                }

                connection.Close();
            }

            char ID = pacienteSelecciondo[0];
            int pacienteDeseado = int.Parse(ID.ToString());

            tablaPaciente.Rows.Add("ID", ListaPacientes[pacienteDeseado].ID);
            tablaPaciente.Rows.Add("NOMBRE", ListaPacientes[pacienteDeseado].Nombre);
            tablaPaciente.Rows.Add("APELLIDO", ListaPacientes[pacienteDeseado].Apellido);
            tablaPaciente.Rows.Add("DNI", ListaPacientes[pacienteDeseado].DNI);
            tablaPaciente.Rows.Add("NACIMIENTO", ListaPacientes[pacienteDeseado].Nacimiento);
            tablaPaciente.Rows.Add("SEXO", ListaPacientes[pacienteDeseado].Sexo);
            tablaPaciente.Rows.Add("TELEFONO", ListaPacientes[pacienteDeseado].Telefono);
            tablaPaciente.Rows.Add("DIRECCION", ListaPacientes[pacienteDeseado].Direccion);
            tablaPaciente.Rows.Add("CORREO ELECTRONICO", ListaPacientes[pacienteDeseado].Correo);
            tablaPaciente.Rows.Add("FECHA DE CONSULTA", ListaPacientes[pacienteDeseado].Consulta);

            foreach (var item1 in ListaHistorial)
            {
                if (item1.UsuarioModelFK == pacienteDeseado)
                {
                    tablaHistorial.Rows.Add("ID", item1.ID);
                    tablaHistorial.Rows.Add("FECHA", item1.Fecha);
                    tablaHistorial.Rows.Add("MOTIVO VISITA", item1.MotivoVisita);
                    tablaHistorial.Rows.Add("SINTOMAS", item1.Sintomas);
                    tablaHistorial.Rows.Add("DIAGNOSTICO", item1.Diagnostico);
                    tablaHistorial.Rows.Add("TRATAMIENTO", item1.Tratamiento);
                    tablaHistorial.Rows.Add("*****", "*****");

                    foreach (var item2 in ListaEstudios)
                    {
                        if (item2.HistoriasClinicasFK == item1.ID)
                        {
                            tablaEstudios.Rows.Add("ID", item2.ID);
                            tablaEstudios.Rows.Add("TIPO", item2.Tipo);
                            tablaEstudios.Rows.Add("ESPECIFICACIONES", item2.Especificaciones);
                            tablaEstudios.Rows.Add("FECHA", item2.Fecha);
                            tablaEstudios.Rows.Add("*****", "*****");
                        }
                    }
                    foreach (var item3 in ListaMedicacion)
                    {
                        if (item3.HistoriasClinicasFK == item1.ID)
                        {
                            tablaMedicacion.Rows.Add("ID", item3.ID);
                            tablaMedicacion.Rows.Add("DROGA", item3.Droga);
                            tablaMedicacion.Rows.Add("PRESCRIPCION", item3.Prescripcion);
                            tablaMedicacion.Rows.Add("RECETA", item3.Receta);
                            tablaMedicacion.Rows.Add("FECHA", item3.Fecha);
                            tablaMedicacion.Rows.Add("*****", "*****");
                        }
                    }
                }
            }

            foreach (var item4 in ListaOSocial)
            {
                if (item4.ID == ListaPacientes[pacienteDeseado].ObraSocialFK)
                {
                    tablaOSocial.Rows.Add("ID", item4.ID);
                    tablaOSocial.Rows.Add("NOMBRE", item4.Nombre);
                    tablaOSocial.Rows.Add("*****", "*****");
                }
            }
        }

        private void Limpiar()
        {
            tablaPaciente.Rows.Clear();
            tablaHistorial.Rows.Clear();
            tablaEstudios.Rows.Clear();
            tablaMedicacion.Rows.Clear();
            tablaOSocial.Rows.Clear();
        }
    }
}
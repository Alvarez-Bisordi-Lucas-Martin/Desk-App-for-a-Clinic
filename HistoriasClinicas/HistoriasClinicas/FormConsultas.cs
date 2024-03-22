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
using iTextSharp.tool.xml.html.head;

namespace HistoriasClinicas
{
    public partial class FormConsultas : Form
    {
        DataTable tablaConsultas;
        DateTime fechaDeseada;

        public FormConsultas()
        {
            InitializeComponent();
            Iniciar();
            dateTimePickerFecha.Padding = new Padding(10);
        }

        private void AgregarContenidoTabla(Document document, DataTable tabla)
        {
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

        private void Iniciar()
        {
            tablaConsultas = new DataTable();
            tablaConsultas.Columns.Add("PACIENTE");
            tablaConsultas.Columns.Add("DATOS");
            grillaConsultas.DataSource = tablaConsultas;
        }

        private void Consultar()
        {
            List<UsuarioModel> ListaPacientes = new List<UsuarioModel>();

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
            }

            foreach (var item1 in ListaPacientes)
            {
                if (item1.Consulta.Date == fechaDeseada.Date)
                {
                    tablaConsultas.Rows.Add("ID", item1.ID);
                    tablaConsultas.Rows.Add("NOMBRE", item1.Nombre);
                    tablaConsultas.Rows.Add("APELLIDO", item1.Apellido);
                    tablaConsultas.Rows.Add("FECHA", item1.Consulta);
                }
            }

            if (tablaConsultas.Rows.Count == 0)
            {
                MessageBox.Show($"NO HAY CONSULTAS PROGRAMADAS PARA EL DIA: {fechaDeseada.ToString("dd/MM/yyyy")}", "CONSULTAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            tablaConsultas.Rows.Clear();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            fechaDeseada = DateTime.Parse($"{dateTimePickerFecha.Text} {dateTimePickerHora.Text}");
            Limpiar();
            Consultar();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string txtNombrePDF = "Consultas";
            string extension = ".pdf";
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = ($"{txtNombrePDF}{fechaDeseada.ToString("dd-MM-yyyy")}{extension}");
            guardar.ShowDialog();

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    string textoAdicional = $"Consultas programadas para el dia: {dateTimePickerFecha.Text}";
                    pdfDoc.Add(new Paragraph(textoAdicional, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));

                    pdfDoc.Add(new Paragraph(" "));

                    AgregarContenidoTabla(pdfDoc, tablaConsultas);

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
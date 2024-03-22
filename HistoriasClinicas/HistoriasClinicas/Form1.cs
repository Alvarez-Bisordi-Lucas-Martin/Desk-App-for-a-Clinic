using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class Form1 : Form
    {
        public static string coneccion = "Data Source=LUCASALVAREZ\\SQLEXPRESS;Initial Catalog=datosAgenda;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void agregarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPacientes = new FormPaciente();
            this.Hide();
            formPacientes.ShowDialog();
            this.Show();
        }

        private void agregarHistorialClinicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHistorial = new FormHistorial();
            this.Hide();
            formHistorial.ShowDialog();
            this.Show();
        }

        private void agregarEstudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEstudios = new FormEstudios();
            this.Hide();
            formEstudios.ShowDialog();
            this.Show();
        }

        private void agregarMedicacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formMedicacion = new FormMedicacion();
            this.Hide();
            formMedicacion.ShowDialog();
            this.Show();
        }

        private void agregarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formOSocial = new FormOSocial();
            this.Hide();
            formOSocial.ShowDialog();
            this.Show();
        }

        private void modificarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formModificar = new FormModificar();
            this.Hide();
            formModificar.ShowDialog();
            this.Show();
        }

        private void eliminarPacientesYOSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEliminar = new FormEliminar();
            this.Hide();
            formEliminar.ShowDialog();
            this.Show();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInformes = new FormInformes();
            this.Hide();
            formInformes.ShowDialog();
            this.Show();
        }

        private void verConsultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formConsultas = new FormConsultas();
            this.Hide();
            formConsultas.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime fechaHoraActual = DateTime.Now;
            label6.Text = fechaHoraActual.ToString();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInicio = new FormInicio();
            this.Hide();
            formInicio.ShowDialog();
            this.Close();
        }
    }
}
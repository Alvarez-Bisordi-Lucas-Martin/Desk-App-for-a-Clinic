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
    public partial class FormEliminar : Form
    {
        string idPaciente, idOSocial;

        public FormEliminar()
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

                comando = "SELECT * FROM ObraSocial";
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            char ID = idPaciente[0];
            int usuarioID = int.Parse(ID.ToString());
            string comandos = @"
            DECLARE @UsuarioID int
            SET @UsuarioID = @ID
            DELETE FROM Medicacion
            WHERE HistoriasClinicasFK IN (
                SELECT ID
                FROM HistoriasClinicas
                WHERE UsuarioModelFK = @UsuarioID
            );
            DELETE FROM Estudios
            WHERE HistoriasClinicasFK IN (
                SELECT ID
                FROM HistoriasClinicas
                WHERE UsuarioModelFK = @UsuarioID
            );
            DELETE FROM HistoriasClinicas
            WHERE UsuarioModelFK = @UsuarioID;
            DELETE FROM UsuarioModel
            WHERE ID = @UsuarioID;
            ";

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand(comandos, cn);
                cmd.Parameters.AddWithValue("@ID", usuarioID);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
            Limpiar();
            Iniciar();
        }

        private void buttonEliminarOSocial_Click(object sender, EventArgs e)
        {
            char ID = idOSocial[0];
            int oSocialID = int.Parse(ID.ToString());

            string comandos = "DELETE FROM ObraSocial WHERE ID = @ID";

            using (SqlConnection cn = new SqlConnection(Form1.coneccion))
            {
                SqlCommand cmd = new SqlCommand(comandos, cn);
                cmd.Parameters.AddWithValue("@ID", oSocialID);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            Form formRealizado = new FormRealizado();
            formRealizado.ShowDialog();
            Limpiar();
            Iniciar();
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPaciente = comboBoxID.SelectedItem.ToString();
        }

        private void comboBoxOSocialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            idOSocial = comboBoxOSocialID.SelectedItem.ToString();
        }

        private void Limpiar()
        {
            comboBoxID.Items.Clear();
            comboBoxOSocialID.Items.Clear();
        }
    }
}
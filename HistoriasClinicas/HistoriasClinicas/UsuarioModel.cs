using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriasClinicas
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public int DNI { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public DateTime Consulta { get; set; }
        public int ObraSocialFK { get; set; }
    }
}
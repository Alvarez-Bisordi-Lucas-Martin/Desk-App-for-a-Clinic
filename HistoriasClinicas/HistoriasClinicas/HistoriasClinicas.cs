using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriasClinicas
{
    public class HistoriasClinicas
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string MotivoVisita { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public int UsuarioModelFK { get; set; }
    }
}
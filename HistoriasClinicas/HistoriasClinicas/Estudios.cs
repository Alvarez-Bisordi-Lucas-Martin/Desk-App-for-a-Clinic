using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriasClinicas
{
    public class Estudios
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Especificaciones { get; set; }
        public DateTime Fecha { get; set; }
        public int HistoriasClinicasFK { get; set; }
    }
}
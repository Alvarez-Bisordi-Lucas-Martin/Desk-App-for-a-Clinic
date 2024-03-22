using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriasClinicas
{
    public class Medicacion
    {
        public int ID { get; set; }
        public string Droga { get; set; }
        public string Prescripcion { get; set; }
        public string Receta { get; set; }
        public DateTime Fecha { get; set; }
        public int HistoriasClinicasFK { get; set; }
    }
}
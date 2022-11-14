using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.Models
{
    public class PacienteData
    {
        public string PacienteName { get; set; }
        public string PacienteSurname { get; set; }
        public int PacienteDNI { get; set; }
        public int PacienteId { get; set; }

        public DateTime PacienteDate { get; set; }
        public string PacienteGenero    { get; set; }
    }
}

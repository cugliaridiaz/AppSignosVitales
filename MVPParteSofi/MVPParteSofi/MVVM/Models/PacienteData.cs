using MVPParteSofi.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.Models
{
    public class PacienteData : TableData
    {
        public string PacienteName { get; set; }
        public string PacienteDNI { get; set; }
        public string PacienteId { get; set; }

        public DateTime PacienteDate { get; set; }
        public string PacienteGenero    { get; set; }
    }
}

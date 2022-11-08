using MVPParteSofi.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.Models
{
    public class FrecuenciaData : TableData
    {
        public int ValorFrecuencia { get; set; }
        public DateTime DiaFrecuencia { get; set; }
        //public TimeOnly HoraFrecuencia { get; set; }
    }
}

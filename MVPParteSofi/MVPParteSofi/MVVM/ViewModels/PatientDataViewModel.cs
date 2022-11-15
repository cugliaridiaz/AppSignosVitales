using MVPParteSofi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.ViewModels
{
    public class PatientDataViewModel
    {
        public List<PacienteData> Pacientes { get; set; }

        public PatientDataViewModel()
        {
            FillData();
        }
    }
    public void FillData()
    {
        var datos =
            App.PacienteRepo.GetItems().ToList();

        Pacientes = new List<PacienteData>(datos);
    }
}

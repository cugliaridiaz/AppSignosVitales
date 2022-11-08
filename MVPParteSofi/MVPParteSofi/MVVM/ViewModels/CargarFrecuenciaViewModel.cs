using MVPParteSofi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.ViewModels
{
    public class CargarFrecuenciaViewModel
    {
        public FrecuenciaData FrecuenciaData { get; set; } = new FrecuenciaData
        {
            DiaFrecuencia = DateTime.Now,
        };

        public string GuardarFrecuencia()
        {
            App.FrecuenciaRepo.SaveItem(FrecuenciaData);
            return App.FrecuenciaRepo.StatusMessage;
        }

    }
}

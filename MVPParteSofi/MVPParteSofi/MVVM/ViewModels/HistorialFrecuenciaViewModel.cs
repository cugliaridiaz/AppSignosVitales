using MVPParteSofi.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Bogus;
using Android.OS;

namespace MVPParteSofi.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class HistorialFrecuenciaViewModel
    {

        public FrecuenciaData CurrentValor { get; set; } = new FrecuenciaData
        {
            DiaFrecuencia = DateTime.UtcNow.ToLocalTime(),

        };
        public List<FrecuenciaData> Frecuencias { get; set; }


        
        public HistorialFrecuenciaViewModel()
        {
            FillData();
            DeleteCommand();
        }

        public void FillData()
        {
            var valores =
                 App.FrecuenciaRepo.GetItems();
            valores =
                 valores.OrderByDescending(x => x.DiaFrecuencia).ToList();

            Frecuencias = new List<FrecuenciaData>(valores);
        }

        public async void DeleteCommand()
        {
            App.FrecuenciaRepo.DeleteItem(CurrentValor);
            FillData();
        }

    }
    
}



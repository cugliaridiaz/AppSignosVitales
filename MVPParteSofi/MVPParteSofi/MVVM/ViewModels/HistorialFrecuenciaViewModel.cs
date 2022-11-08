using MVPParteSofi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPParteSofi.MVVM.ViewModels
{
    
    public class HistorialFrecuenciaViewModel
    {
        public ObservableCollection<FrecuenciaSummary> Summary { get; set; }
        public ObservableCollection<FrecuenciaData> AnormalesList { get; set; } //declaro valores anormales
        public void GetFrecuenciaSummary()
        {
            var data =
                App.FrecuenciaRepo.GetItems();
            var result = 
                new List<FrecuenciaSummary>();
            var groupedFrecuencias =
                data.GroupBy(t => t.DiaFrecuencia.Date); //declaro orden por fecha

            foreach(var group in groupedFrecuencias)
            {
                var frecuenciaSummary = new FrecuenciaSummary
                {
                    DiaFrecuencia = group.Key,
                    ShownDate = group.Key.ToString("MM/dd")
                };
                result.Add(frecuenciaSummary);
            }
            result = result.OrderBy(x => x.DiaFrecuencia).ToList(); //orden por fecha

            Summary = new ObservableCollection<FrecuenciaSummary>(result);

            var anormalList = data.Where(x => x.ValorFrecuencia < 60 && x.ValorFrecuencia > 100); //valores anormales fuera de 60 y 100
            AnormalesList = new ObservableCollection<FrecuenciaData>(anormalList);
        }

    }
}

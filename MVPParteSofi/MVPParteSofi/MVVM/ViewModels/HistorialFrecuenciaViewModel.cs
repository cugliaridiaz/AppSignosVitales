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

namespace MVPParteSofi.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class HistorialFrecuenciaViewModel
    {

        public List<FrecuenciaData> Valores { get; set; }
        public FrecuenciaData CurrentValor { get; set; }
        public ObservableCollection<FrecuenciaData> Frecuencias { get; set; }
        public ICommand DeleteCommand { get; set; }

        
        public HistorialFrecuenciaViewModel()
        {
            DeleteCommand = new Command(() =>
            {
                App.FrecuenciaRepo.DeleteItem(CurrentValor);
                Refresh();
            });

            FillData();
        }

        public void FillData()
        {
            var valores =
                 App.FrecuenciaRepo.GetItems();
            valores =
                 valores.OrderByDescending(x => x.DiaFrecuencia).ToList();

            Frecuencias = new ObservableCollection<FrecuenciaData>(valores);
        }
        
         private void Refresh()
        {
            Valores = App.FrecuenciaRepo.GetItemsWithChildren();
        }
    }
    
}



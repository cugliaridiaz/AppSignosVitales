using MVPParteSofi.MVVM.Models;
using MVPParteSofi.MVVM.ViewModels;
using System.Collections.ObjectModel;

namespace MVPParteSofi.MVVM.View.Prof;

public partial class ExplorProf : ContentPage
{
    ObservableCollection<PacienteData> myList;
	public ExplorProf()
	{
		InitializeComponent();
        myList = new ObservableCollection<PacienteData>()
        {
            new PacienteData{PacienteName = "Sofía Diaz",
                            PacienteDNI = "43447054",
                            PacienteId = "11"},
            new PacienteData{PacienteName = "Sofía Cortés",
                            PacienteDNI = "42445566",
                            PacienteId = "12"},
            new PacienteData{PacienteName = "Francisco Robles",
                            PacienteDNI = "43000888",
                            PacienteId = "13"},
            new PacienteData{PacienteName = "Pablo Babini",
                            PacienteDNI = "40789789",
                            PacienteId = "14"},
        };

    }
	private void SearchBar_TextChanged (object sender, TextChangedEventArgs e)
	{
        myListView.ItemsSource = myList.Where(paciente => paciente.PacienteName.ToLower().Contains(e.NewTextValue.ToLower())).ToList();
    }
    private void SearchBar_TextChangedDNI(object sender, TextChangedEventArgs e)
    {
        myListView2.ItemsSource = myList.Where(paciente => paciente.PacienteDNI.StartsWith(e.NewTextValue));
    }
    private void SearchBar_TextChangedID(object sender, TextChangedEventArgs e)
    {
        myListView3.ItemsSource = myList.Where(paciente => paciente.PacienteId.StartsWith(e.NewTextValue));
    }
    private async void ItemTapped(object sender, ItemTappedEventArgs e)
    {
        PacienteData model = (PacienteData)e.Item;
        await Navigation.PushAsync(new PacienteDetail(model));
    }
}
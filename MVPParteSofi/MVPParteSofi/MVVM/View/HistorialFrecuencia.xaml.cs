using Android.OS;
using Microsoft.Maui.Controls;
using MVPParteSofi.MVVM.Models;
using MVPParteSofi.MVVM.ViewModels;
using SQLite;

namespace MVPParteSofi.MVVM.View;

public partial class HistorialFrecuencia : ContentPage
{
    public HistorialFrecuencia()
    {
        InitializeComponent();
        BindingContext = new HistorialFrecuenciaViewModel();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (HistorialFrecuenciaViewModel)BindingContext;
        vm.FillData();
    }
     private async void DeleteCommand(object obj, EventArgs e)
    {
            var currentVM =
            (HistorialFrecuenciaViewModel)BindingContext;
            currentVM.DeleteCommand();
            
    }
    private async void VolverHistorial(object obj, EventArgs e)
    {
        Navigation.PopToRootAsync();

    }

}


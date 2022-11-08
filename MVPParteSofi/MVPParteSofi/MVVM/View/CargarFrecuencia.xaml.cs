using MVPParteSofi.MVVM.Models;
using MVPParteSofi.MVVM.View;
using MVPParteSofi.MVVM.ViewModels;

namespace MVPParteSofi;

public partial class CargarFrecuencia : ContentPage
{
	public CargarFrecuencia()
	{
		InitializeComponent();
        BindingContext = new CargarFrecuenciaViewModel();
	}
	private async void ClickGuardarFrecuencia (object sender, EventArgs e)
	{
        var currentVM =
            (CargarFrecuenciaViewModel)BindingContext;
        var message =
            currentVM.GuardarFrecuencia();
        var Entry =
            currentVM.FrecuenciaData.ValorFrecuencia;
        await DisplayAlert("Su valor ha sido registrado", "{Entry} latidos/min.", "Aceptar", "Volver");
	}
	  private async void FrecuenciaPrueba (object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Prueba());
    }
      private async void HistorialFrecuencia(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistorialFrecuencia());
    }
}
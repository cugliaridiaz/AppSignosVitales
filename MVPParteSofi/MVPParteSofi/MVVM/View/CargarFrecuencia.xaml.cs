using MVPParteSofi.MVVM.View;

namespace MVPParteSofi;

public partial class CargarFrecuencia : ContentPage
{
	public CargarFrecuencia()
	{
		InitializeComponent();
	}
	private void Clickedbuttonguardarfrecuencia (object sender, EventArgs e)
	{
		DisplayAlert("Es correcto el valor:", "Entry", "Si", "No");
	}
	private void Volveriniciopaciente (object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
    private void Clickbluetooth(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Prueba());
    }
    private void ClickHistorialFrecuencia(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HistorialFrecuencia());
    }
    private void Clickbotontutorialfrecuencia(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void ClickAlarmaFrecuencia(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
}
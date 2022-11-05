namespace MVPParteSofi;

public partial class PacienteHistorial : ContentPage
{
	public PacienteHistorial()
	{
		InitializeComponent();
	}
    private void historial_fcardiaca(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void historial_glucemia(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void historial_presion(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void historial_peso(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void historial_satoxigeno(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void historial_temperatura(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
}
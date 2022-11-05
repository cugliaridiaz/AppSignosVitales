namespace MVPParteSofi;

public partial class PacienteInicio : ContentPage
{
	public PacienteInicio()
	{
		InitializeComponent();
	}
    private void fcardiaca(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CargarFrecuencia());
    }
    private void glucemia(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void presion(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void peso(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void satoxigeno(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void temperatura(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
}
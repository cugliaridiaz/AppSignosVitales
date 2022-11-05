namespace MVPParteSofi;

public partial class Prueba : ContentPage
{
	public Prueba()
	{
		InitializeComponent();
	}
    private void prueba1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PacienteInicio());
    }
    private void prueba2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PacienteHistorial());
    }
    private void prueba3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PacientePerfil());
    }
}
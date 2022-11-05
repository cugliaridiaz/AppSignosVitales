namespace MVPParteSofi;

public partial class PacientePerfil : ContentPage
{
	public PacientePerfil()
	{
		InitializeComponent();
	}
    private void editar_perfil(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void FAQs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
    private void cerrar_sesion(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Prueba());
    }
}
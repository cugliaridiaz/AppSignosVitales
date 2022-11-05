namespace MVPParteSofi;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ProfHome(); //cambiar la main page
	}
}

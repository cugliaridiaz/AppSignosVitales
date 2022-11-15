using MVPParteSofi.MVVM.Models;
using MVPParteSofi.MVVM.View;
using MVPParteSofi.MVVM.View.Prof;
using MVPParteSofi.Repositories;

namespace MVPParteSofi;

public partial class App : Application
{
	public static BaseRepository<FrecuenciaData>
		FrecuenciaRepo{ get; private set; }

    public static BaseRepository<PacienteData>
        PacienteRepo { get; private set; }

    public App(BaseRepository<FrecuenciaData>_frecuenciaRepo)
	{
		InitializeComponent();

		FrecuenciaRepo = _frecuenciaRepo;

        MainPage = new NavigationPage(new ExplorProf()); //cambiar la main page -- MainPage = new NavigationPage (new PacienteHome());
    }
}

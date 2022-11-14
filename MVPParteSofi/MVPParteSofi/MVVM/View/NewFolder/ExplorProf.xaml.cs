using MVPParteSofi.MVVM.ViewModels;

namespace MVPParteSofi.MVVM.View.NewFolder;

public partial class ExplorProf : ContentPage
{
	public ExplorProf()
	{
		InitializeComponent();
        BindingContext = new ExplorProfViewModel();

    }
}
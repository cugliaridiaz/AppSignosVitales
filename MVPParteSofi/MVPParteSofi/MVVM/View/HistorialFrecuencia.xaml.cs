using MVPParteSofi.MVVM.ViewModels;

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
		var vm = (HistorialFrecuenciaViewModel)BindingContext;
		vm.GetFrecuenciaSummary();
	}
}
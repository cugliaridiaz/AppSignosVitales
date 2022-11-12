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
        base.OnAppearing();
        var vm = (HistorialFrecuenciaViewModel)BindingContext;
        vm.FillData();
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}

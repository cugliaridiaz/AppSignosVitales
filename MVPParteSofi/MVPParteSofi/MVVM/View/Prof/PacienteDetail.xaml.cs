using MVPParteSofi.MVVM.Models;
using System.Collections.ObjectModel;

namespace MVPParteSofi.MVVM.View.Prof;

public partial class PacienteDetail : ContentPage
{
    PacienteData model;

    public PacienteDetail(PacienteData model)
	{
		InitializeComponent();
		this.model = model;


    }
}
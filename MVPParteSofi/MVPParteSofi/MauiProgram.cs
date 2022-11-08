using MVPParteSofi.MVVM.Models;
using MVPParteSofi.Repositories;
using Syncfusion.Maui.Core.Hosting;

namespace MVPParteSofi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<BaseRepository<FrecuenciaData>>();

		return builder.Build();
	}
}

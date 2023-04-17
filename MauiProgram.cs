using Microsoft.Extensions.Logging;
using NetMauiDistribuidora.Servicios;

namespace NetMauiDistribuidora;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		//builder.Services.AddSingleton<NetMauiDistribuidora.Interfaces.IFunctions, Functions>(); 
		// al final este no lo uso, lo voy a usar dentro de app para tener mas contexto
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

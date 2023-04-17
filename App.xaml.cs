using NetMauiDistribuidora.Servicios;
using NetMauiDistribuidora.ViewModels;

namespace NetMauiDistribuidora;

public partial class App : Application

{
    public new static App Current => (App)Application.Current;
	public IServiceProvider Services { get; }
    public App()
	{
		var services = new ServiceCollection();
		Services = ConfigureServices(services);
		InitializeComponent();

		MainPage = new AppShell();
	}
	private static IServiceProvider ConfigureServices(IServiceCollection services)
	{
		//SERVICIOS
		services.AddSingleton<NetMauiDistribuidora.Interfaces.IFunctions, Functions>();

		//VIEWMODELS
		services.AddTransient<TestViewModel>();
		return services.BuildServiceProvider();
	}//aca estoy creando metodo de servicios para tener todos los servicios a mano
	// aca voy a tener todas las inyeecciones y voy a hacerlo de la misma forma que functions
}

using NetMauiDistribuidora.Interfaces;
using NetMauiDistribuidora.ViewModels;

namespace NetMauiDistribuidora;

public partial class MainPage : ContentPage
{
   // private readonly IFunctions _function; al final el del video dijo que no se usa porque 

    public MainPage()
	{
		//_function = App.Current.Services.GetRequiredService<IFunctions>(); //this.Handler.MauiContext.Services.GetRequiredService<IFunctions>(); ya no, usamos el contexto de app
		BindingContext = App.Current.Services.GetRequiredService<TestViewModel>();// _function; porque se necesita que este enlazado al viewmodel
		InitializeComponent();
	}

}


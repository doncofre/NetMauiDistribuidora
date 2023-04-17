using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NetMauiDistribuidora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMauiDistribuidora.ViewModels
{
    public partial class TestViewModel : ObservableObject //hereda desde esta clase para usarla en el binding
    {
        [ObservableProperty]//decorador para que el binding tome la propiedad
        string text;
        [ObservableProperty]//decorador para que el binding tome la propiedad
        int contador = 0;
        private readonly IFunctions _functions;

        public TestViewModel(/*IFunctions functions*/) //ya no se usa, lo uso de la forma en la que va a estar abajo, la vista no soporta constructores sobrecargados
        {
            _functions = App.Current.Services.GetRequiredService<IFunctions>();//functions;
        }

        [RelayCommand] //decorador para que el binding lo encuentre
        public void CambiaTexto()
        {
            contador++;
            text = $"Contando:"; //Text se autogenera desde el toolkit de patron de diseño mvvm para que sea observable desde la vista, generada desde text
            Text = _functions.CambiaTexto(text, contador);

        }
    }
}

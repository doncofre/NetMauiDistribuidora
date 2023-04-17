using NetMauiDistribuidora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMauiDistribuidora.Servicios
{
    public class Functions : IFunctions
    {
        public Functions() { }
        public string CambiaTexto(string text, int count)
        {
            return text + count.ToString();
        }

    }
}

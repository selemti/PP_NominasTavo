using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Nominas.ViewModel
{
    public static class UtileriasGenerales
    {
        /// <summary>
        /// Muestra una alerta emergente en pantalla de forma asíncrona.
        /// </summary>
        public static async Task MostrarAlertaAsync(string titulo, string mensaje, string boton = "Aceptar")
        {
            var page = Application.Current?.MainPage;

            if (page != null)
            {
                await page.DisplayAlert(titulo, mensaje, boton);
            }
        }
    }
}

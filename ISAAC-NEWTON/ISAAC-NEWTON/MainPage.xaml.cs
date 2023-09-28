using System;
using Xamarin.Forms;

namespace ISAAC_NEWTON
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
          
        }

        // Otros métodos y controladores de eventos van aquí

        private void Button_Clicked(object sender, EventArgs e)
        {
            // URL del enlace a Facebook
            string facebookUrl = "https://www.facebook.com/I.E.P.ISAAC.NEWTON";

            try
            {
                // Abre la URL en el navegador web del dispositivo
                Device.OpenUri(new Uri(facebookUrl));
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al abrir la URL
                Console.WriteLine($"Error al abrir la URL: {ex.Message}");
            }
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            // URL del enlace a YouTube
            string youtubeUrl = "https://www.youtube.com/@institucioneducativaisaacn7723";

            try
            {
                // Abre la URL en la aplicación de navegador web del dispositivo
                Device.OpenUri(new Uri(youtubeUrl));
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al abrir la URL
                Console.WriteLine($"Error al abrir la URL de YouTube: {ex.Message}");
            }
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            // URL del enlace a la página web
            string webUrl = "https://l.facebook.com/l.php?u=https%3A%2F%2Fwww.ieisaacnewton.edu.pe%2F%3Ffbclid%3DIwAR3-EmwHm9FJ8nJn93xpeJY_ROTFRnMDCvo-CUJgva__Kt1Quusk2UT8ORs&h=AT2LvZT1YaaYLuOl92_nRRSmF1tQt6uCjYknPAGV4OpzoxGmxd0-pB8b6AuAqHzp3FusSKVSQv-IKRvw0DzXl5jTFN6LxfHztm-E0ZOGJd5t--0jGMEy5jx1YoHSubYK4V7BhQ";

            try
            {
                // Abre la URL en la aplicación de navegador web del dispositivo
                Device.OpenUri(new Uri(webUrl));
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al abrir la URL
                Console.WriteLine($"Error al abrir la URL de la página web: {ex.Message}");
            }
        }
        private void Matricular_Clicked(object sender, EventArgs e)
        {
            // URL del enlace al formulario de matriculación
            string matriculationUrl = "https://docs.google.com/forms/d/e/1FAIpQLSdThOiIGdFJEKEeyFO8Xyc_8N3NubSYx5Rwc_FlsMpX7EUtzQ/viewform?pli=1";

            try
            {
                // Abre la URL en el navegador web del dispositivo
                Device.OpenUri(new Uri(matriculationUrl));
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al abrir la URL
                Console.WriteLine($"Error al abrir el enlace de matriculación: {ex.Message}");
            }
        }

      
        

    }
}

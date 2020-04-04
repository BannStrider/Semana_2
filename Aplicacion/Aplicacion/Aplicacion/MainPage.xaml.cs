using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        string telefono;

        public MainPage()
        {
            InitializeComponent();
        }


        void OnTranslate(object sender, EventArgs e)
        {
            string telefono_introducido = txt_telefono.Text;
            telefono = Translator.ToNumber(telefono_introducido);

            if (!string.IsNullOrEmpty(telefono))
            {
                btn_llamar.IsEnabled = true;
                btn_llamar.Text = "Llamar " + telefono;
            }
            else
            {
                btn_llamar.IsEnabled = false;
                btn_llamar.Text = "Llamar";
            }
        }


        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Introduzca un número",
                "¿Llamar a " + telefono + "?",
                "Si",
                "No"))
            {
                try
                {
                    PhoneDialer.Open(telefono);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Imposible comunicar", "Número de teléfono no válido.", "OK");
                }
                catch (FeatureNotSupportedException)
                {
                    await DisplayAlert("Imposible comunicar", "Comunicacion no soportada.", "OK");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                    await DisplayAlert("Imposible comunicar", "Comunicación fallida.", "OK");
                }
            }
        }
    }
}

/** 
 * 1. ¿Qué extensión de marcado de Xamarin.Forms permite establecer una propiedad XAML en un valor estático que se define en una clase de código subyacente?
 * x:Static
 * 
 * 2. En XAML, {x:Static} y {x:Null} son ejemplos de ________.
 * Extensiones de marcado
 * 
 * 3. ¿Qué interfaz usa para crear una extensión de marcado personalizada?
 * IMarkupExtension
 * 
**/

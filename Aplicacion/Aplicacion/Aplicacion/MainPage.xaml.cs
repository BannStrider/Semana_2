using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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

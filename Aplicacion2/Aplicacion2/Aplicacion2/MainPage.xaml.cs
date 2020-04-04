using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicacion2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnHorizontalStartClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Start; }
        void OnHorizontalCenterClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Center; }
        void OnHorizontalEndClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.End; }
        void OnHorizontalFillClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Fill; }

        void OnVerticalStartClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Start; }
        void OnVerticalCenterClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Center; }
        void OnVerticalEndClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.End; }
        void OnVerticalFillClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Fill; }
    }
}

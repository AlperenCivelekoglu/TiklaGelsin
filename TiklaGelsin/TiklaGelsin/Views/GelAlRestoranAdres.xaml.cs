using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GelAlRestoranAdres : ContentPage
    {
        public GelAlRestoranAdres()
        {
            InitializeComponent();
        }

        private void Btn_Kyt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabbedPageGelAl());
        }
    }
}
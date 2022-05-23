using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void TapGestureRecognizer_Tapped_Sanagelsin(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabbedPageSanaGelsin());
        }

        private void TapGestureRecognizer_Tapped_Gelal(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GelAlRestoranAdres());
        }

        private void TapGestureRecognizer_Tapped_QRuret(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new GelAlRestoranAdres());
        }

        private void Btn_giris_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignİnPage());
        }

        private void Btn_kayıt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUpPage());
        }
    }
}
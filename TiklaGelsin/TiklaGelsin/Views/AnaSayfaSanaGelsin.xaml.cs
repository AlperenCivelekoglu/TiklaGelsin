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
    public partial class AnaSayfaSanaGelsin : ContentPage
    {
        public AnaSayfaSanaGelsin()
        {
            InitializeComponent();
            var images = new List<string>
            {
                "Kkarosel1.png",
                "Kkarosel2.png",
                "Kkarosel3.png",
                "Kkarosel4.png"
            };

            MainCarouselView.ItemsSource = images; //names;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Categories());
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PopeyesCategories());
        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SbarroCategories());
        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UstadonerciCategories());
        }

        private void TapGestureRecognizer_Tapped4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UstapideciCategories());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new Sepetim());
        }
    }
}
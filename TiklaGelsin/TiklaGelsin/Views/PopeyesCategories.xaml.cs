using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopeyesCategories : ContentPage
    {
        public PopeyesCategories()
        {
            InitializeComponent();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;

            await Navigation.PushModalAsync(new ProductsView(category));

            ((CollectionView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;
using TiklaGelsin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsView : ContentPage
    {
        CategoryViewModel cvm;
        public ProductsView(Category category)
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;
        }

        async private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as FoodItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductsDetail(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Sepetim());
        }
    }
}
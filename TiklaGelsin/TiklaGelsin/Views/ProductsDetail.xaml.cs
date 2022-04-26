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
    public partial class ProductsDetail : ContentPage
    {
        ProductDetailViewModel pvm;
        public ProductsDetail(FoodItem foodItem)
        {
            InitializeComponent();
            pvm = new ProductDetailViewModel(foodItem);
            this.BindingContext = pvm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
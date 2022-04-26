using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSettingPage : ContentPage
    {
        public AddSettingPage()
        {
            InitializeComponent();
        }

        async private void Button_Restaurants_Clicked(object sender, EventArgs e)
        {
            var acd = new AddRestaurantData();
            await acd.AddRestaurantAsync();
        }

        async private void Button_Categories_Clicked(object sender, EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
            await acd.AddPopeyesCategoriesAsync();
            await acd.AddSbarroCategoriesAsync();
            await acd.AddUstadonerciCategoriesAsync();
            await acd.AddUstapideciCategoriesAsync();
        }

        async private void Button_FoodItems_Clicked(object sender, EventArgs e)
        {
            var acd = new AddFoodItemData();
            await acd.AddFoodItemsAsync();
        }

        private void Button_Cart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
            {
                DisplayAlert("Success", "Cart Table Created", "Ok");
            }
            else
            {
                DisplayAlert("Error", "Error while creating table", "Ok");
            }
        }
    }
}
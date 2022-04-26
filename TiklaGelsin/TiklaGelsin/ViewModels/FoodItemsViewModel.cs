using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;
using TiklaGelsin.Services;
using TiklaGelsin.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = Xamarin.Forms.Application;

namespace TiklaGelsin.ViewModels
{
    public class FoodItemsViewModel : BaseViewModel
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
        }

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            get { return _UserCartItemsCount; }
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }
        }

        private string _SearchText;

        public string SearchText
        {
            get { return _SearchText; }
            set
            {
                _SearchText = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Category> PopeyesCategories { get; set; }
        public ObservableCollection<Category> SbarroCategories { get; set; }
        public ObservableCollection<Category> UstadonerciCategories { get; set; }
        public ObservableCollection<Category> UstapideciCategories { get; set; }

        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }
        public Command SearchViewCommand { get; set; }


        public FoodItemsViewModel()
        {
            var uname = Preferences.Get("UserName", string.Empty);
            if (String.IsNullOrEmpty(uname))
                UserName = "Guest";
            else
                UserName = uname;

            UserCartItemsCount = new CartItemService().GetUserCartCount();

            Categories = new ObservableCollection<Category>();
            PopeyesCategories = new ObservableCollection<Category>();
            SbarroCategories = new ObservableCollection<Category>();
            UstadonerciCategories = new ObservableCollection<Category>();
            UstapideciCategories = new ObservableCollection<Category>();

            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogoutCommand = new Command(async () => await LogoutAsync());
            SearchViewCommand = new Command(async () => await SearchViewAsync());

            GetCategories();
            GetPopeyesCategories();
            GetSbarroCategories();
            GetUstapideciCategories();
            GetUstadonerciCategories();
        }

        private async Task SearchViewAsync()
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new AramaSonuclari(SearchText));
        }

        private async Task LogoutAsync()
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new Logout());
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Sepetim());
        }

        private async void GetCategories()
        {
            var data = await new CategoryDataService().GetCategoriesAsync();
            Categories.Clear();
            foreach (var item in data)
            {
                Categories.Add(item);
            }
        }
        private async void GetPopeyesCategories()
        {
            var data = await new CategoryDataService().GetPopeyesCategoriesAsync();
            PopeyesCategories.Clear();
            foreach (var item in data)
            {
                PopeyesCategories.Add(item);
            }
        }
        private async void GetSbarroCategories()
        {
            var data = await new CategoryDataService().GetSbarroCategoriesAsync();
            SbarroCategories.Clear();
            foreach (var item in data)
            {
                SbarroCategories.Add(item);
            }
        }
        private async void GetUstapideciCategories()
        {
            var data = await new CategoryDataService().GetUstapideciCategoriesAsync();
            UstapideciCategories.Clear();
            foreach (var item in data)
            {
                UstapideciCategories.Add(item);
            }
        }
        private async void GetUstadonerciCategories()
        {
            var data = await new CategoryDataService().GetUstadonerciCategoriesAsync();
            UstadonerciCategories.Clear();
            foreach (var item in data)
            {
                UstadonerciCategories.Add(item);
            }
        }

    }
}

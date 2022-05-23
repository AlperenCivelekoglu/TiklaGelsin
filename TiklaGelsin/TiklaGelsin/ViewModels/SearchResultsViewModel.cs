using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TiklaGelsin.Models;
using TiklaGelsin.Services;

namespace TiklaGelsin.ViewModels
{
    public class SearchResultsViewModel :BaseViewModel
    {
        public ObservableCollection<FoodItem> FoodItemsByQuery { get; set; }

        private int _TotalFoodItems;

        public int TotalFoodItems
        {
            get { return _TotalFoodItems; }
            set
            {
                _TotalFoodItems = value;
                OnPropertyChanged();
            }
        }

        public SearchResultsViewModel(string searchText)
        {
            FoodItemsByQuery = new ObservableCollection<FoodItem>();
            GetFoodItemsByQueryAsync(searchText);
        }

        private async void GetFoodItemsByQueryAsync(string searchText)
        {
            var data = await new FoodItemService().GetFoodItemsByQueryAsync(searchText);
            FoodItemsByQuery.Clear();
            foreach (var item in data)
            {
                FoodItemsByQuery.Add(item);
            }
            TotalFoodItems = FoodItemsByQuery.Count;
        }
    }
}

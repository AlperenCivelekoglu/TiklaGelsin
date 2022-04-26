using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;

namespace TiklaGelsin.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;

        public CategoryDataService()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return categories;
        }
        public async Task<List<Category>> GetPopeyesCategoriesAsync()
        {
            var Popeyescategories = (await client.Child("PopeyesCategories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return Popeyescategories;
        }
        public async Task<List<Category>> GetSbarroCategoriesAsync()
        {
            var Sbarrocategories = (await client.Child("SbarroCategories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return Sbarrocategories;
        }
        public async Task<List<Category>> GetUstapideciCategoriesAsync()
        {
            var Ustapidecicategories = (await client.Child("UstapideciCategories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return Ustapidecicategories;
        }
        public async Task<List<Category>> GetUstadonerciCategoriesAsync()
        {
            var Ustadonercicategories = (await client.Child("UstadonerciCategories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName
                }
                ).ToList();
            return Ustadonercicategories;
        }


        public async Task<ObservableCollection<Category>> GetCategoryByRestaurantAsync(int restaurantID)
        {
            var categoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                categoriesByRestaurant.Add(item);
            }
            return categoriesByRestaurant;
        }
        public async Task<ObservableCollection<Category>> GetPopeyesCategoryByRestaurantAsync(int restaurantID)
        {
            var PopeyescategoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetPopeyesCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                PopeyescategoriesByRestaurant.Add(item);
            }
            return PopeyescategoriesByRestaurant;
        }
        public async Task<ObservableCollection<Category>> GetSbarroCategoryByRestaurantAsync(int restaurantID)
        {
            var SbarrocategoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetSbarroCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                SbarrocategoriesByRestaurant.Add(item);
            }
            return SbarrocategoriesByRestaurant;
        }
        public async Task<ObservableCollection<Category>> GetUstapideciCategoryByRestaurantAsync(int restaurantID)
        {
            var UstapidecicategoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetUstapideciCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                UstapidecicategoriesByRestaurant.Add(item);
            }
            return UstapidecicategoriesByRestaurant;
        }
        public async Task<ObservableCollection<Category>> GetUstadonerciCategoryByRestaurantAsync(int restaurantID)
        {
            var UstadonercicategoriesByRestaurant = new ObservableCollection<Category>();
            var items = (await GetUstadonerciCategoriesAsync()).Where(p => p.RestaurantID == restaurantID).ToList();
            foreach (var item in items)
            {
                UstadonercicategoriesByRestaurant.Add(item);
            }
            return UstadonercicategoriesByRestaurant;
        }
    }
}

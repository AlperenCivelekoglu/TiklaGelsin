using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;

namespace TiklaGelsin.Helpers
{
    internal class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        public List<Category> PopeyesCategories { get; set; }
        public List<Category> SbarroCategories { get; set; }
        public List<Category> UstadonerciCategories { get; set; }
        public List<Category> UstapideciCategories { get; set; }

        FirebaseClient client;

        public AddCategoryData()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");
            Categories = new List<Category>()
            {
                new Category()
                {
                 CategoryID=1,
                 CategoryName="Popular Urunler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=2,
                 CategoryName="Menuler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=3,
                 CategoryName="Burgerler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=4,
                 CategoryName="Kids Menuler",
                 RestaurantID=1
                },
                new Category()
                {
                 CategoryID=5,
                 CategoryName="Cıtır Lezzetler",
                 RestaurantID=1
                }
            };
            PopeyesCategories = new List<Category>(){
                new Category()
                {
                 CategoryID=6,
                 CategoryName="Popular Urunler",
                 RestaurantID=2
                },
                new Category()
                {
                 CategoryID=7,
                 CategoryName="Menuler",
                 RestaurantID=2
                },
                new Category()
                {
                 CategoryID=8,
                 CategoryName="Kovalar",
                 RestaurantID=2
                },
                new Category()
                {
                 CategoryID=7,
                 CategoryName="Tek Tavuk Urunler",
                 RestaurantID=2
                },
                new Category()
                {
                 CategoryID=10,
                 CategoryName="Tatlılar",
                 RestaurantID=2
                }
            };
            SbarroCategories = new List<Category>(){
                new Category()
                {
                 CategoryID=11,
                 CategoryName="Populer Urunler",
                 RestaurantID=3
                },
                new Category()
                {
                 CategoryID=12,
                 CategoryName="Pizzalar",
                 RestaurantID=3
                },
                new Category()
                {
                 CategoryID=13,
                 CategoryName="Yan urunler",
                 RestaurantID=3
                },
                new Category()
                {
                 CategoryID=14,
                 CategoryName="Tatlılar",
                 RestaurantID=3
                },
                new Category()
                {
                 CategoryID=15,
                 CategoryName="Salatalar",
                 RestaurantID=3
                }
            };
            UstadonerciCategories = new List<Category>(){
                new Category()
                {
                 CategoryID=16,
                 CategoryName="Popular Urunler",
                 RestaurantID=4
                },
                new Category()
                {
                 CategoryID=17,
                 CategoryName="Menuler",
                 RestaurantID=4
                },
                new Category()
                {
                 CategoryID=18,
                 CategoryName="Tek Urunler",
                 RestaurantID=4
                },
                new Category()
                {
                 CategoryID=19,
                 CategoryName="Cocuk Menuler",
                 RestaurantID=4
                },
                new Category()
                {
                 CategoryID=20,
                 CategoryName="Cıtır Lezzetler",
                 RestaurantID=4
                }
            };
            UstapideciCategories = new List<Category>(){
                new Category()
                {
                 CategoryID=21,
                 CategoryName="Popüler Ürenler",
                 RestaurantID=5
                },
                new Category()
                {
                 CategoryID=22,
                 CategoryName="Menüler",
                 RestaurantID=5
                },
                new Category()
                {
                 CategoryID=23,
                 CategoryName="Pideler",
                 RestaurantID=5
                },
                new Category()
                {
                 CategoryID=24,
                 CategoryName="Lahmacun",
                 RestaurantID=5
                },
                new Category()
                {
                 CategoryID=25,
                 CategoryName="Tatlılar",
                 RestaurantID=5
                }
            };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        public async Task AddPopeyesCategoriesAsync()
        {
            try
            {
                foreach (var category in PopeyesCategories)
                {
                    await client.Child("PopeyesCategories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        public async Task AddSbarroCategoriesAsync()
        {
            try
            {
                foreach (var category in SbarroCategories)
                {
                    await client.Child("SbarroCategories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        public async Task AddUstadonerciCategoriesAsync()
        {
            try
            {
                foreach (var category in UstadonerciCategories)
                {
                    await client.Child("UstadonerciCategories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        public async Task AddUstapideciCategoriesAsync()
        {
            try
            {
                foreach (var category in UstapideciCategories)
                {
                    await client.Child("UstapideciCategories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        RestaurantID = category.RestaurantID
                    });
                }
            }
            catch (Exception ex)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;

namespace TiklaGelsin.Helpers
{
    public class AddRestaurantData
    {
        public List<Restaurant> Restaurants { get; set; }
        FirebaseClient client;
        public AddRestaurantData()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");

            Restaurants = new List<Restaurant>()
                {
                new Restaurant()
                {
                 RestaurantID=1,
                 RestaurantName="Burger King",
                },
                new Restaurant()
                {
                 RestaurantID=2,
                 RestaurantName="Popeyes",

                },
                new Restaurant()
                {
                 RestaurantID=3,
                 RestaurantName="Sbarro",


                },
                new Restaurant()
                {
                 RestaurantID=4,
                 RestaurantName="Usta Donerci",


                },new Restaurant()
                {
                 RestaurantID=5,
                 RestaurantName="Usta Pideci",
                }

                };
        }

        public async Task AddRestaurantAsync()
        {
            try
            {
                foreach (var restaurant in Restaurants)
                {
                    await client.Child("Restaurants").PostAsync(new Restaurant()
                    {
                        RestaurantID = restaurant.RestaurantID,
                        RestaurantName = restaurant.RestaurantName,
                        // ImageUrl = restaurant.ImageUrl

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

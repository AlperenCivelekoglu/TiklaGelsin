using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;

namespace TiklaGelsin.Services
{
    public class RestaurantDataService
    {
        FirebaseClient client;

        public RestaurantDataService()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            var restaurants = (await client.Child("Categories")
                .OnceAsync<Restaurant>())
                .Select(r => new Restaurant
                {
                    RestaurantID = r.Object.RestaurantID,
                    RestaurantName = r.Object.RestaurantName,
                    // ImageUrl = r.Object.ImageUrl
                }
                ).ToList();
            return restaurants;
        }
    }
}

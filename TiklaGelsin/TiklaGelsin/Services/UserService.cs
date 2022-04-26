using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Firebase.Database.Query;
using TiklaGelsin.Models;
using static Xamarin.Essentials.Permissions;
using Xamarin.Essentials;

namespace TiklaGelsin.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<bool> IsUserExist(string uname)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return user != null;
        }

        public async Task<bool> RegisterUser(string uname, string passwd, string email, string ad, string soyad, int phoneno, int davetkodu)
        {
            if (await IsUserExist(uname) == false)
            {
                await client.Child("Users")
                    .PostAsync(new User()
                    {
                        Username = uname,
                        Password = passwd,
                        EMail = email,
                        Ad = ad,
                        Soyad = soyad,
                        PhoneNo = phoneno,
                        DavetKodu = davetkodu
                    });
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users")
                .OnceAsync<User>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();

            return (user != null);
        }

    }
}

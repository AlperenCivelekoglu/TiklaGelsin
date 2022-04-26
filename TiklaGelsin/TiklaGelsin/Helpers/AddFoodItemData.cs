using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TiklaGelsin.Models;

namespace TiklaGelsin.Helpers
{
    public class AddFoodItemData
    {
        public List<FoodItem> FoodItems { get; set; }
        FirebaseClient client;

        public AddFoodItemData()
        {
            client = new FirebaseClient("https://tiklagelsinapp-2922c-default-rtdb.europe-west1.firebasedatabase.app/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem()
                {
                  FoodItemID=1,
                  FoodItemName="3'lu Whooper",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_1000x750px_Dokme_Patates_3lu_Whopper_Firsati_7554f6ed61.png",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=2,
                  FoodItemName="Kral İkili",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_1000x750px_Dokme_Patates_Kralikili_0590ac6d89.png",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=3,
                  FoodItemName="Whooper Menu",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Whopper_Menu_3f669b8319.png",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=4,
                  FoodItemName="Benim İkilim",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Whopper_Menu_3f669b8319.png",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=5,
                  FoodItemName="Ogrenci Menusu",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_1000x750px_Dokme_Patates_Ogrenci_Menusu_3968981d9d.png",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=6,
                  FoodItemName="4'lu Whooper JR",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/4lu_double_whopper_jr_0b9dc81de4.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=7,
                  FoodItemName="2'li Gurme",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_1000x750px_Dokme_Patates_2li_Gurme_Firsati_299c9698c0.png",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=8,
                  FoodItemName="Benim Uclum",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_Dokme_Patates_Benimuclum2_867f093052.png",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=9,
                  FoodItemName="Benim Dortlum",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_Dokme_Patates_Benim_Dortlum2_d8492ec58e.png",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=10,
                  FoodItemName="3’lu Gurme Fırsatı",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Kamp_1000x750px_Dokme_Patates_3lu_Gurme_Firsati_e00c0407cd.png",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=11,
                  FoodItemName="Double Whooper",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/double_whopper_c5b43d5d2a.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=12,
                  FoodItemName="Double Whopper Jr.",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/double_whopper_jr_40473949cc.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=13,
                  FoodItemName="Barbeko Burger",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/barbeko_burger_8bd5d54f47.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=14,
                  FoodItemName="Whopper Dürüm",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/whopper_durum_f3335ea157.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=15,
                  FoodItemName="Whopper",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/whopper_90d608faab.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=16,
                  FoodItemName="Kids Hamburger Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Kids_Hamburger_Menu_Oyuncaksiz_7c415fcb24.png",
                  CategoryID=4,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=17,
                  FoodItemName="Kids Cheese Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Kids_Cheese_Burger_Menu_7d81c0244b.png",
                  CategoryID=4,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=18,
                  FoodItemName="Tavuklu Kids Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Kids_Tavuklu_Menu_8d79b790b5.png",
                  CategoryID=4,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=19,
                  FoodItemName="Kids Chicken Tenders Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Kids_Chicken_Tenders_Menu_08e9682b73.png",
                  CategoryID=4,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=20,
                  FoodItemName="Tavuklu Kids Cheese Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TG_App_Menuler_Dokme_Patates_Kids_Tavuklu_Cheese_Burger_Menu_0c8901adf2.png",
                  CategoryID=4,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=21,
                  FoodItemName="Patates Kızartması (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/patates_kizartmasi_kucuk_9da3750c94.webp",
                  CategoryID=5,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=22,
                  FoodItemName="Patates Kızartması (Orta)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/patates_kizartmasi_kucuk_9da3750c94.webp",
                  CategoryID=5,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=23,
                  FoodItemName="Patates Kızartması (Büyük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/patates_kizartmasi_kucuk_9da3750c94.webp",
                  CategoryID=5,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=24,
                  FoodItemName="Patates Kızartması (King)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/patates_kizartmasi_kucuk_9da3750c94.webp",
                  CategoryID=5,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=25,
                  FoodItemName="Patates Kızartması (Kova)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/patates_kizartmasi_kucuk_9da3750c94.webp",
                  CategoryID=5,
                  RestaurantID=1
                },
                new FoodItem()
                {
                  FoodItemID=26,
                  FoodItemName="Popeyes Ramazan",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/popeyes_ramazan_menusu_4aa0ad3aff.webp",
                  CategoryID=6,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=27,
                  FoodItemName="4 kişilik Doyuran Kova",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/4_kisilik_doyuran_kova_1a8c482f98.webp",
                  CategoryID=6,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=28,
                  FoodItemName="3 kişilik Doyuran Kova",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/3_kisilik_doyuran_kova_2733b75c6a.webp",
                  CategoryID=6,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=29,
                  FoodItemName="2 kişilik Doyuran Kova",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/2_kisilik_sandvicli_kova_menu_e9cbf02937.webp",
                  CategoryID=6,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=30,
                  FoodItemName="Hayallerimin Kovası",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/hayallerimin_kovasi_227f83d8fc.webp",
                  CategoryID=6,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=31,
                  FoodItemName="3 Parça Tavuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/3_parca_tavuk_menu_d736c6d5d8.webp",
                  CategoryID=7,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=32,
                  FoodItemName="4 Parça Tavuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/4_parca_tavuk_menu_5cd813a15f.webp",
                  CategoryID=7,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=33,
                  FoodItemName="4 Parça Acılı Tavuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/4_parca_acili_kanat_menu_6be27d3351.webp",
                  CategoryID=7,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=34,
                  FoodItemName="7 Parça Tavuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/7_parca_acili_kanat_menu_f5da08d702.webp",
                  CategoryID=7,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=35,
                  FoodItemName="7 Parça Acılı Tavuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/7_parca_acili_kanat_menu_f5da08d702.webp",
                  CategoryID=7,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=36,
                  FoodItemName="2 Kişilik Kemiksiz Kova Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/2_kisilik_kemiksiz_kova_menu_d8b9690de3.webp",
                  CategoryID=8,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=37,
                  FoodItemName="4 Kişilik Parça Tavuk Kova Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/4_kisilik_parca_tavuk_kova_menu_9edf771013.webp",
                  CategoryID=8,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=38,
                  FoodItemName="3 Kişilik Efsane Kova Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/2_kisilik_kanat_kova_menu_69466bd9ea.webp",
                  CategoryID=8,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=39,
                  FoodItemName="2 Kişilik Kanat Kova Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/3_kisilik_efsane_kova_menu_d0cc1243e9.webp",
                  CategoryID=8,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=40,
                  FoodItemName="4 Kişilik Kanat Kova Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/4_kisilik_kanat_kova_menu_6c521e8843.webp",
                  CategoryID=8,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=41,
                  FoodItemName="1 Parça Göğüs",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/1_parca_gogus_0dd37a4fe6.webp",
                  CategoryID=9,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=42,
                  FoodItemName="1 Parça Kaburga",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/1_parca_gogus_0dd37a4fe6.webp",
                  CategoryID=9,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=43,
                  FoodItemName="1 Parça Kalça",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/1_parca_gogus_0dd37a4fe6.webp",
                  CategoryID=9,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=44,
                  FoodItemName="1 Parça But",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/1_parca_gogus_0dd37a4fe6.webp",
                  CategoryID=9,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=45,
                  FoodItemName="1 Parça Acılı Kanat (Wings)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/1_parca_acili_kanat_wings_a56635a610.webp",
                  CategoryID=9,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=46,
                  FoodItemName="Sufle",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/sufle_0734c40cb3.webp",
                  CategoryID=10,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=47,
                  FoodItemName="Algida Maraş Usulü Dondurma",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/algida_maras_usulu_cup_dondurma_100_ml_3bab0b0f37.webp",
                  CategoryID=10,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=48,
                  FoodItemName="Algida Carte d'Or Mini Cup Çikolata Karnavalı ",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/algida_carte_dor_mini_cup_cikolata_karnavali_110_ml_921d14534d.webp",
                  CategoryID=10,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=49,
                  FoodItemName="Algida Mini Nogger Sandwich",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/algida_mini_nogger_sandwich_60_ml_fe2a18c873.webp",
                  CategoryID=10,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=50,
                  FoodItemName="Algida Carte d Or Mini Cup Meyve Rüyası",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/popeyes/algida_carte_dor_mini_cup_cilekli_yogurtlu_110_ml_d8c849f6ce.webp",
                  CategoryID=10,
                  RestaurantID=2
                },
                new FoodItem()
                {
                  FoodItemID=51,
                  FoodItemName="Sbarro Ramazan Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/sbarro_ramazan_menusu_0958192cde.webp",
                  CategoryID=11,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=52,
                  FoodItemName="Sbarro Öğrenci Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/sbarro_ogrenci_menusu_838e9f5256.webp",
                  CategoryID=11,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=53,
                  FoodItemName="Muhteşem 3'lü Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/SB_TA_574x267px_Muhtesem3lu_469460f89d.png",
                  CategoryID=11,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=54,
                  FoodItemName="Orta'lı Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/SB_TA_574x267px_Ortali_Menu_e0d66397c6.png",
                  CategoryID=11,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=55,
                  FoodItemName="Muhteşem 3'lü Orta Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/muhtesem_3lu_orta_menu_9b2f98ec67.webp",
                  CategoryID=11,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=56,
                  FoodItemName="Küçük Boy 4 Peynirli Pizza",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kucuk_boy_4_peynirli_pizza_c114c88738.webp",
                  CategoryID=12,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=57,
                  FoodItemName="Küçük Boy Eko Sucuklu Pizza",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kucuk_boy_eko_sucuklu_pizza_b0c143abdd.webp",
                  CategoryID=12,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=58,
                  FoodItemName="Küçük Boy Sucuklu Favori Pizza",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kucuk_boy_sucuklu_favori_pizza_306b1d01e3.webp",
                  CategoryID=12,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=59,
                  FoodItemName="Küçük Boy Gamer Pizza",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kucuk_boy_gamer_pizza_4b08452b7a.webp",
                  CategoryID=12,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=60,
                  FoodItemName="Küçük Boy Etli Karışık Pizza",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kucuk_boy_etli_karisik_pizza_4477b96d9e.webp",
                  CategoryID=12,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=61,
                  FoodItemName="20'li Kova Kanat",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kova_kanat_5b2ed0df85.webp",
                  CategoryID=13,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=62,
                  FoodItemName="Wrap (Ispanaklı)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/wrap_ispanakli_85fe4126c3.webp",
                  CategoryID=13,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=63,
                  FoodItemName="Tereyağlı Fırın Patates (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/tereyagli_firin_patates_kucuk_7ba6ba4c69.webp",
                  CategoryID=13,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=64,
                  FoodItemName="Tereyağlı Fırın Patates (Büyük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/tereyagli_firin_patates_kucuk_7ba6ba4c69.webp",
                  CategoryID=13,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=65,
                  FoodItemName="Wrap (Tavuklu)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/wrap_tavuklu_588d93b0e9.webp",
                  CategoryID=13,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=66,
                  FoodItemName="Sufle",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/sufle_e903fc88eb.webp",
                  CategoryID=14,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=67,
                  FoodItemName="Künefe (Kaymaklı)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/kaymakli_kunefe_9a2745ed42.webp",
                  CategoryID=14,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=68,
                  FoodItemName="Damla Çikolatalı Tiramisu",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/damla_cikolatali_tiramisu_61e769ef83.webp",
                  CategoryID=14,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=69,
                  FoodItemName="Künefe",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TA_574x267px_Kunefe_cec10a1b45.png",
                  CategoryID=14,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=70,
                  FoodItemName="Künefe",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/TA_574x267px_Kunefe_cec10a1b45.png",
                  CategoryID=14,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=71,
                  FoodItemName="Akdeniz Salata (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/akdeniz_salata_kucuk_babf991c8c.webp",
                  CategoryID=15,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=72,
                  FoodItemName="Akdeniz Salata (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/akdeniz_salata_kucuk_babf991c8c.webp",
                  CategoryID=15,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=73,
                  FoodItemName="Akdeniz Salata (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/akdeniz_salata_kucuk_babf991c8c.webp",
                  CategoryID=15,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=74,
                  FoodItemName="Akdeniz Salata (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/akdeniz_salata_kucuk_babf991c8c.webp",
                  CategoryID=15,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=75,
                  FoodItemName="Akdeniz Salata (Küçük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/sbarro/akdeniz_salata_kucuk_babf991c8c.webp",
                  CategoryID=15,
                  RestaurantID=3
                },
                new FoodItem()
                {
                  FoodItemID=76,
                  FoodItemName="Bol Bol Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/bol_bol_menu_b4399a2940.webp",
                  CategoryID=16,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=77,
                  FoodItemName="2'li Baget Et Döner Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/2li_baget_et_doner_menu_92b3981ec0.webp",
                  CategoryID=16,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=78,
                  FoodItemName="Seçmeli Baget Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/secmeli_baget_menu_18a7397b87.webp",
                  CategoryID=16,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=79,
                  FoodItemName="Usta Dönerci Öğrenci Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/usta_donerci_ogrenci_menusu_59d28bab62.webp",
                  CategoryID=16,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=80,
                  FoodItemName="Tombik Avantaj Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/UD_Kampanyalar_344x160px_Tombik_Avantaj_8fd279e85e.jpg",
                  CategoryID=16,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=81,
                  FoodItemName="Köfte Ekmek Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/kofte_ekmek_menu_d535c42985.webp",
                  CategoryID=17,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=82,
                  FoodItemName="5'li Köfte Porsiyon Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/5li_kofte_porsiyon_menu_d8c3b9965b.webp",
                  CategoryID=17,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=83,
                  FoodItemName="5'li Köfte Porsiyon Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/5li_kofte_porsiyon_menu_d8c3b9965b.webp",
                  CategoryID=17,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=84,
                  FoodItemName="8'li Köfte Porsiyon Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/8li_kofte_porsiyon_menu_6805d23b63.webp",
                  CategoryID=17,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=85,
                  FoodItemName="8'li Köfte Porsiyon Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/8li_kofte_porsiyon_menu_6805d23b63.webp",
                  CategoryID=17,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=86,
                  FoodItemName="Köfte Ekmek",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/kofte_ekmek_c9569f433f.webp",
                  CategoryID=18,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=87,
                  FoodItemName="5'li Köfte Porsiyon",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/5li_kofte_porsiyon_16dc7319c3.webp",
                  CategoryID=18,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=88,
                  FoodItemName="8'li Köfte Porsiyon",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/8li_kofte_porsiyon_8ee65f21c6.webp",
                  CategoryID=18,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=89,
                  FoodItemName="5'li Köfte Porsiyon",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/5li_kofte_porsiyon_16dc7319c3.webp",
                  CategoryID=18,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=90,
                  FoodItemName="8'li Köfte Porsiyon",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/8li_kofte_porsiyon_8ee65f21c6.webp",
                  CategoryID=18,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=91,
                  FoodItemName="Tombik Et Döner Çocuk Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/et_tombik_doner_menu_aa71dd3bf9.webp",
                  CategoryID=19,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=92,
                  FoodItemName="Tombik Et Döner Çocuk Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/et_tombik_doner_menu_aa71dd3bf9.webp",
                  CategoryID=19,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=93,
                  FoodItemName="Tombik Et Döner Çocuk Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/et_tombik_doner_menu_aa71dd3bf9.webp",
                  CategoryID=19,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=94,
                  FoodItemName="Tavuk Tombik Döner Çocuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/tavuk_tombik_doner_menu_e5135accfa.webp",
                  CategoryID=19,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=95,
                  FoodItemName="Tavuk Tombik Döner Çocuk Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/tavuk_tombik_doner_menu_e5135accfa.webp",
                  CategoryID=19,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=96,
                  FoodItemName="Patates Kızartması (Kova)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/kova_patates_1ff872b4ee.webp",
                  CategoryID=20,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=97,
                  FoodItemName="Patates Kızartması (Orta)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/patates_kizartmasi_orta_b9c7d16d76.webp",
                  CategoryID=20,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=98,
                  FoodItemName="Patates Kızartması (Büyük)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/patates_kizartmasi_buyuk_ddada45915.webp",
                  CategoryID=20,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=99,
                  FoodItemName="Patates Kızartması (Dublex)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/patates_kizartmasi_dublex_418e07e4cd.webp",
                  CategoryID=20,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=100,
                  FoodItemName="Soğan Halkası (6'lı)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-donerci/sogan_halkasi_6_li_00cd869de2.webp",
                  CategoryID=20,
                  RestaurantID=4
                },
                new FoodItem()
                {
                  FoodItemID=101,
                  FoodItemName="Usta Pideci Ramazan Menüsü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/usta_pideci_ramazan_menusu_a9fa2febb0.webp",
                  CategoryID=21,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=102,
                  FoodItemName="Künefe",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kunefe_d92f057738.webp",
                  CategoryID=21,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=103,
                  FoodItemName="2'li Lahmacun Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/2li_lahmacun_menu_373c0d4208.webp",
                  CategoryID=21,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=104,
                  FoodItemName="4'lü Lahmacun Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/4lu_lahmacun_menu_34365ebf4a.webp",
                  CategoryID=21,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=105,
                  FoodItemName="Kıymalı Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kiymali_pide_menu_9c049cd950.webp",
                  CategoryID=21,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=106,
                  FoodItemName="Kuşbaşılı Kaşarlı Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kusbasili_kasarli_pide_menu_7e2fe9ea69.webp",
                  CategoryID=22,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=107,
                  FoodItemName="Sebzeli Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/sebzeli_pide_menu_ad23dfd9b1.webp",
                  CategoryID=22,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=108,
                  FoodItemName="Mantarlı Kaşarlı Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/mantarli_kasarli_pide_menu_ed10327ca8.webp",
                  CategoryID=22,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=109,
                  FoodItemName="Usta Karışık Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/usta_karisik_pide_menu_3e86fe9080.webp",
                  CategoryID=22,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=110,
                  FoodItemName="Kıymalı Pide Menü",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kiymali_pide_menu_9c049cd950.webp",
                  CategoryID=22,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=111,
                  FoodItemName="Mantarlı Kaşarlı Pide",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/mantarli_kasarli_pide_42e268c02a.webp",
                  CategoryID=23,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=112,
                  FoodItemName="Kuşbaşılı Kaşarlı Pide",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kusbasili_kasarli_pide_f3cdd65cfc.webp",
                  CategoryID=23,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=113,
                  FoodItemName="Usta Karışık Pide",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/usta_karisik_pide_4b3ac0a825.webp",
                  CategoryID=23,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=114,
                  FoodItemName="Sucuklu Kaşarlı Pide",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/sucuklu_kasarli_pide_e6c7e18b0b.webp",
                  CategoryID=23,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=115,
                  FoodItemName="Kuşbaşılı Pide",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kusbasili_pide_a370fb3626.webp",
                  CategoryID=23,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=116,
                  FoodItemName="Acılı Lahmacun",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/acili_lahmacun_7cebb6c6e5.webp",
                  CategoryID=24,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=117,
                  FoodItemName="Acılı Lahmacun",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/acili_lahmacun_7cebb6c6e5.webp",
                  CategoryID=24,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=118,
                  FoodItemName="Acılı Lahmacun",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/acili_lahmacun_7cebb6c6e5.webp",
                  CategoryID=24,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=119,
                  FoodItemName="Lahmacun",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/acili_lahmacun_7cebb6c6e5.webp",
                  CategoryID=24,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=120,
                  FoodItemName="Lahmacun",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/acili_lahmacun_7cebb6c6e5.webp",
                  CategoryID=24,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=121,
                  FoodItemName="Künefe (Kaymaklı)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kaymakli_kunefe_822e55ff88.webp",
                  CategoryID=25,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=122,
                  FoodItemName="Sufle",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/sufle_491d53bd9a.webp",
                  CategoryID=25,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=123,
                  FoodItemName="Künefe",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kunefe_d92f057738.webp",
                  CategoryID=25,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=124,
                  FoodItemName="Künefe",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kunefe_d92f057738.webp",
                  CategoryID=25,
                  RestaurantID=5
                },
                new FoodItem()
                {
                  FoodItemID=125,
                  FoodItemName="Künefe (Kaymaklı)",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/usta-pideci/kunefe_d92f057738.webp",
                  CategoryID=25,
                  RestaurantID=5
                },
            };
        }

        public async Task AddFoodItemsAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        RestaurantID = item.RestaurantID,
                        FoodItemID = item.FoodItemID,
                        FoodItemName = item.FoodItemName,
                        Price = item.Price,
                        ImageUrl = item.ImageUrl,

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

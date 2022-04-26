using System;
using System.Collections.Generic;
using System.Text;

namespace TiklaGelsin.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public int PhoneNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DavetKodu { get; set; }
    }
}

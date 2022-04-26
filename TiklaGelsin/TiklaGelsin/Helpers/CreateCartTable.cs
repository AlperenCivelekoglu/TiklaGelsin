﻿using System;
using System.Collections.Generic;
using System.Text;
using TiklaGelsin.Models;
using Xamarin.Forms;

namespace TiklaGelsin.Helpers
{
    public class CreateCartTable
    {
        public bool CreateTable()
        {
            try
            {
                var cn = DependencyService.Get<ISQLite>().GetConnection();
                cn.CreateTable<CartItem>();
                cn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

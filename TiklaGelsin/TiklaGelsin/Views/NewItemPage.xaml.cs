using System;
using System.Collections.Generic;
using System.ComponentModel;
using TiklaGelsin.Models;
using TiklaGelsin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiklaGelsin.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
﻿using BedayzMobil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedayzMobil.Services;
using BedayzMobil.Data;
using BedayzMobil.ViewModels;
using BedayzMobil.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BedayzMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ÜrünSayfasi : ContentPage
    {

        ÜrünItem ÜrünBilgileri;
        public ÜrünSayfasi(ÜrünItem ürünItem)
        {
            InitializeComponent();
            ÜrünBilgileri = ürünItem;
            Image.Source = ürünItem.ImageSource;
            Name.Text = ürünItem.Ürünİsmi;
            Detail.Text = ürünItem.ÜrünDetayı;
            Cost.Text = ürünItem.ÜrünFiyatı;
        }
    }
}
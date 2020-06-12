using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin7.Models;
using xamarin7.Services;
using xamarin7.ViewModels;

namespace xamarin7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Item Item  { get; set; }
        public Item Item2  { get; set; }
        public Item Item3 { get; set; }
        public Item Item4 { get; set; }
        public Item Item5 { get; set; }
        public Item Item6 { get; set; }



        //private List<Item> items;

        ÜrünModel ürünModel;
        public Anasayfa()

        {
            MockDataStore dataStore = new MockDataStore();
            InitializeComponent();

            Item = new Item
            {  
                Id="1",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/quarantine-30.jpg?t=20200516182750"
                
            };
            Item2 = new Item
            {
                Id="2",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/bandana-29.jpg?t=20200427155138"
            };
            Item3 = new Item
            {
                Id = "3",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/hope-28.jpg?t=20200421183821"
            };
            Item4 = new Item
            {
                Id = "4",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/munchies-sweat-24.jpg?t=20200302184902"
            };
            Item5 = new Item
            {
                Id = "5",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/key-chains-23.jpg?t=20200120215546"
            };
            Item6 = new Item
            {
                Id = "6",
                Text = "",
                Description = "https://www.bedayz.com/Uploads/Slider/savage-21.jpg?t=20200302185000"
            };

            //bunu atmayı öğren
            //items = new List<Item>()
            //{
            //    new Item { Id = "1", Text = "Fotograf", Description="https://www.bedayz.com/Uploads/Slider/quarantine-30.jpg?t=20200516182750" },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Second Fotograf", Description="https://www.bedayz.com/Uploads/Slider/bandana-29.jpg?t=20200427155138" },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Third Fotograf", Description="https://www.bedayz.com/Uploads/Slider/hope-28.jpg?t=20200421183821" },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/munchies-sweat-24.jpg?t=20200302184902" },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/key-chains-23.jpg?t=20200120215546" },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/savage-21.jpg?t=20200302185000" }
            //};

            BindingContext = this;


            
            var images = new List<string>
            {
                Item.Description,Item2.Description, Item3.Description, Item4.Description, Item5.Description, Item6.Description
            };

            MainCarouselView.ItemsSource = images;

            ürünModel = new ÜrünModel(this);
            BindingContext = ürünModel;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            new NavigationPage(new CokSatanlarPage());
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {

        }
    }
}




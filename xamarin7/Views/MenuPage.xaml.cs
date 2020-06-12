using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using xamarin7.Models;

namespace xamarin7.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.ANASAYFA, Title="ANASAYFA" },
                new HomeMenuItem {Id = MenuItemType.HOODIE, Title="HOODIE" },
                new HomeMenuItem {Id = MenuItemType.SWEATSHIRT, Title="SWEATSHIRT" },
                new HomeMenuItem {Id = MenuItemType.ACCESSORY, Title="ACCESSORY" },
                new HomeMenuItem {Id = MenuItemType.TRACKSUIT, Title="TRACKSUIT AND COAT" },
                new HomeMenuItem {Id = MenuItemType.TSHIRT, Title="T-SHIRT" }

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}
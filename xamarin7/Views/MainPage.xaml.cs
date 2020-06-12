using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

using xamarin7.Models;

namespace xamarin7.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.ANASAYFA:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.HOODIE:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.SWEATSHIRT:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.ACCESSORY:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.TRACKSUIT:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                    case (int)MenuItemType.TSHIRT:
                        MenuPages.Add(id, new NavigationPage(new Anasayfa()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
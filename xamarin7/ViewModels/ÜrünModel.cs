using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using xamarin7.Models;

namespace xamarin7.ViewModels
{
   public class ÜrünModel: BindableObject
    {
        private Page Page;

        public ÜrünModel(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();
        }

        private void AddItems()
        {
            ÜrünItem ürünItem = new ÜrünItem()
               {
                   ID = "1",
                   ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/quarantine-t-shirt-7983.jpg",
                   Ürünİsmi = "QUARANTINE T-SHIRT",
                   ÜrünEskiFiyatı = "",
                   ÜrünFiyatı = "₺89,90"
               };
                ÜrünItem ürünItem2 = new ÜrünItem()
                {
                    ID = "2",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/white-munchies-t-shirt-firsat-kutusu-6e9d.jpg",
                    Ürünİsmi = "WHITE MUNCHIES T-SHIRT FIRSAT KUTUSU",
                    ÜrünEskiFiyatı = "₺134,70",
                    ÜrünFiyatı = "₺104,90"
                };
                ÜrünItem ürünItem3 = new ÜrünItem()
                {
                    ID = "3",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/red-munchies-t-shirt-firsat-kutusu-e856.jpg",
                    Ürünİsmi = "RED MUNCHIES T-SHIRT FIRSAT KUTUSU",
                    ÜrünEskiFiyatı = "₺134,70",
                    ÜrünFiyatı = "₺104,90"
                };
                ÜrünItem ürünItem4 = new ÜrünItem()
                {
                    ID = "4",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/bandana-set-d4c9.jpg",
                    Ürünİsmi = "BANDANA SET",
                    ÜrünEskiFiyatı = "₺69,80",
                    ÜrünFiyatı = "₺54,90"
                };
                ÜrünItem ürünItem5 = new ÜrünItem()
                {
                    ID = "5",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/tokyo-oversize-t-shirt-8171.jpg",
                    Ürünİsmi = "TOKYO OVERSIZE T-SHIRT",
                    ÜrünEskiFiyatı = "",
                    ÜrünFiyatı = "₺109,90"
                };
                ÜrünItem ürünItem6 = new ÜrünItem()
                {
                    ID = "6",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/amnesia-sweatshirt-b468.jpg",
                    Ürünİsmi = "AMNESIA SWEATSHIRT",
                    ÜrünEskiFiyatı = "",
                    ÜrünFiyatı ="₺119,90"
                };
                ÜrünItem ürünItem7 = new ÜrünItem()
                {
                    ID = "7",
                    ImageSource = "https://www.bedayz.com/Uploads/UrunResimleri/thumb/neon-stay-high-bere-72e6.jpg",
                    Ürünİsmi = "NEON STAY HIGH BERE",
                    ÜrünEskiFiyatı = "",
                    ÜrünFiyatı = "₺39,90"
                };

                Items.Add(ürünItem);
                Items.Add(ürünItem2);
                Items.Add(ürünItem3);
                Items.Add(ürünItem4);
                Items.Add(ürünItem5);
                Items.Add(ürünItem6);
                Items.Add(ürünItem7);


        }



        private ObservableCollection<ÜrünItem> _items = new ObservableCollection<ÜrünItem>();
        public ObservableCollection<ÜrünItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}


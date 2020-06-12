using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin7.Models
{
    public class ÜrünItem
    {
        private string id;

          public string ID
        {
            get { return id; }
            set { id = value; }
        }


        private string image;

        public string ImageSource
        {
            get { return image; }
            set { image = value; }
        }



        private string ürünİsmi;

        public string Ürünİsmi
        {
            get { return ürünİsmi; }
            set { ürünİsmi = value; }
        }

        private string ürünEskiFiyati;

        public string ÜrünEskiFiyatı
        {
            get { return ürünEskiFiyati; }
            set { ürünEskiFiyati = value; }
        }


        private string ürünFiyati;

        public string ÜrünFiyatı
        {
            get { return ürünFiyati; }
            set { ürünFiyati = value; }
        }

    }
}

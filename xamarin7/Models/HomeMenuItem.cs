namespace xamarin7.Models
{
    public enum MenuItemType
    {
        Browse,
        ANASAYFA,
        HOODIE,
        SWEATSHIRT,
        ACCESSORY,
        TRACKSUIT,
        TSHIRT,
        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

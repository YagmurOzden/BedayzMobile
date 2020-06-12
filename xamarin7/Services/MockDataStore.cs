using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xamarin7.Models;

namespace xamarin7.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = "1", Text = "Fotograf", Description="https://www.bedayz.com/Uploads/Slider/quarantine-30.jpg?t=20200516182750" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second Fotograf", Description="https://www.bedayz.com/Uploads/Slider/bandana-29.jpg?t=20200427155138" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third Fotograf", Description="https://www.bedayz.com/Uploads/Slider/hope-28.jpg?t=20200421183821" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/munchies-sweat-24.jpg?t=20200302184902" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/key-chains-23.jpg?t=20200120215546" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth Fotograf", Description="https://www.bedayz.com/Uploads/Slider/savage-21.jpg?t=20200302185000" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
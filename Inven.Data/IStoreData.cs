using Inven.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven.Data
{
    public interface IStoreData
    {
        IEnumerable<Store> GetStoresByName(string name);
        Store GetById(int id);
        String GetStoreNameByID(int id);
    }

    public class InMemoryStoreData : IStoreData
    {
        List<Store> stores;
        public InMemoryStoreData()
        {
            stores = new List<Store>
            {
                new Store { Id = 1, StoreName = "Store1", Location = "Columbus", StoreType = StoreType.Furnitures },
                new Store { Id = 2, StoreName = "Store2 Grocery", Location = "Bangalore", StoreType = StoreType.Grocery },
                new Store { Id = 3, StoreName = "Sample Grocery", Location = "Bangalore", StoreType = StoreType.Grocery }
            };
        }

        public Store GetById(int id)
        {
            return stores.SingleOrDefault(s => s.Id == id);
        }
        public IEnumerable<Store> GetStoresByName(string name=null)
        {
       
            return from store in stores
                   where string.IsNullOrEmpty(name) || store.StoreName.StartsWith(name)
                   orderby store.StoreName
                   select store;
        }
        public String GetStoreNameByID(int id)
        {
            Store store = stores.SingleOrDefault(s => s.Id == id);
            return store.StoreName;
        }
    }
}

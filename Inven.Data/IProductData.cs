using Inven.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven.Data
{
    public interface IProductData
    {
        IEnumerable<Product> GetProductsByName(string name);
        List<Product> GetAllProductsByStoreId(int StoreId);
    }

    public class InMemoryProductData : IProductData
    {
        List<Product> products;
        public InMemoryProductData()
        {
            products = new List<Product>
           
            {
                new Product { StoreId =1, Id = 1, ProductName = "Supreme Chair", ProductPrice= "25.00", Quantity = 20 },
                new Product { StoreId =1, Id = 2, ProductName = "Almerah", ProductPrice= "2590.00", Quantity = 20 },
                new Product { StoreId =1, Id = 3, ProductName = "Table", ProductPrice= "2599.00", Quantity = 20 },
                new Product { StoreId =2, Id = 1, ProductName = "Biscuit", ProductPrice= "2599.00", Quantity = 20 },
                new Product { StoreId =2, Id = 1, ProductName = "paper", ProductPrice= "2599.00", Quantity = 20 },
                new Product { StoreId =3, Id = 1, ProductName = "Vegetables", ProductPrice= "2599.00", Quantity = 20 }
            };
        }
        

        public List<Product> GetAllProductsByStoreId(int StoreId)
            {
                return products.FindAll(s => s.StoreId == StoreId);
            }

            public IEnumerable<Product> GetProductsByName(string name)
            {
                return from product in products
                       where string.IsNullOrEmpty(name) || product.ProductName.StartsWith(name)
                       orderby product.ProductName
                       select product;
            }
         
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven.Core
{
    public class Product
    {
        public int StoreId { get; set; }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string StoreName { get; set; }
    }
}

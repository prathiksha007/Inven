using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven.Core
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Location { get; set; }
        public StoreType StoreType { get; set; }
    }
}

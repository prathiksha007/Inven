using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inven.Data;
using Inven.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Inven.Pages.Stores
{
    public class StoreListModel : PageModel

    {
        private readonly IConfiguration config;
        private readonly IStoreData storeData;

        public StoreListModel(IConfiguration config, IStoreData storeData)
        {
            this.config = config;
            this.storeData = storeData;
        }

        [BindProperty(SupportsGet =true)]
        public string SearchKey { get; set; }
        public string Message { get;  set; }
        public IEnumerable<Store> Stores { get; set; }

        public void OnGet()
        {
            Message = "Hello There";
            Stores = storeData.GetStoresByName(SearchKey);
        }
    }
}

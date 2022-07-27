using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inven.Core;
using Inven.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inven.Pages.Stores
{
    public class StoreDetailsModel : PageModel
    {
        private readonly IStoreData storeData;
        public StoreDetailsModel(IStoreData storeData)
        {
            this.storeData = storeData;
        }
        public Store Store { get; set; }
        public IActionResult OnGet(int storeId)
        {
            Store = storeData.GetById(storeId);
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (storeId == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}

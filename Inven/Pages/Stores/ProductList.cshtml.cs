using System;
using System.Collections.Generic;
using System.Linq;
using Inven.Core;
using Inven.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Inven.Pages.Stores
{
    public class ProductListModel : PageModel
    {
     
        private readonly IProductData productData;
  
        public ProductListModel(IProductData productData)
        {
            this.productData = productData;
        }

    
        public IEnumerable<Product> Products { get; set; }
     
        public Product Product { get; set; }
        public IActionResult OnGet(int StoreId)
        {
             Products = productData.GetAllProductsByStoreId(StoreId);
            if (Products == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

     
    }
}

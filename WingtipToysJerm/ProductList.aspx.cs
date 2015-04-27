using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToysJerm.Models;
using System.Web.ModelBinding;

namespace WingtipToysJerm
{
    public partial class ProductList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryID)
        {
            var db = new WingtipToysJerm.Models.ProductContext();
            IQueryable<Product> query = db.Products;
            if (categoryID.HasValue && categoryID > 0)
	        {
		    query = query.Where(p => p.CategoryID == categoryID);
	        }
            return query;
        }
    }
}
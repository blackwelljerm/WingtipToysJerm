﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToysJerm.Models;
using System.Web.ModelBinding;

namespace WingtipToysJerm
{
    public partial class ProductDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId) 
        { 
            var db = new WingtipToysJerm.Models.ProductContext(); 
            IQueryable<Product> query = db.Products; 
            if (productId.HasValue && productId > 0) 
            { 
                query = query.Where(p => p.ProductID == productId); 
            } 
            else 
            {
                query = null; 
            } 
            return query; 
        }
    }
}
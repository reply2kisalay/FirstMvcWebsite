using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMbcWebsite.Models;

namespace FirstMbcWebsite.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.SomeMessage = "This is a message from controller";
            List<Product> products = new List<Product>();
            products.Add(new Product() {ProductId=1,ProductName="Logitech"});
            products.Add(new Product() { ProductId = 2, ProductName = "Apple" });
            return View(products);
        }
    }
}
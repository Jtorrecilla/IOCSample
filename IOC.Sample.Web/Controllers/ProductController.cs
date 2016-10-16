using IOC.Sample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOC.Sample.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }

        // GET: Product

        public ActionResult Index()
        {
            return View(productService.GetProducts());
        }
    }
}
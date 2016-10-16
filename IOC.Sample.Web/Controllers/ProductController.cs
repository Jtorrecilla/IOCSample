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
        private readonly IProductService productService;
        public ProductController(IProductService service)
        {
            productService = service;
        }

        // GET: Product

        public ActionResult Index()
        {
            return View(productService.GetProducts());
        }
    }
}
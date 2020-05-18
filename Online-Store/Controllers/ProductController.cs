using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;


namespace Online_Store.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.FindAll();
            return View();
        }
    }
}

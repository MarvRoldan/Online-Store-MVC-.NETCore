using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Controllers;

namespace Online_Store.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Index";
        }
        public string Browse(string category)
        {
            string message = "Showing category" + category;
            return message;
        }
        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "Item" + id };
            return View();
        }
    }
}
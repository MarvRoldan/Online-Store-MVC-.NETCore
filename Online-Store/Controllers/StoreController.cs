using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

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
        public string Details(int id)
        {
            string message = "Showing details" + id;
            return message;
        }
    }
}
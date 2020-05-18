using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Online_Store.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Index";
        }
        public string Browse()
        {
            return "Browse";
        }
        public string Details()
        {
            return "Details";
        }
    }
}
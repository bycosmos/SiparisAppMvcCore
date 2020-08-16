using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SiparisApp.Web.Controllers
{
    public class HesapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        // http://adres/product/index   ----- çalışma şekli
        public IActionResult Index()
        {
            return View();
        }
        public string Index2(int id)
        {
            return id.ToString();
        }
        
    }
}

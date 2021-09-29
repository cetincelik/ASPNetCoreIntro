using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class SessionDemoController:Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer{ Id = 1, FirstName = "Cetin" };

            HttpContext.Session.SetString("isim","Cetin");
            HttpContext.Session.SetObject("musteri", customer);
                return "Session oluştu";
        }
        public string Index2() 
        {
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.FirstName;
        }
    }
}

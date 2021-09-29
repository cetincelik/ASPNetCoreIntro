using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro.Services.Logging;

namespace ASPNetCoreIntro.Controllers
{
    //adres alanına adresi göstermesi için burda 
    //adres/deneme yazarız nereye gitmesini
    //istiyorsak devamını getirmeliyiz
    [Route("deneme")]

    public class CustomerController:Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }


        //Http GET
        //adres/deneme/index
        [Route("index")]
        //adres/deneme yetrli "" yapıldığında
        [Route("")]
        //adres/anasayfa   önünde ne yazdığı önemli değil 
        [Route("~/anasayfa")]
        public IActionResult Index3()
        {
           
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, FirstName = "Cetin", LastName = "Celik", City = "Eskişehir"},
                new Customer{Id=2, FirstName = "Cetin 2", LastName = "Celik", City = "Eskişehir"},
                new Customer{Id=3, FirstName = "Cetin 3", LastName = "Celik", City = "Eskişehir"}

            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }

        [HttpGet]
        [Route("save")]

        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel 
            { 
                 Cities = new List<SelectListItem>
                 {
                     new SelectListItem{Text = "Ankara",Value = "06"},
                     new SelectListItem{Text = "İstanbul",Value = "34"},
                     new SelectListItem{Text = "İzmir",Value = "35"}
                 }
            });
        }

        [HttpPost]
        [Route("save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}

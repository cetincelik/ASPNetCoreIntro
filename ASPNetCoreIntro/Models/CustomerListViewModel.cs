using ASPNetCoreIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<string> Shops { get; set; }
    }
}

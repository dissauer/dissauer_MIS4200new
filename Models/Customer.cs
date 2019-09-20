using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dissauer_MIS4800.Models
{
    public class Customer
    {
        //prop
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ICollection<CustomerOrder> Orders { get; set; }
    }
}
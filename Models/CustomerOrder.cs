using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dissauer_MIS4800.Models
{
    public class CustomerOrder
    {
        //prop
        public int orderID { get; set; }
        public int customerID { get; set; }
        public virtual Customer customer { get; set; }
        public DateTime orderDate { get; set; }
    }
}
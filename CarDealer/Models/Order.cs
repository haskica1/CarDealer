using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public enum TypeOfDelivery
    {
        STORE, 
        DELIVERY
    }

    class Order
    {
        private Bill Bill { get; set; }
        private TypeOfDelivery Type { get; set; }

        public Order(Bill bill, TypeOfDelivery type)
        {
            Bill = bill;
            Type = type;
        }
    }
}

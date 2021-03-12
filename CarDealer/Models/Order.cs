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
        public int Id { get; set; }
        public Bill Bill { get; set; }
        public TypeOfDelivery Type { get; set; }

        public Order(int id, Bill bill, TypeOfDelivery type)
        {
            Id = id;
            Bill = bill;
            Type = type;
        }
    }
}

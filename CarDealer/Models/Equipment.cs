using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Equipment
    {

        private string Name { get; set; }
        private string Info { get; set; }

        public Equipment(string name, string info)
        {
            Name = name;
            Info = info;
        }

    }
}

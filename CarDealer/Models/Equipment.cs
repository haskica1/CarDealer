using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }

        public Equipment(int id, string name, string info)
        {
            Id = id;
            Name = name;
            Info = info;
        }


        public string FullEquipmentName
        {
            get
            {
                return $"{Name} ({Info}) ";
            }
        }

    }


}

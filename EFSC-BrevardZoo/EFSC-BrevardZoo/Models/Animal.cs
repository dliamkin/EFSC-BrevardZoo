using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSCBrevardZoo.Models;

namespace EFSCBrevardZoo.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public AnimalGroup AnimalGroup { get; set; }
        public ParkArea ParkArea { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSCBrevardZoo.Models
{
    public class EmployeeTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Completed { get; set; }
        public Animal Animal { get; set; }
        public ParkArea TaskParkArea { get; set; }
        public Employee Employee { get; set; }
    }
}

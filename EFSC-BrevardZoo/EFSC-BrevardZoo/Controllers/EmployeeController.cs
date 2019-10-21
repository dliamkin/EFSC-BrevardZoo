using EFSCBrevardZoo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSCBrevardZoo.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("api/getEmployee")]
        public ActionResult<Employee> Get()
        {
            Employee employee = new Employee();

            employee.ID = 1;
            employee.Name = "Jason";
            employee.Role = "Supervisor";

            return employee;
        }

        [Route("api/getEmployeeTask")]
        public ActionResult<EmployeeTask> GetTask()
        {
            EmployeeTask employeeTask = new EmployeeTask();
            Animal animal = new Animal();
            AnimalGroup animalGroup = new AnimalGroup();
            ParkArea parkArea = new ParkArea();
            Employee employee = new Employee();

            employee.ID = 1;
            employee.Name = "Kyle";
            employee.Role = "Caretaker";

            parkArea.ID = 1;
            parkArea.Name = "Reptiles";
            parkArea.CurrentCapacity = 6;

            animalGroup.ID = 1;
            animalGroup.Name = "Alligator";

            animal.ID = 1;
            animal.Name = "Jerry The Alligator";
            animal.AnimalGroup = animalGroup;
            animal.ParkArea = parkArea;

            employeeTask.ID = 1;
            employeeTask.Name = "Clean Alligator Cage";
            employeeTask.Description = "Build up of small plastic cups from visitors in the upper lefthand corner of the cage. Must be thoroughly cleaned out and sprayed down.";
            employeeTask.CreatedOn = DateTime.Now;
            employeeTask.UpdatedOn = DateTime.Now;
            employeeTask.Completed = 0;
            employeeTask.Animal = animal;
            employeeTask.TaskParkArea = parkArea;
            employeeTask.Employee = employee;

            return employeeTask;
        }
    }
}

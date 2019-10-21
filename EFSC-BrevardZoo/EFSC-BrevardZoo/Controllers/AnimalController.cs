using EFSCBrevardZoo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSCBrevardZoo.Controllers
{

    public class AnimalController : ControllerBase
    {
        [Route("api/getAnimal")]
        public ActionResult<Animal> Get()
        {
            Animal animal = new Animal();
            AnimalGroup animalGroup = new AnimalGroup();
            ParkArea parkArea = new ParkArea();

            parkArea.ID = 1;
            parkArea.Name = "Reptiles";
            parkArea.CurrentCapacity = 6;

            animalGroup.ID = 1;
            animalGroup.Name = "Alligator";

            animal.ID = 1;
            animal.Name = "Jerry The Alligator";
            animal.AnimalGroup = animalGroup;
            animal.ParkArea = parkArea;

            return animal;
        }
    }
}

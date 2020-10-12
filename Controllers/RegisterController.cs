using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vehicleTracker.Models;

namespace vehicleTracker.Controllers
{
    [Route("Register")]
    public class RegisterController : Controller
    {
        private VehicleContext dbContext;
        public RegisterController(VehicleContext context)
        {
            dbContext = context;
        }

        [HttpGet("RegisterNew")]
        public IActionResult RegisterNew()
        {
            ViewBag.Owners = dbContext.Owners.ToList();
            return View("RegisterNew");
        }

        public IActionResult CreateVehicle(Vehicle model)
        {
            Vehicle newVehicle = model;

            Random rand = new Random();
            int len = 10;
            string registrationNumber = "";
            for (int i = 0; i < len; i++)
            {
                registrationNumber += ((char) (rand.Next(1, 26) + 64)).ToString();
            }
            newVehicle.Registration_number = registrationNumber;

            if (ModelState.IsValid)
            {
                dbContext.Vehicles.Add(newVehicle);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
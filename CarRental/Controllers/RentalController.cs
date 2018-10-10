using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.Controllers
{
    public class RentalController : Controller
    {
        //Fejkad data, dvs ersätter en DB för vår Happy Path
        private List<Car> cars;
        private List<Customer> customers;

        //Constructor, dvs kod som automatiskt körs vid new()
        public RentalController()
        {
            cars = new List<Car>();
            cars.Add(new Car() { Registration = "ABC123", Make="Nissan" });
            cars.Add(new Car() { Registration = "JHY651" , Make="Tesla"});

            customers = new List<Customer>();
            customers.Add(new Customer() { Name = "Kalle Anka" });
        }
        // GET: Rental
        public ActionResult Index()
        {
            return View(cars);
        }

        public PartialViewResult Cars()
        {
            return PartialView("_Cars", cars);
        }

        public ViewResult Details(string Registration)
        {

            return View("CarDetails", cars.First(x => x.Registration == Registration));
        }

        public PartialViewResult Customers()
        {
            return PartialView("_Customers", customers);
        }
    }
}
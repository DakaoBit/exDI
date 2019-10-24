using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo3.Application.Services;

 

namespace MvcDemoV3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService customerService;

        public HomeController()
        {
            this.customerService = new CustomerService();
        }

        public HomeController(ICustomerService service)
        {
            this.customerService = service;
        }

        public ActionResult Index()
        {
            var customers = customerService.GetCustomerList(cust => cust.Country == "UK");

            return View(customers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
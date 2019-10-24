using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DataAccess;
using Application.Services;

namespace MvcDemoV2.Controllers
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Home")
            {
                var repository = new CustomerRepository();
                var service = new CustomerService(repository);
                var controller = new HomeController(service);

                return controller;
            }
            else
                return null;
        }
    }
}
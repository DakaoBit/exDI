using MvcDemo3.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcDemoV3.Controllers
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName == "Home")
            {
                var service = new CustomerService();
                var controller = new HomeController(service);
                return controller;
            }
            else
            {
                return null;
            }
        }
    }
}
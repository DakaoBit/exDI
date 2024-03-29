﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DataAccess;
using Application.Services;

namespace MvcDemoV2.Controllers
{
    /// <summary>
    /// 建立組合工廠，由工廠來提供組合物件
    /// </summary>
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
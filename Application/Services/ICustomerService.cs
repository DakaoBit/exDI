
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace Application.Services
{
    public interface ICustomerService
    {
        Customers GetCustomerById(string id);
        List<Customers> GetCustomerList(Func<Customers, bool> filter);
    }
}
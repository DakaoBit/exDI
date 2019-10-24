using MvcDemo3.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo3.Application.Services
{
    public interface ICustomerService
    {
        Customers GetCustomerById(string id);
        List<Customers> GetCustomerList(Func<Customers, bool> filter);
    }
}

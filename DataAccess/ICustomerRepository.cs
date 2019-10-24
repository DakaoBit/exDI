using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public interface ICustomerRepository
    {
        Customers GetCustomerById(string id);
        IEnumerable<Customers> GetCustomerList(Func<Customers, bool> filter);
    }
}

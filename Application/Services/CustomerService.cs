using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DataAccess;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;

        public CustomerService(ICustomerRepository repo)
        {
            this.repository = repo;
        }

        public Customers GetCustomerById(string id)
        {
          return this.repository.GetCustomerById(id);
        }

        public List<Customers> GetCustomerList(Func<Customers, bool> filter)
        {
            return this.repository.GetCustomerList(filter).ToList();
        }
    }
}

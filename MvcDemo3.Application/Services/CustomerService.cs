using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcDemo3.Domain;
using System.Data.Entity;
using System.Web;

namespace MvcDemo3.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly NORTHWNDEntities db;

        public CustomerService()
        {
            db = new NORTHWNDEntities();
        }

        public CustomerService(NORTHWNDEntities dbContext)
        {
            // 呼叫端有注入 DbContext 物件，就用對方提供的。
            this.db = dbContext;
        }

        public Customers GetCustomerById(string id)
        {
            return db.Customers.Find(id);
        }

        public List<Customers> GetCustomerList(Func<Customers, bool> filter)
        {
            return db.Customers.Where(filter).ToList();
        }
    }
 
}

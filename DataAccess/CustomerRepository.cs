using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private DBEntities db = new DBEntities();

        public Customers GetCustomerById(string id)
        {
            var query = from t in db.Customers
                        where t.CustomerID == id
                        select t;

            return query.FirstOrDefault();
        }

        public IEnumerable<Customers> GetCustomerList(Func<Customers, bool> filter)
        {
            var query = from t in db.Customers
                        select t;

            return query.Where(filter);
        }
    }
}

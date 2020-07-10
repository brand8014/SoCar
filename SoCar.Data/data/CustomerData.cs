using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class CustomerData : EntityData<Customer>
    {
        public Customer Get(int customerId)
        {
            SocarEntities context = CreateContext();
            return context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public List<Customer> Search(int? customerId, int? age, string cellNumber, int? lisence)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Customers
                        select new
                        {
                            Customer = x,
                            Lisence = x.Code.Item,
                            RentCount = x.Rents.Count
                        };

            if (customerId.HasValue)
                query = query.Where(x => x.Customer.CustomerId == customerId);

            if (age.HasValue)
                query = query.Where(x => x.Customer.Age == age);

            if (string.IsNullOrEmpty(cellNumber) == false)
                query = query.Where(x => x.Customer.CellNumber.Contains(cellNumber));

            if (lisence.HasValue)
                query = query.Where(x => x.Customer.LisenceCode == lisence);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Customer.Lisence = x.Lisence;
                x.Customer.RentCount = x.RentCount;
            }

            return items.ConvertAll(x=> x.Customer);

        }

       

    }
}

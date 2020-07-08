using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class RentData : EntityData<Rent>
    {
        public Rent Get(int rentId)
        {
            SocarEntities context = CreateContext();
            return context.Rents.FirstOrDefault(x => x.RentId == rentId);
        }

        public List<Rent> Search(int? customerId, int? locationId, int? carId, DateTime? rentDay, DateTime? returnDay)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Rents
                        select new { Rent = x, CustomerName = x.Customer.Name, CarName = x.Car.CarType.Name, EventCount = x.Events.Count };


            if (customerId.HasValue)
                query = query.Where(x => x.Rent.CustomerId == customerId);

            if (locationId.HasValue)
                query = query.Where(x => x.Rent.LocationId == locationId);

            if (carId.HasValue)
                query = query.Where(x => x.Rent.CarId == carId);

            if (rentDay.HasValue)
            {
                var boundaryValue = rentDay.Value.AddDays(1);
                query = query.Where(x => x.Rent.BookAt >= rentDay.Value && x.Rent.BookAt <= boundaryValue);
            }


            if (returnDay.HasValue)
            {
                var boundaryValue = returnDay.Value.AddDays(1);
                query = query.Where(x => x.Rent.ReturnAt >= returnDay.Value && x.Rent.ReturnAt <= boundaryValue);
            }

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Rent.CustomerName = x.CustomerName;
                x.Rent.CarName = x.CarName;
                x.Rent.EventCount = x.EventCount;
            }

            return query.ToList().ConvertAll(x => x.Rent);

            

        }
    }
}

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
                        select x;


            if (customerId.HasValue)
                query = query.Where(x => x.CustomerId == customerId);

            if (locationId.HasValue)
                query = query.Where(x => x.LocationId == locationId);

            if (carId.HasValue)
                query = query.Where(x => x.CarId == carId);

            if (rentDay.HasValue)
            {
                var boundaryValue = rentDay.Value.AddDays(1);
                query = query.Where(x => x.BookAt >= rentDay.Value && x.BookAt <= boundaryValue);
            }


            if (returnDay.HasValue)
            {
                var boundaryValue = returnDay.Value.AddDays(1);
                query = query.Where(x => x.ReturnAt >= returnDay.Value && x.ReturnAt <= boundaryValue);
            }

            return query.ToList();

        }
    }
}

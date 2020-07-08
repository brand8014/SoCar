
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class CarData : EntityData<Car>
    {
        public Car Get(int carId)
        {
            SocarEntities context = CreateContext();
            return context.Cars.FirstOrDefault(x => x.CarId == carId);
           
        }
        public List<Car> Search(int? carTypeId, string number, int? location, bool? isRent)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Cars
                        select new { Car = x, CarName = x.CarType.Name, Address = x.Location.Address };

            if (carTypeId.HasValue)
                query = query.Where(x => x.Car.CarTypeId == carTypeId);

            if (string.IsNullOrEmpty(number) == false)
                query = query.Where(x => x.Car.Number == number);

            if (location.HasValue)
                query = query.Where(x => x.Car.LocationId == location);

            if (isRent == true || isRent == false)
                query = query.Where(x => x.Car.IsRent == isRent);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Car.CarName = x.CarName;
                x.Car.Address = x.Address;
            }

            return query.ToList().ConvertAll(x => x.Car);

        }

        public List<Car> SearchWithCarName(int? carTypeId, string number, int? location, bool? isRent)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Cars
                        select new { Car = x, CarName = x.CarType.Name, Address = x.Location.Address };

            if (carTypeId.HasValue)
                query = query.Where(x => x.Car.CarTypeId == carTypeId.Value);

            if (string.IsNullOrEmpty(number) == false)
                query = query.Where(x => x.Car.Number.Contains(number));

            if (location.HasValue)
                query = query.Where(x => x.Car.LocationId == location);

            if (isRent == true || isRent == false)
                query = query.Where(x => x.Car.IsRent == isRent);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Car.CarName = x.CarName;
                x.Car.Address = x.Address;
            }

            return query.ToList().ConvertAll(x => x.Car);

        }

        public List<Car> SearchWithCarNameAndAddress(int? locationId)
        {
            SocarEntities context = CreateContext();

            Dictionary<int, string> dict = context.Codes.Where(x => x.CodeCategoryId == 1).ToDictionary(x => x.CodeId, x => x.Item);

            var query = from x in context.Cars
                        select new { Car = x, CarName = x.CarType.Name, Address = x.Location.Address };

            if (locationId.HasValue)
                query = query.Where(x => x.Car.LocationId == locationId);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Car.CarName = x.CarName;
                x.Car.Address = x.Address;
            }

            return query.ToList().ConvertAll(x => x.Car);
        }
    }
}

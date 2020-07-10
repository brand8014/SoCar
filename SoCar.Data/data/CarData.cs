
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public List<Car> Search(int? carId, int? carTypeId, int? location, bool? isRent)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Cars
                        select new { Car = x, CarName = x.CarType.Name, Address = x.Location.Address, DefectCount = x.Defects.Count };

            if (carId.HasValue)
                query = query.Where(x => x.Car.CarId == carId);

            if (carTypeId.HasValue)
                query = query.Where(x => x.Car.CarTypeId==carTypeId);

            if (location.HasValue)
                query = query.Where(x => x.Car.LocationId == location);
            
            if (isRent.HasValue)
                query = query.Where(x => x.Car.IsRent == isRent);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Car.CarName = x.CarName;
                x.Car.Address = x.Address;
                x.Car.DefectCount = x.DefectCount;
            }

            return items.ConvertAll(x => x.Car);

        }

        public List<Car> GetAllWithProperties()
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Cars
                        select new { Car = x, CarName = x.CarType.Name, Address = x.Location.Address, DefectCount = x.Defects.Count };

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Car.CarName = x.CarName;
                x.Car.Address = x.Address;
                x.Car.DefectCount = x.DefectCount;
            }

            return items.ConvertAll(x => x.Car);

        }


    }
}

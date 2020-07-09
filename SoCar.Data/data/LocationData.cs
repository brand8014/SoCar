using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class LocationData : EntityData<Location>
    {
        public Location Get(int locationId)
        {
            SocarEntities context = CreateContext();
            return context.Locations.FirstOrDefault(x => x.LocationId == locationId);
        }

        public int? GetFirstId()
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Locations
                        orderby x.LocationId
                        select x.LocationId;

            return query.FirstOrDefault();
        }

        public List<Location> GetByCodeCategory(int? codeId)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Locations      
                        select x;
            if (codeId.HasValue)
                query = query.Where(x => x.LocationCode == codeId);

            return query.ToList();
        }

        public List<Location> Search(int? codeId, int? locationId)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Locations
                        select new
                        {
                            Location = x,
                            LocationName = x.Code.Item,
                            LocationFullName = x.Code.Item + " " + x.Address,
                            CarName = x.Cars.Select(y => y.CarType.Name).FirstOrDefault(),
                            CarNumber = x.Cars.Select(y => y.Number).FirstOrDefault()
                        };

            if (codeId.HasValue)
                query = query.Where(x => x.Location.LocationCode == codeId);
            if (locationId.HasValue)
                query = query.Where(x => x.Location.LocationId == locationId);

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Location.LocationName = x.LocationName;
                x.Location.LocationFullName = x.LocationFullName;
                x.Location.CarName = x.CarName;
                x.Location.CarNumber = x.CarNumber;
            }

            return items.ConvertAll(x => x.Location);

        }

        public List<Location> GetLocationFullName()
        {
            var context = CreateContext();

            var query = from x in context.Locations
                        select new { Location = x, 
                            LocationName = x.Code.Item, 
                            LocationFullName = x.Code.Item +" " + x.Address 
                        };

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Location.LocationFullName = x.LocationFullName;
            }

            return query.ToList().ConvertAll(x=>x.Location);
        }

        public List<Location> GetAllWithProperties()
        {
            var context = CreateContext();

            var query = from x in context.Locations
                        select new
                        {
                            Location = x,
                            LocationName = x.Code.Item,
                            LocationFullName = x.Code.Item + " " + x.Address,
                            CarName = x.Cars.Select(y => y.CarType.Name).FirstOrDefault(),
                            CarNumber = x.Cars.Select(y => y.Number).FirstOrDefault()
                        };

            var items = query.ToList();

            foreach (var x in items)
            {
                x.Location.LocationName = x.LocationName;
                x.Location.LocationFullName = x.LocationFullName;
                x.Location.CarName = x.CarName;
                x.Location.CarNumber = x.CarNumber;
            }

            return items.ConvertAll(x => x.Location);
        }
    }
}

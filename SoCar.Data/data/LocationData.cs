using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        public List<Location> GetByCodeCategory(int codeId)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Locations
                        where x.LocationCode == codeId
                        select x;

            return query.ToList();
        }
        
        public Location Search(int? locationId)
        {
            SocarEntities context = CreateContext();

            return context.Locations.FirstOrDefault(x => x.LocationId == locationId);

        }

    }
}

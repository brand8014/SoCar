using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class EventData : EntityData<Event>
    {
        public Event Get(int eventId)
        {
            SocarEntities context = CreateContext();
            return context.Events.FirstOrDefault(x => x.EventId == eventId);
        }

        public List<Event> getByCodeId(int eventTypeId)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Events
                        where x.EventTypeCode == eventTypeId
                        select x;
            return query.ToList();
        }

        public List<Event> Search(int? codeId, int? rentId, DateTime? period)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Events
                        select x;

            if (codeId.HasValue)
                query = query.Where(x => x.EventTypeCode == codeId);

            if (rentId.HasValue)
                query = query.Where(x => x.RentId == rentId);

            if (period.HasValue)
                query = query.Where(x => x.Period > period.Value);

            return query.ToList();
        }
    }
}

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

        public List<Event> Search(int? codeId, DateTime? period)
        {
            SocarEntities context = CreateContext();

            var query = from x in context.Events
                        select new { Event = x, EventName = x.Code.Item };

            if (codeId.HasValue)
                query = query.Where(x => x.Event.EventTypeCode == codeId);

            if (period.HasValue)
                query = query.Where(x => x.Event.Period > period.Value);

            var items = query.ToList();

            foreach (var x in items)
                x.Event.EventName = x.EventName;

            return items.ConvertAll(x=> x.Event);
        }
    }
}

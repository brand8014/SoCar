using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public partial class Event:EntityData<Event>
    {
        public string EventName { get; set; }
    }
}

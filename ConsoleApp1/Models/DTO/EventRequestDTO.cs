using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    internal class EventRequestDTO : EventBase
    {
    public Nullable<int> userId { get; set; }

        public EventRequestDTO() : base() { }
    public EventRequestDTO(Event E) : base(E.name, E.description, E.openBy, (System.DateTime)E.dueDate)
        {
            this.userId = E.user.id;
        }
        static public EventRequestDTO CreateRequestDTO(Event e)
        {
            var temp1= (EventBase)e;
            EventRequestDTO result = new EventRequestDTO();
            result.id = temp1.id;
            result.name = temp1.name;
            result.description = temp1.description;
            result.openBy = temp1.openBy;
            result.dueDate = temp1.dueDate;
            result.userId= e.user?.id;
            return result;
        }
    }
}

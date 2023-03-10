using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class EventBase:BaseModel<EventBase>
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime? openBy { get; set; }
        public DateTime? dueDate { get; set; }

        public EventBase()
        {

        }

        public EventBase(string name, string description, DateTime? openBy, DateTime dueDate) {
            this.name = name;
            this.description = description;
            this.openBy = openBy;
            this.dueDate = dueDate;
        }
    }
}

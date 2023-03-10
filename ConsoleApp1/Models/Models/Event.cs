using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class Event : EventBase
    {
        [Display(AutoGenerateField = false)]
        public User user { get; set; }
        public Event(string name, string description, DateTime? openBy, DateTime dueDate) : base(name, description, openBy, dueDate)
        {
        }
        public Event(int id,string name, string description, DateTime? openBy, DateTime dueDate, User user) : base(name, description, openBy, dueDate)
        {
            this.id= id;
            this.user = user;
        }
        public Event() : base()
        {
        }
    }
}

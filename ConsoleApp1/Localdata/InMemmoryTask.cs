using BusinessLogic.Localdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.Localdata
{
    internal class InMemmoryTask : IRepository<Event>
    {
        private Event ev;
        public void Delete()
        {
            this.ev = null;
        }

        public Event Get()
        {
            return this.ev;
        }

        public void Set(Event item)
        {
            this.ev = item;
        }
    }
}

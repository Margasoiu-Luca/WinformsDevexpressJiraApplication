using BusinessLogic.Localdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.Localdata
{
    internal class InMemmoryUser : IRepository<User>
    {
        private User user;
        public User Get()
        {
            return this.user;
        }

        public void Set(User user)
        {
            this.user = user;
        }

        public void Delete()
        {
            this.user = null;
        }
    }
}
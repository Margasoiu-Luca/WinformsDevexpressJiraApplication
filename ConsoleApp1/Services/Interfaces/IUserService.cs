using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal interface IUserService:IBaseService<BaseModel<User>>
    {
        Task<BaseModel<User>> Login(BaseModel<User> user);
    }
}

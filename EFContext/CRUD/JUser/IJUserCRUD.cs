using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFContext.Models;
namespace EFContext.CRUD
{
    public interface IJUserCRUD: IDBOperations<JUser, int>
    {
        Task<JUser> Login(JUser user);
    }
}

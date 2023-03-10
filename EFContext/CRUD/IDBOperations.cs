
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.CRUD
{


    public interface IDBOperations<T,ID>
    {
        Task<T> Create(T item);

        Task<T> GetOne(ID ItemId);

        Task<List<T>> GetAll();

        Task Update(ID itemId,T item);

        Task Delete(ID ItemId);
    }
}

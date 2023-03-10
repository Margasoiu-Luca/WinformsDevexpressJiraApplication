using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Localdata
{
    public interface IRepository<T>
    {
        T Get();
        void Set(T item);

        void Delete();
    }
}

using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal interface IBaseService<T> where T : class
    {
        Task<ObservableCollection<T>> GetAll();
        Task<T> GetOne();
        Task<bool> Delete(int id);
        Task<bool> Update(T item);
        Task<T> Create(T item);
    }
}

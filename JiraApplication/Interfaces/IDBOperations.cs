using JiraApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraApplication.Interfaces
{
    internal interface IDBOperations
    {
        Task<bool> Create(IModelForDB item);

        Task<IModelForDB> GetOne(int ItemId);

        Task<List<IModelForDB>> GetAll();

        Task<List<IModelForDB>> GetAllWithIds(string ItemIdsSeparatedByComma);

        Task<bool> Update(IModelForDB item);

        Task<bool> Delete(int ItemId);
    }
}

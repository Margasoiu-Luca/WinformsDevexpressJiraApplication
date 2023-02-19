using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JiraApplication.Models;
using JiraApplication.Interfaces;
using DevExpress.Xpo;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JiraApplication.Services
{

    public class JuserService: IDBOperations
    {
        private readonly DB_LMEntities1 dbContext = new DB_LMEntities1();
        public Task<bool> Create(IModelForDB item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int ItemId)
        {
            throw new NotImplementedException();
        }

        public Task<List<IModelForDB>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<IModelForDB>> GetAllWithIds(string ItemIdsSeparatedByComma)
        {
            throw new NotImplementedException();    
        }

        public async Task<IModelForDB> GetOne(int ItemId)
        {
            List<JUser> ItemsFoundForId = await (from user in dbContext.JUsers
                                   where user.id.Equals(ItemId)
                                   select user).ToListAsync();
            return ItemsFoundForId.Count!=0 ? ItemsFoundForId[0] : null;

        }

        public Task<bool> Update(IModelForDB item)
        {
            throw new NotImplementedException();
        }

        public async Task<JUser?> Login(string username, string password)
        {
            List<JUser> x = await (from user in dbContext.JUsers
                             where user.username.Equals(username) && user.password.Equals(password)
                             select user).ToListAsync();
            JUser UserFound = x[0];
            return UserFound;
        }
    }
}

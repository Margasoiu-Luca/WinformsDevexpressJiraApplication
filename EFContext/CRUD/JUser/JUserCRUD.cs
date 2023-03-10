using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFContext.Models;
namespace EFContext.CRUD
{
    public class JUserCRUD:IJUserCRUD
    {
        private static readonly Jira_DatabaseEntities1 dbContext = new Jira_DatabaseEntities1();

        public Task<JUser> Create(JUser item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ItemId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JUser>> GetAll()
        {
            List<JUser> ItemsFoundForId = await(from user in dbContext.JUsers select user).ToListAsync();
            return ItemsFoundForId;
        }

        public Task Update(int id, JUser item)
        {
            throw new NotImplementedException();
        }

        public async Task<JUser> GetOne(int ItemId)
        {
            throw new NotImplementedException();
        }
        public async Task<JUser> Login(JUser user)
        {
            JUser UserFound = await(from x in dbContext.JUsers
                                  where x.username.Equals(user.username) && x.password.Equals(user.password)
                                  select x).FirstOrDefaultAsync();
            return UserFound;
        }
    }
}

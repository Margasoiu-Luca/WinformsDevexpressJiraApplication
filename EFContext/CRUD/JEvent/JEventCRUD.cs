using EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFContext.Models;
using System.Runtime.Remoting.Contexts;
using System.Security.Claims;

namespace EFContext.CRUD
{
    public class JEventCRUD : IJeventCRUD
    {
        private readonly Jira_DatabaseEntities1 dbContext = new Jira_DatabaseEntities1();
        public async Task Create(JEvent item)
        {

            JProject project = await dbContext.JProjects.FirstOrDefaultAsync(s => s.name == "Project1");
            item.JProjects.Add(project);
            dbContext.JEvents.Add(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int ItemId)
        {
            JEvent eventToBeDeleted = await GetOne(ItemId);
            IEnumerable<JProject> projectsInvolvedWithEvent = await
                (from jproject in dbContext.JProjects
                 where jproject.JEvents.Any(ev => ev.id==ItemId)
                 select jproject
                ).ToListAsync();
            foreach(JProject project in projectsInvolvedWithEvent)
            {
                project.JEvents.Remove(eventToBeDeleted);
            }
            dbContext.JEvents.Remove(eventToBeDeleted);
            await dbContext.SaveChangesAsync();
        }

       public async Task<List<JEvent>> GetAll()
        {
            return await (from jevent in dbContext.JEvents select jevent).ToListAsync();
        }

        public Task<List<JEvent>> GetAllWithIds(string ItemIdsSeparatedByComma)
        {
            throw new NotImplementedException();
        }

        public async Task<JEvent> GetOne(int ItemId)
        {
            try
            {
                return await (from jevent in dbContext.JEvents
                              where jevent.id.Equals(ItemId)
                              select jevent).FirstAsync();
            }
            catch
            {
                return new JEvent();
            }
            }

        public async Task Update(int id,JEvent item)
        {
           JEvent itemInDB = await(from jevent in dbContext.JEvents
                         where jevent.id.Equals(id)
                         select jevent).FirstAsync();
            itemInDB = (JEvent)item.Clone();
            itemInDB.name += "a";
            await dbContext.SaveChangesAsync();

        }

    }

}

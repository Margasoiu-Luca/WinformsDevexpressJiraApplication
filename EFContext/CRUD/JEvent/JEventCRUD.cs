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
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace EFContext.CRUD
{
    public class JEventCRUD : IJeventCRUD
    {
        private readonly Jira_DatabaseEntities1 dbContext = new Jira_DatabaseEntities1();
        public async Task<JEvent> Create(JEvent item)
        {

            JProject project = await dbContext.JProjects.FirstOrDefaultAsync(s => s.name == "Project1");
            item.JProjects.Add(project);
            dbContext.JEvents.Add(item);
            await dbContext.SaveChangesAsync();
            var insertedEventWithUser = await (from jevent in dbContext.JEvents
                                       where jevent.id.Equals(item.id)
                                       select jevent).Include(j=>j.JUser).FirstAsync();
            return insertedEventWithUser;
        }
        public async Task Delete(int ItemId)
        {

            dbContext.Database.ExecuteSqlCommand("exec DeleteEvent @id", new SqlParameter("id", ItemId));
            //var eventToBeDeleted = await dbContext.JEvents.SingleAsync(a => a.id == ItemId);
            //IEnumerable<JProject> projectsInvolvedWithEvent = 
            //    await
            //    (from jproject in dbContext.JProjects
            //     where jproject.JEvents.Any(ev => ev.id == ItemId)
            //     select jproject
            //    ).ToListAsync();
            //foreach (JProject project in projectsInvolvedWithEvent)
            //{
            //    project.JEvents.Remove(eventToBeDeleted);
            //}
            //dbContext.JEvents.Remove(eventToBeDeleted);
            //dbContext.Entry(eventToBeDeleted).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

       public async Task<List<JEvent>> GetAll()
        {
            return await (from jevent in dbContext.JEvents select jevent).Include(j =>j.JUser).ToListAsync();
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
            itemInDB.name=item.name;
            itemInDB.description=item.description;
            itemInDB.openBy=item.openBy;
            itemInDB.dueDate=item.dueDate;
            dbContext.Entry(itemInDB).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();

        }

    }

}

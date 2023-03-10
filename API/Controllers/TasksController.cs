using EFContext.Models;
using EFContext.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.UI;
using System.Data.Entity.Validation;
using API.Infrastructure;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class TasksController : ApiController
    {
        // GET api/values
        private IJeventCRUD eventRepository;

        public TasksController()
        {
        }

        public TasksController(IJeventCRUD repository)
        {
            this.eventRepository = repository;
        }
        public async Task<IEnumerable<JEvent>> Get()
        {
            var x = await eventRepository.GetAll();
            return x;
        }


        // GET api/values/5
        public async Task<JEvent> Get(int id)
        {
            return await eventRepository.GetOne(id);
        }

        // POST api/values
        public async Task<HttpResponseMessage> Post([FromBody] JEvent jevent)
        {
            //jevent.userId = Convert.ToInt32(Request?.Headers?.GetValues("UserId").First());
            if (jevent == null) return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:Invalid JSON sent");
            try
            {
                var x =await eventRepository.Create(jevent);
                return Request.CreateResponse(HttpStatusCode.OK,x);
            }
            catch(DbEntityValidationException ex) 
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:{ViewAllErrors.GetaAllMessages(ex)}");
            }
                
        }

        // PUT api/values/5
        public async Task<HttpResponseMessage> Put(int id, [FromBody] JEvent jevent)
        {
            //jevent.userId = Convert.ToInt32(Request.Headers.GetValues("UserId").First());
            if (jevent == null) return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:Invalid JSON sent");
            try
            {
                await eventRepository.Update(id,jevent);
                return Request.CreateResponse(HttpStatusCode.OK, "status:worked");
            }
            catch (DbEntityValidationException ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:{ViewAllErrors.GetaAllMessages(ex)}");
            }
        }

        // DELETE api/values/5
        public async Task<HttpResponseMessage> Delete(int id)
        {   
            try
            {
                await eventRepository.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "status:worked");
            }
            catch (DbEntityValidationException ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:{ViewAllErrors.GetaAllMessages(ex)}");
            }


        }


    }
}

using EFContext.CRUD;
using EFContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using API.Infrastructure;
using System.Data.Entity.Validation;
using Ninject.Activation;

namespace API.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        private IJUserCRUD userRepository;

        public UsersController()
        {
        }

        public UsersController(IJUserCRUD repository)
        {
            this.userRepository = repository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        [Route("Login")]
        public async Task<HttpResponseMessage> Login([FromBody] JUser user)
        {
            try
            {

                user = await userRepository.Login(user);
                if(user == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound,"incorrect login");
                }
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (DbEntityValidationException ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, $"status:{ViewAllErrors.GetaAllMessages(ex)}");
            }
        }
    }
}
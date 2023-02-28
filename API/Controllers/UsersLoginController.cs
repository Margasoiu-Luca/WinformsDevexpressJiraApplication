using EFContext.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class UsersLoginController : ApiController
    {

        private IJUserCRUD   userRepository;

        public UsersLoginController()
        {
        }

        public UsersLoginController(IJUserCRUD repository)
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
        public async Task<HttpResponseMessage> Post([FromBody] string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK,"a");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
using System;
using System.Threading.Tasks;
using System.Net.Http;
using BusinessLogic.Models;
using Newtonsoft.Json;

namespace JiraApplication.Services
{
    internal class UserService : BaseService
    {
        internal UserService(string url) : base(url)
        {
        }

        public async Task<User> Login(string username, string password){
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync("/login", new StringContent(JsonConvert.SerializeObject(new User(username,password))));
                var responseAsString= await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    UserDTO deserializedString = JsonConvert.DeserializeObject<UserDTO>(responseAsString);
                    return new User(deserializedString.id, deserializedString.username, deserializedString.password);
                }
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

    }
}

// UserDTO myDeserializedClass = JsonConvert.DeserializeObject<UserDTO>(myJsonResponse);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using BusinessLogic.Models;
using System.Text.Json;
using BusinessLogic.Services;

namespace BusinessLogic.Services
{
    internal class UserService : BaseService
    {
        internal UserService(string url) : base(url)
        {
        }

        public async Task<User> Login(string username, string password)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync($"/{restOfUri}/login", new StringContent(JsonSerializer.Serialize(new User(username, password)),Encoding.UTF8,"application/json"));
                var responseAsString = await response?.Content?.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    UserDTO deserializedString = JsonSerializer.Deserialize<UserDTO>(responseAsString);
                    return new User(deserializedString.id, deserializedString.username, deserializedString.password);
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

// UserDTO myDeserializedClass = JsonConvert.DeserializeObject<UserDTO>(myJsonResponse);
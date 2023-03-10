using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using BusinessLogic.Models;
using System.Text.Json;
using BusinessLogic.Services;
using System.Collections.ObjectModel;

namespace BusinessLogic.Services
{
    internal class UserService : BaseService,IUserService
    {
        internal UserService(string url) : base(url)
        {
        }

        public Task<BaseModel<User>> Create(BaseModel<User> item)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseModel<User>> Login(BaseModel<User> user)
        {
            try
            {

                HttpResponseMessage response = await _httpClient.PostAsync($"{restOfUri}login", new StringContent(JsonSerializer.Serialize(new User(user.getDbElement().username, user.getDbElement().password)),Encoding.UTF8,"application/json"));
                var responseAsString = await response?.Content?.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    UserDTO deserializedString = JsonSerializer.Deserialize<UserDTO>(responseAsString);
                    return new User(deserializedString.id, deserializedString.username, deserializedString.password) as BaseModel<User>;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        Task<bool> IBaseService<BaseModel<User>>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<ObservableCollection<BaseModel<User>>> IBaseService<BaseModel<User>>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<BaseModel<User>> IBaseService<BaseModel<User>>.GetOne()
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseService<BaseModel<User>>.Update(BaseModel<User> item)
        {
            throw new NotImplementedException();
        }
    }
}

// UserDTO myDeserializedClass = JsonConvert.DeserializeObject<UserDTO>(myJsonResponse);
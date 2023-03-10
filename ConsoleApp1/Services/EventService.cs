using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using BusinessLogic.Services;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models.DTO;
using System.Collections.ObjectModel;

namespace BusinessLogic.Services
{
    internal class EventService : BaseService, IEventService
    {
        internal EventService(string url) : base(url)
        {
        }

        public async Task<Event> Create(Event item)
        {
            try
            {
                var EventDTORequest = new EventRequestDTO(item);
                var response = await _httpClient.PostAsync($"{restOfUri}", new StringContent(JsonSerializer.Serialize(EventDTORequest), Encoding.UTF8, "application/json"));
                var responseAsString = await response?.Content?.ReadAsStringAsync();
                //var desirializedString= Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessLogic.Models.DTO2.Root>(responseAsString);
                var deserializedString = System.Text.Json.JsonSerializer.Deserialize<BusinessLogic.Models.DTO2.Root>(responseAsString);
                return new Event(deserializedString.id,deserializedString.name,deserializedString.description,null,deserializedString.dueDate,new User(deserializedString.JUser.id,deserializedString.JUser.username,null));
            }
            catch
            {
                return null;
            }
        }

        async Task<bool> IBaseService<Event>.Delete(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{restOfUri}{id}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        async Task<ObservableCollection<Event>> IBaseService<Event>.GetAll()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{restOfUri}");
                var responseAsString = await response?.Content?.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    ObservableCollection<Event> result = new ObservableCollection<Event>();
                    IEnumerable<EventDTO> deserializedString = System.Text.Json.JsonSerializer.Deserialize<List<EventDTO>>(responseAsString,options);
                    foreach (EventDTO dto in deserializedString)
                    {
                        Event current = new Event(dto.id,dto.name, dto.description, dto.openBy, dto.dueDate, new User(dto.JUser.id, dto.JUser.username, null));
                        result.Add((Event)current); 
                    }
                    return result;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        async Task<Event> IBaseService<Event>.GetOne()
        {
            throw new NotImplementedException();
        }

        async Task<bool> IBaseService<Event>.Update(Event item)
        {
            try
            {
                var EventDTORequest = new EventRequestDTO(item);
                var response =await _httpClient.PutAsync($"{restOfUri}{item.id}", new StringContent(JsonSerializer.Serialize(EventDTORequest), Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else return false;

            }
            catch
            {
                return false;
            }
        }

        }
    }

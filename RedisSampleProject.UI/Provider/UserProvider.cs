using Newtonsoft.Json;
using RedisSampleProject.UI.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RedisSampleProject.UI.Provider
{
    public class UserProvider
    {
        HttpClient _client;

        public UserProvider(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<UserVMList>> GetAllUsers()
        {
            var value = await _client.GetAsync("Values/getusers");
            if (value.IsSuccessStatusCode)
            {
                var content = await value.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<UserVMList>>(content);
                return data;
            }
            return null;
        }

        public async Task<string> AddUser(UserVM vm)
        {
            var serialized = new StringContent(JsonConvert.SerializeObject(vm));
            serialized.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var post = await _client.PostAsync("Values/adduser",serialized);
            string result = ":(";
            if (post.IsSuccessStatusCode)
            {
                result = "Succesfully Added";
            }
            return result;
        }
    }
}

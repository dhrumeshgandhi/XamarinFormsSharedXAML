using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace XFSX_Test_1
{
    public class RestService : IRestService<User>
    {
        HttpClient httpClient;

        public RestService()
        {
            httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
        }
        public Task DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> RefreshDataAsync()
        {
            var uri = new Uri(String.Format(Constants.RESTUriBase, "/users"));
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(content);
            }
            else
            {
                return new List<User> { };
            }
        }

        public Task SaveItemAsync(User user, bool isNewItem)
        {
            throw new NotImplementedException();
        }
    }
}
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminCoreProject.ApiClient
{
    public class ApiRepo : IApiRepo
    {
        private IApiHelper _apiHelper;

        public ApiRepo(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public T GetById<T>(int id, string url, string token, Endpoints endpoints)
        {
            var RequestURL = $"{_apiHelper.GetBaseUrl(endpoints)}/{url}/{id}";

            var client = new RestClient(RequestURL);

            var req = new RestRequest(Method.GET);

            req.AddHeader("Authorization", "Bearer " + token);

            var result = client.Execute(req);

            return JsonConvert.DeserializeObject<T>(result.Content);

        }

        public T GetByName<T>(string name, string url, string token, Endpoints endpoints)
        {
            var RequestURL = $"{_apiHelper.GetBaseUrl(endpoints)}/{url}/{name}";

            var client = new RestClient(RequestURL);

            var req = new RestRequest(Method.GET);

            req.AddHeader("Authorization", "Bearer " + token);

            var result = client.Execute(req);

            return JsonConvert.DeserializeObject<T>(result.Content);
        }

        public List<T> GetList<T>(string url, string token, Endpoints endpoints)
        {
            var RequestURL = $"{_apiHelper.GetBaseUrl(endpoints)}/{url}";

            var client = new RestClient(RequestURL);

            var req = new RestRequest(Method.GET);

            req.AddHeader("Authorization", "Bearer " + token);

            var result = client.Execute(req);

            return JsonConvert.DeserializeObject<List<T>>(result.Content);
        }

        public T PostData<T>(T t, string url, string token, Endpoints endpoints)
        {
            var RequestURL = $"{_apiHelper.GetBaseUrl(endpoints)}/{url}";
            var client = new RestClient(RequestURL);

            var req = new RestRequest(Method.POST);

            if (token != string.Empty)
                req.AddHeader("Authorization", "Bearer " + token);

            req.AddHeader("content-type", "application/json");
            req.AddParameter("application/json", JsonConvert.SerializeObject(t), ParameterType.RequestBody);

            var result =  client.Execute(req);

            return JsonConvert.DeserializeObject<T>(result.Content);
        }
    }
}

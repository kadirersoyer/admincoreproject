using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.ApiClient
{
    public interface IApiHelper
    {
        string GetBaseUrl(Endpoints endpoints);
    }

    public enum Endpoints
    {
       Local = 0,
       Remote = 1
    }

    public class ApiHelper : IApiHelper
    {
        public string GetBaseUrl(Endpoints endpoints)
        {
            string BaseURL = string.Empty;

            switch (endpoints)
            {
                case Endpoints.Local:
                    BaseURL = "https://localhost:44329";
                    break;
                case Endpoints.Remote:
                    break;
                default:
                    break;
            }

            return BaseURL;
        }
    }

}

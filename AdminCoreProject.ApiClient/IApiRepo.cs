using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdminCoreProject.ApiClient
{
    public interface IApiRepo
    {
        T GetById<T>(int id, string url, string token, Endpoints endpoints);
        T GetByName<T>(string name, string url, string token, Endpoints endpoints);

        List<T> GetList<T>(string url, string token,Endpoints endpoints);
        T PostData<T>(T t,string url, string token, Endpoints endpoints);

    }
}

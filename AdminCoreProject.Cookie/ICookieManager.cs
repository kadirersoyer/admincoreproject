using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Cookie
{
    public interface ICookieManager
    {
        void Set(string key,string value,int? expireTime);
        string Get(string key);
        void Remove(string key);
        bool IFExists(string key);
    }
}

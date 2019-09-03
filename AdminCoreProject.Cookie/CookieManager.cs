using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Cookie
{
    public class CookieManager : ICookieManager
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CookieManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string Get(string key)
        {
            return _httpContextAccessor
                .HttpContext.Request.Cookies[key];
        }

        public bool IFExists(string key)
        {
            var status = _httpContextAccessor.HttpContext.Request.Cookies[key];

            if (status != null)
                return true;
            else
                return false;
        }

        public void Remove(string key)
        {
            _httpContextAccessor.
                HttpContext.Response.Cookies.Delete(key);
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions options = new CookieOptions();

            if (expireTime.HasValue)
                options.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                options.Expires = DateTime.Now.AddMilliseconds(10);

            _httpContextAccessor.
                HttpContext.Response.Cookies.Append(key, value);
        }
    }
}

using AdminCoreProject.Cookie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Filters
{
    public class CookieFilter : IActionFilter
    {
        private ICookieManager _cookieManager;

        public CookieFilter(ICookieManager cookieManager)
        {
            _cookieManager = cookieManager;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var Control = _cookieManager.IFExists("token");
            if (!Control)
                context.Result = new RedirectToActionResult("login", "home",null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminCoreProject.Models;
using AdminCoreProject.ApiClient;
using AdminCoreProject.Entities;
using AdminCoreProject.Entities.ViewModels;
using AdminCoreProject.Cookie;
using AdminCoreProject.Filters;

namespace AdminCoreProject.Controllers
{
    public class HomeController : Controller
    {
        private ICookieManager _cookieManager;
        private IApiRepo _apiRepo;

        public HomeController(IApiRepo apiRepo,
                              ICookieManager cookieManager)
        {
            _cookieManager = cookieManager;
            _apiRepo = apiRepo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new CustomerViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(CustomerViewModel customerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var Status = _apiRepo.PostData<CustomerViewModel>(customerViewModel,
                            "api/token/login-control", "", Endpoints.Local);
                if (Status != null)
                {
                    _cookieManager.Set("username", Status.Name, null);
                    _cookieManager.Set("token", Status.Token, 30);
                    return RedirectToAction("index");
                }
                else
                    ViewBag.Error = "Kullanıcı Bilgilerini Kontrol Ediniz";
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message.ToString();
            }
            return View();
        }

        [HttpGet, ActionName("index")]

        [TypeFilter(typeof(CookieFilter))]
        public IActionResult index()
        {
            var loginInfo = _cookieManager.Get("username");
            return View();
        }

    }
}

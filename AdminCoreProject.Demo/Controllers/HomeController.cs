using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdminCoreProject.Demo.Models;
using AdminCoreProject.Demo.Unit;
using AdminCoreProject.Demo.Domains;
using AdminCoreProject.Demo.Service;
using System;
using AutoMapper;

namespace AdminCoreProject.Demo.Controllers
{
    public class HomeController : Controller
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        private ICategoryService _customerService;

        public HomeController(ICategoryService customerService,
                              IUnitOfWork unitOfWork,
                              IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _customerService = customerService;
        }

        [HttpGet, ActionName("index")]
        public IActionResult Index()
        {
            _unitOfWork.GetRepository<Category>().Add(new Category());
            _unitOfWork.SaveChanges();

            var userModel = new UserModel();
            userModel.UserRegistrations = new List<UserModel.UserRegistration>()
            {
                new UserModel.UserRegistration(){ id = 1, name = "Deneme 1 ", registirationtype = "Denem 1"},
                new UserModel.UserRegistration(){ id = 1, name = "Deneme 2 ", registirationtype = "Denem 2"}
            };

            return View(userModel);
        }

        [HttpPost, ActionName("index")]
        public IActionResult Index(UserModel userModel)
        {
            userModel.UserRegistrations = new List<UserModel.UserRegistration>()
            {
                new UserModel.UserRegistration(){ id = 1, name = "Deneme 1 ", registirationtype = "Denem 1"},
                new UserModel.UserRegistration(){ id = 1, name = "Deneme 2 ", registirationtype = "Denem 2"}
            };
            var data =_mapper.Map<User>(userModel);

            return View(userModel);
        }  
    }
}

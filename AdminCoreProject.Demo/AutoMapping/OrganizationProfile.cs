using AdminCoreProject.Demo.Domains;
using AdminCoreProject.Demo.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.AutoMapping
{
    public class OrganizationProfile: Profile
    {
        public OrganizationProfile()
        {
            CreateMap<CategoryModel, Category>();
            CreateMap<UserModel, User>();
        }
    }
}

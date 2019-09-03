using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminCoreProject.Demo.Context;
using AdminCoreProject.Demo.Domains;
using AdminCoreProject.Demo.Repo;
using AdminCoreProject.Demo.Unit;
using Microsoft.EntityFrameworkCore;

namespace AdminCoreProject.Demo.Service
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Category> GetCategoryWithProduct()
        {
            return _unitOfWork.GetRepository<Category>().GetList().
                Include(a => a.productCategories).ToList();
        }
    }
}

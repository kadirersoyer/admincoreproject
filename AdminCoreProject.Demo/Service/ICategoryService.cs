using AdminCoreProject.Demo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Service
{
    public interface ICategoryService
    {
        List<Category> GetCategoryWithProduct();
    }
}

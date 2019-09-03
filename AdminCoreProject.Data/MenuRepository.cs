using AdminCoreProject.DataContext;
using AdminCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Data
{
    public class MenuRepository: Repository<Menu>, IMenuRepository
    {
        public MenuRepository(AdminCoreDBContext context): base(context)
        {
        }

    }
}

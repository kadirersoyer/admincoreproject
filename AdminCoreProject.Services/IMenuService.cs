using AdminCoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdminCoreProject.Services
{
    public interface IMenuService
    {
        bool Add(Menu menu);
        bool Update(Menu menu);
        bool Remove(Menu menu);

        string GetMenuTreeList();
        Menu GetById(int id);
        List<Menu> GetMenus(Expression<Func<Menu, bool>> expression);
        List<Menu> GetMenus();
    }
}

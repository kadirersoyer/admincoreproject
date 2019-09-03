using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using AdminCoreProject.Data;
using AdminCoreProject.Entities;

namespace AdminCoreProject.Services
{
    public class MenuService : IMenuService
    {
        private IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        public bool Add(Menu menu)
        {
            return menuRepository.Add(menu);
        }

        public Menu GetById(int id)
        {
            return menuRepository.GetById(id);
        }

        public List<Menu> GetMenus(Expression<Func<Menu, bool>> expression)
        {
            return menuRepository.GetList(expression);
        }

        public List<Menu> GetMenus()
        {
            return menuRepository.GetList();
        }

        public string GetMenuTreeList()
        {
            return string.Empty;
        }

        public bool Remove(Menu menu)
        {
            return menuRepository.Remove(menu);
        }

        public bool Update(Menu menu)
        {
            return menuRepository.Update(menu);
        }
    }
}

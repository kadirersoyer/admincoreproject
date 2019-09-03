using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminCoreProject.Entities;
using AdminCoreProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminCoreProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuController : ControllerBase
    {
        private IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("get-menu-list")]
        public IEnumerable<Menu> GetMenus()
        {
            var datas = _menuService.GetMenus();
            return datas;
        }

        [HttpPost]
        [Route("add-menu-item")]
        public IActionResult AddMenu([FromBody] Menu menu)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                result.Status = _menuService.Add(menu);
                result.Message = "Success";
            }
            catch (Exception ex)
            {
                result.Message = ex.Message.ToString();
                result.Status = false;
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("get-menu-item-byid/{id}")]
        public Menu GetMenuById(int id)
        {
            return _menuService.GetById(id);
        }

        [HttpPut]
        [Route("update-menu-item")]
        public IActionResult UpdateMenu([FromBody] Menu menu)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                result.Status = _menuService.Update(menu);
                result.Message = "Success";
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message.ToString();
            }

            return Ok(result);
        }

        [HttpDelete]
        [Route("delete-menu-item")]
        public IActionResult DeleteMenu([FromBody] Menu menu)
        {
            ResponseResult result = new ResponseResult();
            try
            {
                result.Status = _menuService.Remove(menu);
                result.Message = "Success";
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message.ToString();
            }

            return Ok(result);
        }
    }
}
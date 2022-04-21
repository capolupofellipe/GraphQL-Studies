using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ISubMenuService
    {
        List<SubMenu> GetAll();
        List<SubMenu> GetByMenu(int menuId);
        SubMenu Add(SubMenu subMenu);
    }
}
using System.Collections.Generic;
using System.Linq;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class SubMenuService : ISubMenuService
    {
        private readonly GraphQLDbContext _dbContext;

        public SubMenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public SubMenu Add(SubMenu subMenu)
        {
            _dbContext.SubMenus.Add(subMenu);
            _dbContext.SaveChanges();
            return subMenu;
        }

        public List<SubMenu> GetAll()
        {
            return _dbContext.SubMenus.ToList();
        }

        public List<SubMenu> GetByMenu(int menuId)
        {
            return _dbContext.SubMenus.Where(x => x.MenuId == menuId).ToList();
        }
    }
}

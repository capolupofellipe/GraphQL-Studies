using System.Collections.Generic;
using System.Linq;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class MenuService : IMenuService
    {
        private readonly GraphQLDbContext _dbContext;

        public MenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Menu Add(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetAll()
        {
            return _dbContext.Menus.ToList();
        }
    }
}

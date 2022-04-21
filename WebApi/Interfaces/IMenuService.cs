using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        Menu Add(Menu menu);
    }
}
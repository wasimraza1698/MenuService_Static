using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuService.Models;

namespace MenuService.Repositories
{
    public interface IRepository
    {
        public List<MenuItem> GetAll();
        public MenuItem Get(int id);
        public MenuItem Edit(MenuItem item);
    }
}

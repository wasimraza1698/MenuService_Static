using MenuService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuService.Repositories
{
    public class MenuItemRepo : IRepository
    {
        private static List<MenuItem> menu = new List<MenuItem>()
        {
            new MenuItem {MenuItemID = 1, Name = "Sandwich", Price = 99.00f, Active = "Yes", DateOfLaunch = new DateTime(2020, 12, 01), Category = "MainCourse",FreeDelivery = "Yes"},
            new MenuItem {MenuItemID = 2, Name = "Burger", Price = 129.00f, Active = "Yes", DateOfLaunch = new DateTime(2020, 12, 01), Category = "MainCourse",FreeDelivery = "No"},
            new MenuItem {MenuItemID = 3, Name = "Pizza", Price = 149.00f, Active = "Yes", DateOfLaunch = new DateTime(2020, 12, 01), Category = "MainCourse",FreeDelivery = "No"},
            new MenuItem {MenuItemID = 4, Name = "French Fries", Price = 57.00f, Active = "No", DateOfLaunch = new DateTime(2020, 12, 01), Category = "Starter",FreeDelivery = "Yes"},
            new MenuItem {MenuItemID = 5, Name = "Chocolate Brownie", Price = 32.00f, Active = "Yes", DateOfLaunch = new DateTime(2020, 12, 01), Category = "Dessert",FreeDelivery = "Yes"}
        };

        public List<MenuItem> GetAll()
        {
            return menu;
        }

        public MenuItem Get(int id)
        {
            return menu.Find(i => i.MenuItemID == id);
        }

        public MenuItem Edit(MenuItem item)
        {
            menu[item.MenuItemID - 1] = item;
            return item;
        }
    }
}

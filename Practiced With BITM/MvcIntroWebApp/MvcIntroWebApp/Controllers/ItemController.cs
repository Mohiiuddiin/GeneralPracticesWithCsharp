using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcIntroWebApp.Manager;
using MvcIntroWebApp.Models;

namespace MvcIntroWebApp.Controllers
{
    public class ItemController : Controller
    {
        public ItemManager ItemManager { get; private set; }
        public CategoryManager CategoryManager { get; private set; }
        public ItemController()
        {
            ItemManager = new ItemManager();
            CategoryManager = new CategoryManager();
        }
           
        [HttpGet]
        public ActionResult Save()
        {
            List<Category> categories = CategoryManager.GetAllCategories();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult Save(Item item)
        {
            string message =ItemManager.Save(item);
            ViewBag.Message = message;
            List<Category> categories = CategoryManager.GetAllCategories();
            ViewBag.Categories = categories;
            return View();
        }














        public ActionResult Index()
        {

            List<Item> itemList = GetAllItems();
            return View(itemList);

        }


        public List<Item> GetAllItems()
        {
            return new List<Item>()
            {
                new Item(){Id = 1, Name = "Pen", Price = 100},
                new Item(){Id = 2, Name = "Mouse", Price = 100},
                new Item(){Id = 3, Name = "Keyboard", Price = 200},
            };
        }


        public string Find(int id)
        {
            Item item = ItemManager.GetItemById(id);

            if (item != null)
            {
                return "Id :" + item.Id + " Name:" + item.Name + " Price:" + item.Price;
            }
            return "Item Not Found";
        }
        //public string Find()
        //{
        //    return "Your have found the item ";
        //}
    }
}
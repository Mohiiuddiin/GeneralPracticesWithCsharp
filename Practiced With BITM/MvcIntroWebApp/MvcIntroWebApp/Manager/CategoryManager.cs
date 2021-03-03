using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcIntroWebApp.Gateway;
using MvcIntroWebApp.Models;

namespace MvcIntroWebApp.Manager
{
    public class CategoryManager
    {
        private CategoryGateway categoryGateway;
        public CategoryManager()
        {
            categoryGateway = new CategoryGateway();
        }
        public List<Category> GetAllCategories()
        {
            return categoryGateway.GetAllCategories();
        }
    }
}
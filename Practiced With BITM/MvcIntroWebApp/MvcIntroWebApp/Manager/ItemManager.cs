using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcIntroWebApp.Gateway;
using MvcIntroWebApp.Models;

namespace MvcIntroWebApp.Manager
{
    public class ItemManager
    {
        public ItemGateway ItemGateway { get; private set; }
        public ItemManager()
        {
            ItemGateway = new ItemGateway();
        }

        public string Save(Item item)
        {
            if (ItemGateway.Save(item)> 0)
            {
                return "Save Successful";
            }
            else
            {
                return "Save Failed";
            }
        }

        public Item GetItemById(int id)
        {
            return ItemGateway.GetItemById(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantApp.Models;

namespace WebAppRestaurantApp.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public ItemRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        //retrun select List Item

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objRestaurantDBEntities.Items
                                  select new SelectListItem
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = true


                                  }).ToList();

            return objselectListItems;
        }
    }
}
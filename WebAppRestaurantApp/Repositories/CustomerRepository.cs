using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantApp.Models;

namespace WebAppRestaurantApp.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public CustomerRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        //retrun select List Item

        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objRestaurantDBEntities.Customers
                                  select new SelectListItem
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true



                                  }).ToList();

            return objselectListItems;
        }

    }
}
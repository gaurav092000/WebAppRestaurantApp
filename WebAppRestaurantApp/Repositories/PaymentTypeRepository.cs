using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantApp.Models;

namespace WebAppRestaurantApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public PaymentTypeRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        //retrun select List Item
         
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objRestaurantDBEntities.PaymentTypes
                                  select new SelectListItem
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value=obj.PaymentTypeId.ToString(),
                                      Selected=true
                                  
                                  
                                  }).ToList();

            return objselectListItems;
        }
    }
}
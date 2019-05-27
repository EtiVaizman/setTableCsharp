using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class CustomerLogic
    {
        public static DAL.SetTableEntities1 db = new DAL.SetTableEntities1();
        #region מחזירה את כל ההזמנות הקודמות לפי מזהה לקוח
        public static List<DTO.Product> GetAllPreviousOrders(int idCustomer)
        {
            List<DTO.Product> listProducts = new List<DTO.Product>();
            var Orders = db.Order.Where(s => s.idCustomer == idCustomer).ToList();
            foreach (var item in Orders)
            {
                foreach (var po in item.ProductOfOrder)
                {
                    listProducts.Add(DTO.Product.ConvertDBToDto(po.Product));
                }
            }
            return listProducts;
        }
        #endregion
    }
}

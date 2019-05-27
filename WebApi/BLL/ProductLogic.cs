using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductLogic
    {
        public static DAL.SetTableEntities1 db = new DAL.SetTableEntities1();
        #region  כל המוצרים
        public static List<DTO.Product> GetAllProduct()
        {
            List<DTO.Product> productsDto = new List<DTO.Product>();
            List<DAL.Product> products = db.Product.ToList();
            foreach (var item in products)
            {
                productsDto.Add(DTO.Product.ConvertDBToDto(item));
            }
            return productsDto;
        }
        #endregion
        #region קבלת מוצר ע"פ המזהה
        public static DTO.Product GetProductById(int productId)
        {
            DTO.Product product = DTO.Product.ConvertDBToDto(db.Product.Find(productId));
            if (product == null)
                return null;
            return product;
        }
        #endregion

        public static List< DTO.Product> GetProductByColor(string color)
        {
            List<DTO.Product> productsDto = new List<DTO.Product>();
            List<DAL.Product> products = db.Product.Where(x=>x.color==color).ToList();
            foreach (var item in products)
            {
                productsDto.Add(DTO.Product.ConvertDBToDto(item));
            }
            return productsDto;
        }
    }
}


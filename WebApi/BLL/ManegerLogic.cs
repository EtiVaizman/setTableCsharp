using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManegerLogic
    {
        public static DAL.SetTableEntities1 db = new DAL.SetTableEntities1();

        #region (הוספת מוצר (מנהל
        public static void AddProduct(DTO.Product p)
        {
            DAL.Product product = new DAL.Product();
            product.nameProduct = p.nameProduct;
            product.price = p.price;
            product.unitsInStock = p.unitsInStock;
            product.numCategory = p.numCategory;
            product.color = p.color;
            product.model = p.model;
            product.size = p.size;
            product.img = p.img;
            db.Product.Add(product);
            db.SaveChanges();
        }
        #endregion
    }
    #region מחיקת מוצר ע""פ מזהה מוצר
    public static void DeleteProduct(int idProduct)
    {
        DTO.Product p = db.Product.Find(idProduct);
        if (p == null)
        {
            db.Product.Remove(p);
            db.SaveChanges();
        }
    }
    #endregion
}

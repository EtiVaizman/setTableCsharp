using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Setable.Controllers
{
    [RoutePrefix("api/Maneger")]
   
    public class ManagmenController : ApiController
    {
        const string nameManagmen="setable";
        const string password="1513";

        [Route("validationManeger")]
        #region פונקציה שבודקת האם השם והסיסמא של המנהל תקינים
        public static bool CheckIntegrityManagmen(string name,string pass)
        {
            if (name == nameManagmen && pass == password)
                return true;
            return false;
        }
        #endregion

        [Route("AddProduct")]
        #region הוספת מוצר
        public static void AddProduct(DTO.Product p)
        {
            BLL.ManegerLogic.AddProduct(p);
        }
            #endregion
        }
}

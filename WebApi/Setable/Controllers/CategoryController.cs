using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Setable.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        [Route("getAllCategories")]
        public List<DTO.Category> GetAllCategories()
        {
            return BLL.CategoryLogic.GetAllCategories();
        }
        //קבלת קטגוריה לפי id
        [Route("getCategoryById")]
        public DTO.Category GetCategoryById(int categoryId)
        {
            return BLL.CategoryLogic.GetCategoryById(categoryId);
        }
    }
}

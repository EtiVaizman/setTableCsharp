using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Setable.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        [Route("getAllProduct")]
        public List<DTO.Product> GetAllProducts()
        {
            return BLL.ProductLogic.GetAllProduct();
        }

        [Route("getProductById")]
        public DTO.Product GetProductById(int productId)
        {
            return BLL.ProductLogic.GetProductById(productId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Setable.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        [Route("ProductOfOrder")]

        public static List<DTO.Product> GetAllPreviousOrders(int idCustomer)
        {
            return BLL.CustomerLogic.GetAllPreviousOrders(idCustomer);
        }
    }
}

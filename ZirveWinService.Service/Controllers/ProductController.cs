using System;
using System.Web.Http;
using ZirveWinService.Library.Controller;
using ZirveWinService.Library.Helpers;
using ZirveWinService.Library.Models;

namespace ZirveWinService.Service.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public ReturnData<bool> Save([FromBody] ProductPostModel data)
        {
            ReturnData<bool> result = new ReturnData<bool>();
            try
            {
                result = clsProduct.Save(data);
            }
            catch (Exception ex)
            {
                result.Status = ReturnStatus.Error;
                result.Message = ex.Message;

                LoggerHelper.Error($"ProductController.Save() -> {ex}");
            }
            return result;
        }
    }
}

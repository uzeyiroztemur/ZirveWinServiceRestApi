using System;
using System.Web.Http;
using ZirveWinService.Library.Models;

namespace ZirveWinService.Service.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public ReturnData<bool> Health()
        {
            ReturnData<bool> result = new ReturnData<bool>();
            try
            {
                result.Data = true;
                result.Message = "OK";
            }
            catch (Exception ex)
            {
                result.Status = ReturnStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}

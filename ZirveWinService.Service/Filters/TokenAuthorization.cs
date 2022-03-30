using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Controllers;
using ZirveWinService.Library.Models;

namespace ZirveWinService.Service.Filters
{
    public class TokenAuthorizationAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext context)
        {
            var _Token = context.Request.Headers.FirstOrDefault(c => c.Key == "Api-Key").ToString();
            if (string.IsNullOrEmpty(_Token))
            {
                var response = new HttpResponseMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(new ReturnData<bool> { Message = "Invalid Api Key!", Status = ReturnStatus.Error }), Encoding.UTF8),
                    StatusCode = HttpStatusCode.Forbidden,
                    ReasonPhrase = JsonConvert.SerializeObject(new ReturnData<bool> { Message = "Invalid Api Key!", Status = ReturnStatus.Error })
                };

                throw new HttpResponseException(response);
            }
            else
            {

                return;
            }
        }
    }
}

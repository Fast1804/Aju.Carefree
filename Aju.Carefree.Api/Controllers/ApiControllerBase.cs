using System.Net;
using Aju.Carefree.NetCore.BaseModel;
using Microsoft.AspNetCore.Mvc;

namespace Aju.Carefree.Api.Controllers
{
    /// <summary>
    /// Base Controller
    /// </summary>
    public class  ApiControllerBase:ControllerBase
    {
        /// <summary>
        /// 返回Json数据
        /// </summary>
        /// <param name="status">状态码</param>
        /// <param name="message">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>param>
        /// <returns></returns>
        
        [NonAction]
        protected virtual JsonResult Json(object data,HttpStatusCode status = HttpStatusCode.OK,string message = "OK")
        {
            var json = new WebApiResult
            {
                Status = status,
                Message = message,
                Data = data
            };
            return new JsonResult(json);
        }
    }
}
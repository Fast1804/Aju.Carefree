using System.Net;

namespace Aju.Carefree.NetCore.BaseModel
{
    /// <summary>
    /// Webapi返回Model
    /// </summary>
    public class WebApiResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public  HttpStatusCode Status { get; set; }
        
        /// <summary>
        /// 消息
        /// </summary>
        public  string Message { get; set; }
        
        /// <summary>
        /// 数据
        /// </summary>
        public  object Data { get; set; }
    }
}
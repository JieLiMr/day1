using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using NLog;
using NLog.Web;
using System.Threading.Tasks;

namespace Week3Api.Filter
{
    
    public class MyException: IAsyncExceptionFilter
    {
       public MyException(Ilog ilog)
        {
            log= ilog;
        }
        public Ilog log { get; set; }
        public Task OnExceptionAsync(ExceptionContext context)
        {
            var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            if (!context.ExceptionHandled)
            {
                // 定义返回类型
                var result = new ResponseMessage
                {
                    Code = 0,
                    Mes = context.Exception.Message
                };
                context.Result = new ContentResult
                {
                    // 返回状态码设置为200，表示成功
                    StatusCode = StatusCodes.Status200OK,
                    // 设置返回格式
                    ContentType = "application/json;charset=utf-8",
                    Content = JsonConvert.SerializeObject(result)
                };
            }
            log.Add(new Model.Log() { Ename = context.Exception.Message });
            logger.Error($"你好啊：{context.Exception.Message}");
            // 设置为true，表示异常已经被处理了
            context.ExceptionHandled = true;
            return Task.CompletedTask;
        }
    }
   
}

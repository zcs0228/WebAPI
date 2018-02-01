using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using ZCSAPI.Log4Net;

namespace ZCSAPI.App_Start
{
    public class ExceptionHandleAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// 重写基类方法
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(HttpActionExecutedContext context)
        {
            Task.Factory.StartNew(() =>
            {
                var exception = context.Exception;
                if (exception != null)
                {
                    LogHelper.Error(exception.ToString());
                }
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZCSAPI.BLL.Message
{
    public class APIResponse<T>
    {
        public T Data { get; set; }
        public string Msg { get; set; }
        public APIResponse(T data)
        {
            this.Data = data;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZCSAPI.BLL.Message
{
    public class APIRequest<T>
    {
        public T Data { get; set; }
        public APIRequest(T data)
        {
            Data = data;
        }
    }
}
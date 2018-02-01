using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZCSAPI.App_Start;
using ZCSAPI.BLL;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL;

namespace ZCSAPI.Controllers
{
    public class ValuesController : BaseController
    {
        // GET api/values
        [BasicAuthorize]
        public Product Get()
        {
            Product product = new Product();
            return product;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        public void Post1(dynamic value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

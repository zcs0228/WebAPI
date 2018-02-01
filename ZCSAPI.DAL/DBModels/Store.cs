using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCSAPI.DAL.DBModels
{
    public class Store : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IQueryable<Product> Products { get; set; }
        public IQueryable<StoreImage> Images { get; set; }
    }
}

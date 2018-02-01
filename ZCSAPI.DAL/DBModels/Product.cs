using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCSAPI.DAL.DBModels
{
    public class Product : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public virtual IQueryable<ProductImage> Images { get; set; }
        public virtual Store Store { get; set; }
    }
}

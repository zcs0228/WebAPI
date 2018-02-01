using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCSAPI.DAL.DBModels
{
    public class ProductImage : BaseEntity
    {
        public string Describe { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string UploadUser { get; set; }
        public Product Product { get; set; }
    }
}

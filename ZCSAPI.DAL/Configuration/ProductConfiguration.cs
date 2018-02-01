using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;

namespace ZCSAPI.DAL.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(t => t.Code).IsUnicode(false);
            Property(t => t.Name).IsUnicode(false);
            Property(t => t.Describe).IsUnicode(false);//将nvarchar改为varchar
        }
    }
}

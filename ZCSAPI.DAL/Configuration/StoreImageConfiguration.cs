using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;

namespace ZCSAPI.DAL.Configuration
{
    public class StoreImageConfiguration : EntityTypeConfiguration<StoreImage>
    {
        public StoreImageConfiguration()
        {
            Property(t => t.Describe).IsUnicode(false);
            Property(t => t.Path).IsUnicode(false);
            Property(t => t.Type).IsUnicode(false);
            Property(t => t.UploadUser).IsUnicode(false);//将nvarchar改为varchar
        }
    }
}

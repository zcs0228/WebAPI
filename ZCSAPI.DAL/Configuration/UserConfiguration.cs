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
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            //HasKey(t => t.ID);
            //Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Code).IsUnicode(false);
            Property(t => t.Password).IsUnicode(false);
            Property(t => t.Email).IsUnicode(false);//将nvarchar改为varchar
            Property(t => t.Phone).IsUnicode(false);
        }
    }
}

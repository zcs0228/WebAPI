using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL.Configuration;

namespace ZCSAPI.DAL
{
    /// <summary>
    /// EF数据迁移：1. enable-migrations -projectname ZCSAPI.DAL -startupprojectname ZCSAPI 
    /// 其中projectname为context所在的工程，startupprojectname配置文件所在的工程
    /// 2. add-migration -projectname ZCSAPI.DAL
    /// 3. update-database -projectname ZCSAPI.DAL
    /// </summary>
    public class APIContext : DbContext
    {
        public DbSet<User> Users { get; set; }        
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreImage> StoreImage { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //添加数据库属性配置
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new StoreConfiguration());
            modelBuilder.Configurations.Add(new StoreImageConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductImageConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

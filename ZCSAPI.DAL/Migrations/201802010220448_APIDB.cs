namespace ZCSAPI.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class APIDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Describe = c.String(unicode: false),
                        Path = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        UploadUser = c.String(unicode: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Product_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Code = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        Describe = c.String(unicode: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Store_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.Store_ID)
                .Index(t => t.Store_ID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Code = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StoreImages",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Describe = c.String(unicode: false),
                        Path = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        UploadUser = c.String(unicode: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Store_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.Store_ID)
                .Index(t => t.Store_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Code = c.String(unicode: false),
                        Name = c.String(),
                        Password = c.String(unicode: false),
                        PasswordSalt = c.String(),
                        Email = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StoreImages", "Store_ID", "dbo.Stores");
            DropForeignKey("dbo.ProductImages", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "Store_ID", "dbo.Stores");
            DropIndex("dbo.StoreImages", new[] { "Store_ID" });
            DropIndex("dbo.Products", new[] { "Store_ID" });
            DropIndex("dbo.ProductImages", new[] { "Product_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.StoreImages");
            DropTable("dbo.Stores");
            DropTable("dbo.Products");
            DropTable("dbo.ProductImages");
        }
    }
}

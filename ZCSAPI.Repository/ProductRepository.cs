using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL;

namespace ZCSAPI.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        APIContext context = null;
        public ProductRepository()
        {
            context = new APIContext();
        }

        public Guid AddEntity(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        public Product GetEntityByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetEntitys()
        {
            return context.Products.AsQueryable();
        }

        public void ModifyEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

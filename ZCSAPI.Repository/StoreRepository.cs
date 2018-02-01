using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL;

namespace ZCSAPI.Repository
{
    public class StoreRepository : IRepository<Store>
    {
        APIContext context = null;
        public StoreRepository()
        {
            context = new APIContext();
        }
        public Guid AddEntity(Store entity)
        {
            context.Stores.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }

        public Store GetEntityByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Store> GetEntitys()
        {
            throw new NotImplementedException();
        }

        public void ModifyEntity(Store entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Store entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

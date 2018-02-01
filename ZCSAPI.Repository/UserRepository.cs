using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL;

namespace ZCSAPI.Repository
{
    public class UserRepository : IRepository<User>
    {
        APIContext context = null;
        public UserRepository()
        {
            context = new APIContext();
        }
        public User GetUserByCode(string code)
        {
            return context.Users.FirstOrDefault(t => t.Code == code);
        }
        public User GetEntityByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetEntitys()
        {
            throw new NotImplementedException();
        }

        public void ModifyEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid AddEntity(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }
    }
}

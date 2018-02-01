using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.DAL;

namespace ZCSAPI.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Guid AddEntity(T entity);
        IQueryable<T> GetEntitys();
        T GetEntityByID(Guid id);
        void ModifyEntity(T entity);
        void RemoveEntity(T entity);
        void RemoveEntity(Guid id);
    }
}

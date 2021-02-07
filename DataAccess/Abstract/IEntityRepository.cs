using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<Type> where Type: class, IEntity, new()
    {
        List<Type> GetAll(Expression<Func<Type, bool>> filter = null);
        void Add(Type entity);
        void Update(Type entity);
        void Delete(Type entity);
        Type Get(Expression<Func<Type, bool>> filter);

    }
}

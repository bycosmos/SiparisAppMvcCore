using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiparisApp.Dal.Abstract
{
  
        public interface IRepository<T>
        {
            T GetById(int id);
            T GetOne(Expression<Func<T, bool>> filter);
            List<T> GetAll(Expression<Func<T, bool>> filter = null);
            List<T> GetAllById(Expression<Func<T, bool>> where);

           void Create(T entity);
            void Update(T entity);
            void Delete(T entity);
        }
    }


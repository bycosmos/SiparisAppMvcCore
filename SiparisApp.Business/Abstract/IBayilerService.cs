using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiparisApp.Business.Abstract
{
 public   interface IBayilerService
    {
        Bayiler GetById(int id);

      
        List<Bayiler> GetAll();
        List<Bayiler> GetAllById(Expression<Func<Bayiler, bool>> where);

        bool Create(Bayiler entity);
        void Update(Bayiler entity);
        void Delete(Bayiler entity);
      
    }
}

using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Abstract
{
  public  interface IIllerService
    {
        Iller GetById(int id);


        List<Iller> GetAll();
        bool Create(Iller entity);
        void Update(Iller entity);
        void Delete(Iller entity);
    }
}

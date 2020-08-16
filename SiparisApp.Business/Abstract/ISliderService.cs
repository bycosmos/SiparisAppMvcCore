using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Abstract
{
   public interface ISliderService
    {
        Slider GetById(int id);

        
        List<Slider> GetAll();
        bool Create( Slider entity);
        void Update(Slider entity);
        void Delete(Slider entity);
      
    }
}

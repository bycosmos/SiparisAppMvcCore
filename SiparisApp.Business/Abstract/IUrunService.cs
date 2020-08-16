using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Abstract
{
   public interface IUrunService
    {
        Urunler GetById(int id);

        Urunler GetUrunDetails(int id);
        List<Urunler> GetAll();

        bool Create(Urunler entity);
        void Update(Urunler entity);
        void Delete(Urunler entity);
        void Update(Urunler entity, int[] categoryIds);
    }
}

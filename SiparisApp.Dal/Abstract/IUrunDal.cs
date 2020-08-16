using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Dal.Abstract
{
   public interface IUrunDal:IRepository<Urunler>
    {

        Urunler GetUrunDetails(int id);
        void Update(Urunler entity, int[] categoryIds);
    }
}

using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Dal.Abstract
{
  public  interface ISepetDal:IRepository<Sepet>
    {
        Sepet GetByUserId(string userId);
        void DeleteFromSepet(int sepetId, int urunId);
        void ClearSepet(string sepetId);
    }
}

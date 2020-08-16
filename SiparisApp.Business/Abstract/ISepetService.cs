using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Abstract
{
   public interface ISepetService
    {
        void InitializeSepet(string userId);
        Sepet GetSepetByUserId(string userId);
        void AddToSepet(string userId, int urunId, int quantity);
        void DeleteFromSepet(string userId, int urunId);
        void ClearSepet(string SepetId);
        void Update(Sepet entity);
    }
}

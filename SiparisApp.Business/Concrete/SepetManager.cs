using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Concrete
{
  public  class SepetManager:ISepetService
    {
        private ISepetDal _sepetDal;
        public SepetManager(ISepetDal sepetDal)
        {
            _sepetDal = sepetDal;
        }

        public void AddToSepet(string userId, int urunId, int quantity)
        {
            var sepet = GetSepetByUserId(userId);
            if (sepet != null)
            {
                var index = sepet.SepetDetays.FindIndex(i => i.UrunlerId == urunId);

                if (index < 0)
                {
                    sepet.SepetDetays.Add(new SepetDetay()
                    {
                        UrunlerId = urunId,
                        Quantity = quantity,
                        SepetId = sepet.Id
                    });
                }
                else
                {
                    sepet.SepetDetays[index].Quantity += quantity;
                }

                _sepetDal.Update(sepet);
            }
        }

        public void DeleteFromSepet(string userId, int urunId)
        {
            var Sepet = GetSepetByUserId(userId);
            if (Sepet != null)
            {
                _sepetDal.DeleteFromSepet(Sepet.Id, urunId);
            }
        }

        public Sepet GetSepetByUserId(string userId)
        {
            return _sepetDal.GetByUserId(userId);
        }

        public void InitializeSepet(string userId)
        {
            _sepetDal.Create(new Sepet() { UserId = userId });
        }
        public void ClearSepet(string SepetId)
        {
            _sepetDal.ClearSepet(SepetId);
        }
        public void Update(Sepet entity)
        {
            _sepetDal.Update(entity);
        }

    }
}

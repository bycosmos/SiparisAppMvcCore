using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Concrete
{
  public  class UrunManager:IUrunService
    {
        private IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }


        public bool Create(Urunler entity)
        {
            if (Validate(entity))
            {
                _urunDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Urunler entity)
        {
            _urunDal.Delete(entity);
        }

        public List<Urunler> GetAll()
        {
            return _urunDal.GetAll();
        }

        public Urunler GetById(int id)
        {
            return _urunDal.GetById(id);
        }


        public Urunler GetUrunDetails(int id)
        {
            return _urunDal.GetUrunDetails(id);
        }



        public void Update(Urunler entity)
        {
            _urunDal.Update(entity);
        }

        public void Update(Urunler entity, int[] categoryIds)
        {
            _urunDal.Update(entity, categoryIds);
        }

        public string ErrorMessage { get; set; }

        public bool Validate(Urunler entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Isim))
            {
                ErrorMessage += "ürün ismi girmelisiniz";
                isValid = false;
            }

            return isValid;
        }
    }
}

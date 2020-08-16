using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Concrete
{
   public class KategoriManager :IKategoriService
    {
           private IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }


        public bool Create(Kategori entity)
        {
            if (Validate(entity) )
            {
                _kategoriDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Update(Kategori entity)
        {
            _kategoriDal.Update(entity);
        }


        public void Delete(Kategori entity)
        {
            _kategoriDal.Delete(entity);
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetAll();
        }

        public Kategori GetById(int id)
        {
            return _kategoriDal.GetById(id);
        }
        public bool Validate(Kategori entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Isim))
            {
                ErrorMessage += "Bir isim giriniz";
                isValid = false;
            }

            return isValid;
        }
        public string ErrorMessage { get; set; }


    }
}

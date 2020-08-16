using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Concrete
{
   public class IllerManager:IIllerService
    {

        private IIllerDal _illerDal;

        public IllerManager(IIllerDal illerDal)
        {
            _illerDal = illerDal;
        }


        public bool Create(Iller entity)
        {
            if (Validate(entity))
            {
                _illerDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Update(Iller entity)
        {
            _illerDal.Update(entity);
        }


        public void Delete(Iller entity)
        {
            _illerDal.Delete(entity);
        }

        public List<Iller> GetAll()
        {
            return _illerDal.GetAll();
        }

        public Iller GetById(int id)
        {
            return _illerDal.GetById(id);
        }
        public bool Validate(Iller entity)
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

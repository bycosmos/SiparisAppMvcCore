using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SiparisApp.Business.Concrete
{
  public  class BayilerManager:IBayilerService
    {
        private IBayilerDal _bayilerDal;
        public BayilerManager(IBayilerDal bayilerDal)
        {
            _bayilerDal = bayilerDal;
        }



        public bool Create(Bayiler entity)
        {
            if (Validate(entity))
            {
                _bayilerDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Bayiler entity)
        {
            _bayilerDal.Delete(entity);
        }

        public List<Bayiler> GetAll()
        {
            return _bayilerDal.GetAll();
        }
        public List<Bayiler> GetAllById(Expression<Func<Bayiler, bool>> where)
        {
            return _bayilerDal.GetAllById(where);
        }


        public Bayiler GetById(int id)
        {
            return _bayilerDal.GetById(id);
        }





        public void Update(Bayiler entity)
        {
            _bayilerDal.Update(entity);
        }

      

        public string ErrorMessage { get; set; }

        public bool Validate(Bayiler entity)
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

using SiparisApp.Business.Abstract;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Concrete
{
   public class SliderManager:ISliderService
    {

        private ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }


        public bool Create(Slider entity)
        {
            if (Validate(entity) )
            {
                _sliderDal.Create(entity);
                return true;
            }
            return false;
        }

        public void Delete(Slider entity)
        {
            _sliderDal.Delete(entity);
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider GetById(int id)
        {
            return _sliderDal.GetById(id);
        }


      


        public void Update(Slider entity)
        {
            _sliderDal.Update(entity);
        }


        public bool Validate(Slider entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.ResimAdres))
            {
                ErrorMessage += "Bir Resim Seçmelisiniz !";
                isValid = false;
            }

            return isValid;
        }
        public string ErrorMessage { get; set; }

       
    }
}

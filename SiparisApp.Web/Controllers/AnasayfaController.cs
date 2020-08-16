using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiparisApp.Business.Abstract;
using SiparisApp.Business.Concrete;
using SiparisApp.Entities;
using SiparisApp.Web.Models;

namespace SiparisApp.Web.Controllers
{
    public class AnasayfaController : Controller
    {
        private ISliderService _sliderService;
        public AnasayfaController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IActionResult Anasayfa()
        {
            var model = new AnasayfaViewModel
            {
                SliderList = _sliderService.GetAll()
            };
            return View(model);
        }
        public IActionResult SliderDüzenle(int id)
        {
          
          
            var model = new AnasayfaSliderEkleDüzenle
            {
                Slider = _sliderService.GetById(id)
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SliderDüzenle (AnasayfaSliderEkleDüzenle model, IFormFile file)

        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine($"wwwroot/img/Slider", new Random().Next(1000, 9999).ToString() + file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);

            }




            Slider s = _sliderService.GetById(model.Slider.Id);

            s.ResimAdres = path.Substring(19);
            _sliderService.Update(s);





            return RedirectToAction("SliderEkle");
        }
        public IActionResult SliderEkle()
        {
            var model = new SliderEkleViewModel
            {
                SliderList = _sliderService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SliderEkle(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine($"wwwroot/img/Slider", new Random().Next(1000, 9999).ToString() + file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);

            }



         
                Slider s = new Slider();
                s.ResimAdres = path.Substring(19);
                _sliderService.Create(s);
           
            
          

            return RedirectToAction("SliderEkle");
        }


        
        public IActionResult SliderSil(int id)
        {
            _sliderService.Delete(_sliderService.GetById(id));
            return RedirectToAction("SliderEkle");
        }




    }
}
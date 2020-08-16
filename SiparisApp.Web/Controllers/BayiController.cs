using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiparisApp.Business.Abstract;
using SiparisApp.Entities;
using SiparisApp.Web.Models;

namespace SiparisApp.Web.Controllers
{
    public class BayiController : Controller
    {
        private IIllerService _illerService;
        private IBayilerService _bayilerService;
        public BayiController(IIllerService illerService,IBayilerService bayilerService)
        {
            _illerService = illerService;
            _bayilerService = bayilerService;
        }
        public IActionResult Bayiler(BayiListeleEkleDuzenle model)
        {
            model.illers = _illerService.GetAll();

            return View(model);

        }
        public IActionResult IllerListesi()
        {
            var model = new IllerListeleEkleDuzenleModel
            {
                illers = _illerService.GetAll()
            };
            return View(model);
        }
      
       public IActionResult IlSil( int Id)
        {
            _illerService.Delete(_illerService.GetById(Id));
            return RedirectToAction("IllerListesi");
        }
       public IActionResult IlEkle()
        {
            IllerListeleEkleDuzenleModel model = new IllerListeleEkleDuzenleModel();

            return View(model);
        }
        [HttpPost]
        public IActionResult IlEkle( IllerListeleEkleDuzenleModel model)
        {
            _illerService.Create(model.iller);

            return RedirectToAction("IlEkle");
        }
        public IActionResult IlDuzenle(int Id)
        {
            var model = new IllerListeleEkleDuzenleModel
            {
                iller = _illerService.GetById(Id)
            };
            return View(model);
           
        }
        [HttpPost]
        public IActionResult IlDuzenle(IllerListeleEkleDuzenleModel model)
        {
            Iller i = _illerService.GetById(model.iller.Id);
            i = model.iller;
            _illerService.Update(i);
            return RedirectToAction("IllerListesi");

        }
        public IActionResult BayiListesi(BayiListeleEkleDuzenle model)
        {
            model.illers = _illerService.GetAll();

            return View(model);

        }
        public ActionResult _bayilerlistesi(int id)
        {
            var model = new BayiListeleEkleDuzenle
            {
                
                bayilers = _bayilerService.GetAllById(x=>x.IllerId==id)
               
            };
            return PartialView("_bayilerlistesi",model);

        }
        public ActionResult _bayilerduzenlemelistesi(int id)
        {
            var model = new BayiListeleEkleDuzenle
            {

                bayilers = _bayilerService.GetAllById(x => x.IllerId == id)

            };
            return PartialView("_bayilerduzenlemelistesi", model);

        }
        public ActionResult BayiEkle()
        {
            var model = new BayiListeleEkleDuzenle()
            {

                illers = _illerService.GetAll()

            };


            return View(model);

        }
        [HttpPost]
        public ActionResult BayiEkle(BayiListeleEkleDuzenle model,int IlId)
        {
            model.bayiler.IllerId = IlId;
            _bayilerService.Create(model.bayiler);

            return RedirectToAction("BayiEkle");

        }

        public ActionResult BayiDuzenle(int Id)
        {
            var model = new BayiListeleEkleDuzenle()
            {
                bayiler = _bayilerService.GetById(Id),
                illers=_illerService.GetAll(),
                iller=_illerService.GetById(_bayilerService.GetById(Id).IllerId)
                
                
            };

            return View(model);

        }

        [HttpPost]
        public ActionResult BayiDuzenle(BayiListeleEkleDuzenle model,int IlId)
        {
            model.bayiler.IllerId = IlId;
            _bayilerService.Update(model.bayiler);

            return RedirectToAction("BayiListesi");

        }



    }
}

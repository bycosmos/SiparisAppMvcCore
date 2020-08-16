using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SiparisApp.Business.Abstract;
using SiparisApp.Entities;
using SiparisApp.Web.Models;

namespace SiparisApp.Web.Controllers
{
    public class UrunController : Controller
    {

        private IUrunService _urunService;
        private IKategoriService _kategoriService;
        public UrunController(IUrunService urunService,IKategoriService kategoriService)
        {
            _urunService = urunService;
            _kategoriService = kategoriService;
        }



        public IActionResult Urunler()
        {
            var model = new UrunListesiModel
            {
                UrunList = _urunService.GetAll()
            };
            return View(model);
        
        }

        public IActionResult Urun(int id)
        {
            var model = new UrunListesiModel
            {
                  urun = _urunService.GetById(id)
            };
            return View(model);

        }
        public IActionResult UrunEkle()
        {
            var model = new UrunEkleSilModel
            {
              Kat  = _kategoriService.GetAll()
            };
          

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> UrunEkle(UrunEkleSilModel model, IFormFile file, int katId)

        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine($"wwwroot/img/Urunler", new Random().Next(1000, 9999).ToString() + file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);

            }
            model.Urun.ResimUrl = path.Substring(20);
            model.Urun.KategoriId = katId;
            _urunService.Create(model.Urun);

            return RedirectToAction("UrunEkle");
        }
        public IActionResult UrunDuzenleSil()
        {
            var model = new UrunEkleSilModel
            {
                urunler = _urunService.GetAll()
                
                
            };
            foreach (var item in model.urunler)
            {
                item.Kategori= _kategoriService.GetById(item.KategoriId);
            }

          
            return View(model);

        }
        public IActionResult UrunSil(int Id)
        {
            _urunService.Delete(_urunService.GetById(Id));

            return RedirectToAction("UrunDuzenleSil");

        }
        public IActionResult UrunDuzenle( int Id)
        {
            var model = new UrunEkleSilModel
            {
                Urun = _urunService.GetById(Id),
              Kat =_kategoriService.GetAll()
                
            };
            
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> UrunDuzenle(UrunEkleSilModel model, IFormFile file,int  KategoriId)

        {
            if (file != null)

            {

                var path = Path.Combine($"wwwroot/img/Urunler", new Random().Next(1000, 9999).ToString() + file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);

                }




                model.Urun.ResimUrl = path.Substring(20);






            }
            model.Urun.KategoriId = KategoriId;
            
            _urunService.Update(model.Urun);





            return RedirectToAction("UrunEkle");
        }

        public IActionResult KategoriEkle()
        {

            KategoriEkleDuzenleModel model = new KategoriEkleDuzenleModel();

            return View(model);

        }
        [HttpPost]
        public IActionResult KategoriEkle(KategoriEkleDuzenleModel model)
        {

            _kategoriService.Create(model.kategori);

            return RedirectToAction("KategoriEkle");

        }


        public IActionResult KategoriListele()
        {
            var model = new KategoriEkleDuzenleModel
            {
                kategoris = _kategoriService.GetAll()
            };


            return View(model); 

        }
        public IActionResult KategoriSil(int Id)
        {
            _kategoriService.Delete(_kategoriService.GetById(Id));

            return RedirectToAction("KategoriListele");

        }
        public IActionResult KategoriDuzenle(int Id)
        {
            var model = new KategoriEkleDuzenleModel
            {
                kategori = _kategoriService.GetById(Id)
            };


            return View(model);

        }
        [HttpPost]
        public IActionResult KategoriDuzenle(KategoriEkleDuzenleModel model)
        {
            Kategori k = _kategoriService.GetById(model.kategori.Id);
            k.Isim = model.kategori.Isim;
            _kategoriService.Update(k);


            return RedirectToAction("KategoriListele");

        }


    }
}

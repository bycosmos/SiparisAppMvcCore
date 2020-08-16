using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SiparisApp.Business.Abstract;
using SiparisApp.Web.Identity;
using SiparisApp.Web.Models;

namespace SiparisApp.Web.Controllers
{
    public class SepetController : Controller
    {
        private ISepetService _sepetService;
        private UserManager<ApplicationUser> _userManager;

        public SepetController(ISepetService sepetService, UserManager<ApplicationUser> userManager)
        {
            _sepetService = sepetService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var sepet = _sepetService.GetSepetByUserId(_userManager.GetUserId(User));
            return View(new SepetModel()
            {
                SepetId = sepet.Id,
                SepetDetails = sepet.SepetDetays.Select(i => new SepetDetailModel()
                {
                    SepetDetailId = i.Id,
                    UrunId = i.Urunler.Id,
                    Name = i.Urunler.Isim,
                    Price = (decimal)i.Urunler.Fiyat,
                    ImageUrl = i.Urunler.ResimUrl,
                    Quantity = i.Quantity,
                    TotalPrice = i.TotalPrice
                
                    
                     

                }

                  ).ToList()



            }); ;
        }
        public IActionResult Sepetim()
        {
            var sepet = _sepetService.GetSepetByUserId(_userManager.GetUserId(User));
            return View(new SepetModel()
            {
                SepetId = sepet.Id,
                SepetDetails = sepet.SepetDetays.Select(i => new SepetDetailModel()
                {
                    SepetDetailId = i.Id,
                    UrunId = i.Urunler.Id,
                    
                    Name = i.Urunler.Isim,
                    Price = (decimal)i.Urunler.Fiyat,
                    ImageUrl = i.Urunler.ResimUrl,
                    Quantity = i.Quantity,
                    TotalPrice=i.TotalPrice




                }

                  ).ToList()



            }); ;
        }

        [HttpPost]
        public IActionResult SepeteEkle(int urunId, int quantity)
        {
            _sepetService.AddToSepet(_userManager.GetUserId(User), urunId, quantity);
            return RedirectToAction("Sepetim");
        }
        [HttpPost]
        public IActionResult DeleteFromBasket(int productId)
        {
            _sepetService.DeleteFromSepet(_userManager.GetUserId(User), productId);
            return RedirectToAction("Index");
        }
    }
}

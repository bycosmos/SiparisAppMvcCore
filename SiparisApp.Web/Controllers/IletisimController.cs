using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiparisApp.Web.EmailServices;
using SiparisApp.Web.Models;

namespace SiparisApp.Web.Controllers
{
    public class IletisimController : Controller
    {
        private IMyEmailSender _smtpemailSender;
        public IletisimController(IMyEmailSender smtpemailSender)
        {
           
            _smtpemailSender = smtpemailSender;
        }
        public IActionResult Iletisim()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Iletisim(IletisimModel model)
        {
            if (ModelState.IsValid)
            {
                model.Mesaj = $"<h3><p> Yeşil Tuğla Fabrikası İletişim  <hr/></p></h3>" + $"<p> Gönderen: {model.Adi} </p>" + $"<p> Mail: {model.Email} </p>" + $"<p> Telefon: {model.Telefon} </p>" + $"<p> Mesaj: {model.Mesaj} </p>";
               
                _smtpemailSender.SendEmailAsync(model.Email,model.Konu,model.Mesaj);

                ViewBag.Success = true;
                
            }

            

            return Redirect("Iletisim/Iletisim");

        }
    }
}

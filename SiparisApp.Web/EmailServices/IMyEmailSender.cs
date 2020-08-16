using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.EmailServices
{
    public interface IMyEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmMessage);
        Task TakingEmail(string name,string email, string phone,string subject, string htmMessage);
    }
}

using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.Models
{
    public class BayiListeleEkleDuzenle
    {
     public   List<Bayiler> bayilers { get; set; }
      public  Bayiler bayiler { get; set; }
     public   List<Iller> illers { get; set; }
        public Iller iller { get; set; }
        public string secim { get; set; }
        public int secimId { get; set; }
    }
}

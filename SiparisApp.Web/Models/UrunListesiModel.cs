using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.Models
{
    public class UrunListesiModel
    {
        public List<Urunler> UrunList { get; set; }
        public Urunler urun { get; set; }
    }
}

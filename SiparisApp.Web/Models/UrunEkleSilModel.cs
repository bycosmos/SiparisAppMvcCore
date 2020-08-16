using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.Models
{
    public class UrunEkleSilModel
    {
       

        public  List<Kategori>Kat { get; set; }

        public List<Urunler> urunler { get; set; }
        public Urunler Urun { get; set; }
    }
}

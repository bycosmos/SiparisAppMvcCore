using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.Models
{
    public class KategoriEkleDuzenleModel
    {
      public  List<Kategori> kategoris { get; set; }
      public Kategori kategori { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Entities
{
   public class Kategori
    {
        public int Id { get; set; }
       
        public string Isim { get; set; }


        public virtual List<Urunler> Urunlers { get; set; }
    }
}

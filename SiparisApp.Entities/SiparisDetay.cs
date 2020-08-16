using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Entities
{
   public class SiparisDetay
    {
        public int Id { get; set; }

        public int SiparisId { get; set; }
        public Siparis Siparis { get; set; }

        public int UrunlerId { get; set; }
        public Urunler Urunler { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

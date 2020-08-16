using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
   public class SepetDetay
    {

        [Key]
        public int Id { get; set; }

        public Urunler Urunler { get; set; }
        public int UrunlerId { get; set; }

        public Sepet Sepet { get; set; }
        public int SepetId { get; set; }

        public int Quantity { get; set; }
        public string TotalPrice { get; set; }
    }
}

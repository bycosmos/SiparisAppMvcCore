using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
   public class Referanslar
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Adres { get; set; }
        public string WebUrl { get; set; }
    }
}

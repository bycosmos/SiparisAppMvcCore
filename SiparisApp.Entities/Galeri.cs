using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
  public  class Galeri
    {

        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string ResimAdres { get; set; }
        public string GosterimSirasi { get; set; }
        public bool Aktif { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
  public  class Videolar
    {

        [Key]
        public int Id { get; set; }
        public string Aciklama { get; set; }

        public string Adres { get; set; }

    }
}

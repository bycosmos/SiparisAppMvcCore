using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
  public  class Sepet
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<SepetDetay> SepetDetays { get; set; }
        public string CustomerIp { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerInformation { get; set; }
    }
}

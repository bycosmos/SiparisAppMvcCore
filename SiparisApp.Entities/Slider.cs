using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
   public class Slider
    {
        [Key]
        public int Id { get; set; }
        public string ResimAdres { get; set; }
    }
}

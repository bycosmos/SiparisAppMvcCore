using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
    public class Bayiler
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Telefon { get; set; }



        public string Fax { get; set; }




        public string Adres { get; set; }




        public string Email { get; set; }




        public int IllerId { get; set; }
        public string GosterimSirasi { get; set; }
        public bool Aktif { get; set; }


        public virtual Iller Iller { get; set; }
    }
}

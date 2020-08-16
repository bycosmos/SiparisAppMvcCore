using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Entities
{
    class Dealers
    {

        public string Telefon { get; set; }



        public string Fax { get; set; }




        public string Adres { get; set; }




        public string Email { get; set; }




        public int IllerId { get; set; }


        public virtual Iller Iller { get; set; }
    }
}

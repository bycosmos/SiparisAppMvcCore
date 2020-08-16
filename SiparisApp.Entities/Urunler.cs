using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiparisApp.Entities
{
   public class Urunler
    {
        [Key]
        public int Id { get; set; }
        public int UrunKodu { get; set; }
        public string Isim { get; set; }
        public string ResimUrl { get; set; }
      
        public decimal? Fiyat { get; set; }

        public string Agirlik { get; set; }
        public string BasincDayanimi { get; set; }
        public string IsiIletkenligi { get; set; }
        public string MetrekareTuglaSayisi { get; set; }
      
        public string Boyut { get; set; }


        public string PalettekiTuglaSayisi { get; set; }
        public string Aciklama { get; set; }
        public string GosterimSirasi { get; set; }
        public bool Aktif { get; set; }
        public int KategoriId { get; set; }


        public virtual Kategori Kategori { get; set; }

        public List<SepetDetay> SepetDetays { get; set; }

    }
}

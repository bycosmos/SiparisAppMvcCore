using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiparisApp.Dal.Concrete.EfCore
{
   public class EfCoreUrunDal: EfCoreGenericRepository<Urunler, ShopContext>, IUrunDal
    {

        public Urunler GetUrunDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Urunlers
                            .Where(i => i.Id == id)

                            .FirstOrDefault();
            }
        }

        public void Update(Urunler entity, int[] categoryIds)
        {
            using (var context = new ShopContext())
            {
                var urunler = context.Urunlers
                    
                                   .FirstOrDefault(i => i.Id == entity.Id);

                if (urunler != null)
                {
                    urunler.Isim = entity.Isim;
                    urunler.Aciklama = entity.Aciklama;
                    urunler.Agirlik = entity.Agirlik;
                    urunler.BasincDayanimi = entity.BasincDayanimi;
                    urunler.Boyut = entity.Boyut;
                    urunler.Fiyat = entity.Fiyat;
                    urunler.Id = entity.Id;
                    urunler.IsiIletkenligi = entity.IsiIletkenligi;
                    
                    urunler.Aktif = entity.Aktif;
                    urunler.GosterimSirasi = entity.GosterimSirasi;
                    urunler.ResimUrl = entity.ResimUrl;
                    
              

                   

                    context.SaveChanges();
                }
            }
        }

    }
}

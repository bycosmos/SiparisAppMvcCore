using Microsoft.EntityFrameworkCore;
using SiparisApp.Dal.Abstract;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiparisApp.Dal.Concrete.EfCore
{
  public  class EfCoreSepetDal : EfCoreGenericRepository<Sepet, ShopContext>,ISepetDal
    {
        public override void Update(Sepet entity)
        {
            using (var context = new ShopContext())
            {
                context.Sepets.Update(entity);
                context.SaveChanges();
            }
        }

        public Sepet GetByUserId(string userId)
        {
            using (var context = new ShopContext())
            {
                return context
                            .Sepets
                            .Include(i => i.SepetDetays)
                            .ThenInclude(i => i.Urunler)
                            .FirstOrDefault(i => i.UserId == userId);
            }
        }

        public void DeleteFromSepet(int sepetId, int urunId)
        {
            using (var context = new ShopContext())
            {
                var cmd = @"delete from BasketDetail where SepetId=@p0 And UrunId=@p1";
                context.Database.ExecuteSqlCommand(cmd, sepetId, urunId);
            }
        }

        public void ClearSepet(string sepetId)
        {
            using (var context = new ShopContext())
            {
                var cmd = @"delete from BasketDetail where BasketId=@p0";
                context.Database.ExecuteSqlCommand(cmd, sepetId);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Dal.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-663FOB8;Database=SiparisAppDbbb;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
       
        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Bayiler> Bayilers { get; set; }

        public DbSet<Galeri> Galeris { get; set; }

        public DbSet<Iller> Illers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }

        public DbSet<Referanslar> Referanslars { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<Siparis> Siparis { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Urunler> Urunlers { get; set; }


        public DbSet<Videolar> Videolars { get; set; }








    }
}

using SiparisApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisApp.Business.Abstract
{
 public interface IKategoriService
    {
        Kategori GetById(int id);


        List<Kategori> GetAll();
        bool Create(Kategori entity);
        void Update(Kategori entity);
        void Delete(Kategori entity);
    }
}

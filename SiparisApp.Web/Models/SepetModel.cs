using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisApp.Web.Models
{
    public class SepetModel
    {
        public int SepetId { get; set; }
        public List<SepetDetailModel> SepetDetails { get; set; }
       
        //public string CustomerAddress { get; set; }
        
        public decimal TotalPrice()
        {
            return SepetDetails.Sum(i => i.Price * i.Quantity);
        }
    }

    public class SepetDetailModel
    {
        public int SepetDetailId { get; set; }

        public int UrunId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public string TotalPrice { get; set; }
    }

}

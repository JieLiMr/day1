using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("ShopingCarModel")]
    public class ShopingCarModel
    {
        [Key]
        public int Cid { get; set; }
        public string UserID { get; set; }
        public long CarCode { get; set; }
        public int FoodCount { get; set; }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("FoodModel")]
    public class FoodModel
    {
        [Key]
        public int Fid { get; set; }
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Num { get; set; }
        public string FoddImgPath { get; set; }
        public int  FoodTypeId { get; set; }
    }
}

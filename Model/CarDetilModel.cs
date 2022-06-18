using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("CarDetilModel")]
    public class CarDetilModel
    {
        [Key]
        public int CarDetilId { get; set; }

        public string FoodName { get; set; }
        public int  FoodId { get; set; }
        public long CarCode { get; set; }
        public decimal FoodPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Num { get; set; }
        public string FoddImgPath { get; set; }
    }
}

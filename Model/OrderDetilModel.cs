using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("OrderDetilModel")]
    public class OrderDetilModel
    {
        [Key]
        public int Id { get; set; }
        public long OrderId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int BuyCount { get; set; }
        public decimal Price { get; set; }
    }
}

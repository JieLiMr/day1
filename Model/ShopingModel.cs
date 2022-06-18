using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("ShopingModel")]
    public class ShopingModel
    {
        [Key]
        public int Sid { get; set; }
        public string ShopingName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string SaleTime { get; set; }
    }
}

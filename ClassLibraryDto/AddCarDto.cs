using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClassLibraryDto
{
    public class AddCarDto
    {
        public int Uid { get; set; }
        public int FoodID { get; set; }
        [Range(1, 10,
                ErrorMessage = "购物数据 {0} 要介于 {1} 到 {2} 之间")]
        public int buycont { get; set; }
    }
}

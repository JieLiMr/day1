using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("FoodTypeModel")]
    public class FoodTypeModel
    {
        [Key]
        public int FoodTypeId { get; set; }
        public string FoodTypeName { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 可以使用雪花ID
        /// </summary>
        public long Code { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime AddTime { get; set; }
    }
}

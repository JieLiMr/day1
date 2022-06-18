using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Model
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDto
{
    public class AddOrderDto
    {
        public int UserId { get; set; }

        public List<GoodsDto> GoodsDtos { get; set; }
    }
    public class GoodsDto
    {
        public int FoodId { get; set; }
        public int BuyCount { get; set; }
    }
}

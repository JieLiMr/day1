using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IOrder
    {
        bool Add(OrderModel obj1,List<OrderDetilModel>  obj2);
    }
}

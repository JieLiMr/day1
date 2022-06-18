using ClassLibraryEF;
using IService;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Order : IOrder
    {
        public Order(MyDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public MyDbContext DbContext { get; set; }

        public bool Add(OrderModel obj1, List<OrderDetilModel> obj2)
        {
            bool isOk = false;
            using (var tran = DbContext.Database.BeginTransaction())
            {
                try
                {
                    DbContext.OrderModel.Add(obj1);

                    var q = from o in obj2
                            select new OrderDetilModel
                            {
                                BuyCount = o.BuyCount,
                                FoodId = o.FoodId,
                                OrderId= o.OrderId,
                                Price = o.Price,                            
                                FoodName = o.FoodName,
                            };
                    DbContext.OrderDetilModel.AddRange(q);
                    DbContext.SaveChanges();
                    tran.Commit();
                    isOk = true;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    isOk=false; 
                    throw;
                }

            }
            return isOk;
        }
    }
}

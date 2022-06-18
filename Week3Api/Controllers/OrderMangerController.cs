using ClassLibrary2DbAccess;
using ClassLibraryDto;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;

namespace Week3Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderMangerController : ControllerBase
    {
        public OrderMangerController(IOrder order,IFood food)
        {
            Order = order;
            foodDo = food;
        }
        public IOrder Order { get; set; }
        public IFood foodDo { get; set; }
        [HttpPost]
        public bool Add(AddOrderDto obj)
        {
            OrderModel orderInfor = new OrderModel();
            orderInfor.AddTime = DateTime.Now;
            orderInfor.Code= YitIdHelper.NextId();
            orderInfor.Price = 0;
            orderInfor.UserId = obj.UserId;

            List<OrderDetilModel> list = new List<OrderDetilModel>();
            foreach(var item in obj.GoodsDtos)
            {
                var goodsModel = foodDo.GetFood(item.FoodId);

                var d1 = new OrderDetilModel();
                d1.FoodId = item.FoodId;
                d1.OrderId = orderInfor.Code;
                d1.BuyCount = item.BuyCount;
                d1.Price =goodsModel.SalePrice;
                d1.FoodName = goodsModel.FoodName;
                list.Add(d1);

                orderInfor.Price += (item.BuyCount * goodsModel.SalePrice); //  计算订单所有商品总金额
            }
            return Order.Add(orderInfor,list);
        }
    }
}

using ClassLibraryDto;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Week3Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopingCarController : ControllerBase
    {
        public ShopingCarController(ICar shopping,IFood food)
        {
            Car = shopping;
            foodDo = food;
        }

        public ICar Car { get; set; }
        public IFood foodDo { get; set; }

        [HttpPost]
        public bool Add(AddCarDto obj)
        {
            //1找出购物车
            var buyCarModel = Car.FindShopCar(obj.Uid);

            //修改购物车内的信息
            buyCarModel.FoodCount += obj.buycont;

            CarDetilModel carDetil = new CarDetilModel
            {
                CarCode = buyCarModel.CarCode,
                FoodId = obj.FoodID,
                // 商品价格是从商品表查出来的不要直接使用页面在上传递来的
                FoodPrice = foodDo.GetFood(obj.FoodID).FoodPrice,
                SalePrice = foodDo.GetFood(obj.FoodID).SalePrice,
                FoddImgPath = foodDo.GetFood(obj.FoodID).FoddImgPath,
                Num = obj.buycont,
                 FoodName= foodDo.GetFood(obj.FoodID).FoodName
            };
            return Car.Add(buyCarModel, carDetil);
        }
        [HttpPost]
        public bool Del(int[] ids)
        {
        return Car.Del(ids);
        }
        [HttpGet]

        public List<carInfor> GetShopingCarModels()
        {
          return Car.GetShopingCarModels();
        }
        [HttpGet]
        public int zhangsan()
        {
            int b = 5;
            int c=0;
            var a = b/c;
            return 0;
        }
    }
}

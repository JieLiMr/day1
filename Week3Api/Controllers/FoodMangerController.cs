using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Week3Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FoodMangerController : ControllerBase
    {
        public FoodMangerController(IFood food)
        {
            foodDo = food;
        }
        public IFood foodDo { get; }

        /// <summary>
        /// 显示菜单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<FoodModel> getFood()
        {
            return foodDo.GetFoods();
        }
        [HttpGet]
        public List<FoodTypeModel> GetFoodTypes()
        {
            return foodDo.GetFoodTypes();
        }
        [HttpPost]
        public bool Add(FoodModel obj)
        {
            return foodDo.Add(obj);
        }
    }
}

using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Week3Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingMangerController : ControllerBase
    {
        public ShoppingMangerController(Ishopping shoppingDo)
        {
            shopping=shoppingDo;
        }
        public Ishopping shopping { get; }
        /// <summary>
        /// 显示商家信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ShopingModel> GetShopings()
        {
            return shopping.GetShopingModels();
        }
           
    }
}

using ClassLibrary2DbAccess;
using ClassLibraryDto;
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
    public class Car : ICar
    {
        public Car(MyDbContext db)
        {
            dbContext = db;
        }
        public MyDbContext dbContext { get; }

        public bool Add(ShopingCarModel car, CarDetilModel carDetil)
        {
            bool isOk = false;
            using (var tran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    dbContext.Entry(car).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();

                    //先查商品是否已经存在
                    var item = dbContext.CarDetilModel.Where(d => d.FoodId == carDetil.FoodId).FirstOrDefault();
                    if (item == null) //不存在添加
                    {
                        dbContext.CarDetilModel.Add(carDetil);
                    }
                    else
                    {
                        //存在了修改购买数量 
                        item.Num += carDetil.Num;
                    }
                    
                    dbContext.SaveChanges();
                    tran.Commit();
                    isOk = true;
                }
                catch (Exception)
                {
                    tran.Rollback();
                    isOk = false;

                    throw;
                }


            }
            return isOk;
        }

        public bool Del(int[] ids)
        {
            var obj = dbContext.ShopingCarModel.Where(m => ids.Contains(m.Cid));
            dbContext.ShopingCarModel.RemoveRange(obj);
            return dbContext.SaveChanges() > 0;
        }

        public ShopingCarModel FindShopCar(int Uid)
        {
            var car = dbContext.ShopingCarModel.Where(m => m.UserID == Uid.ToString()).FirstOrDefault();
            if (car != null)
            {
                return car;
            }
            //创建购物车表
            var model = new ShopingCarModel { UserID = Uid.ToString(), CarCode = YitIdHelper.NextId(), FoodCount = 0 };
            var s = dbContext.ShopingCarModel.Add(model);
            dbContext.SaveChanges();
            return model;
        }

        public List<carInfor> GetShopingCarModels()
        {
           
            var list=(
                from car in dbContext.ShopingCarModel
                join food in dbContext.CarDetilModel
                on car.CarCode equals food.CarCode
                select new carInfor()
                {
                     FoodName=food.FoodName,
                      FoodNum=food.Num,
                       FoodPrice=food.SalePrice,
                       FoodId=food.FoodId,
                      Id=car.Cid
                }
                ).ToList();
            return list;
        }
    }
}

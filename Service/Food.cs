using ClassLibraryEF;
using IService;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class Food:IFood
    {
        public Food(MyDbContext dbContext)
        {
            db=dbContext;
        }
        public MyDbContext db { get; set; }

        public bool Add(FoodModel obj)
        {
           db.FoodModel.Add(obj);
            return db.SaveChanges() > 0;
        }

        public FoodModel GetFood(int id)
        {
            return db.FoodModel.Find(id);
        }

        public List<FoodModel> GetFoods()
        {
            return db.FoodModel.ToList();
        }

        public List<FoodTypeModel> GetFoodTypes()
        {
            return db.FoodTypeModel.ToList();
        }
    }
}

using Model;
using System;
using System.Collections.Generic;

namespace IService
{
    public interface IFood
    {
        List<FoodModel> GetFoods();
        FoodModel GetFood(int id);
        List<FoodTypeModel> GetFoodTypes();
        bool Add(FoodModel obj);
    }
}

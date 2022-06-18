using ClassLibraryDto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface ICar
    {
        bool Add(ShopingCarModel car,CarDetilModel carDetil);
        bool Del(int[] ids);
        List<carInfor> GetShopingCarModels();
        ShopingCarModel FindShopCar(int Uid);
    }
}

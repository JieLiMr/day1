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
    public class Shopping : Ishopping
    {
        public Shopping(MyDbContext dbContext)
        {
           db=dbContext;
        }
        public MyDbContext db { get; }
        public List<ShopingModel> GetShopingModels()
        {
            try
            {
                return db.ShopingModel.ToList();
            }
            catch (Exception)
            {
                //db.Log.Add(ex);
                throw;
            }
            
        }
    }
}

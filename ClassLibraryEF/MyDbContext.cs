using Microsoft.EntityFrameworkCore;
using System;
using Model;
namespace ClassLibraryEF
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
        public DbSet<ShopingModel> ShopingModel { get; set; }
        public DbSet<FoodModel> FoodModel { get; set; }
        public DbSet<ShopingCarModel> ShopingCarModel { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<CarDetilModel> CarDetilModel { get; set; }
        public DbSet<OrderModel> OrderModel { get; set; }
        public DbSet<OrderDetilModel> OrderDetilModel { get; set; }
        public DbSet<FoodTypeModel> FoodTypeModel { get; set; }
    }
}

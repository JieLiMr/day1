using ClassLibraryEF;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Log:Ilog
    {
        public Log(MyDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public MyDbContext DbContext { get; }

        public bool Add(Model.Log obj)
        {
            DbContext.Log.Add(obj);
            return DbContext.SaveChanges() > 0;
        }
    }
}

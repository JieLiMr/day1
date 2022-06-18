using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Week3Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpFileController : ControllerBase
    {
        public UpFileController(IWebHostEnvironment environment)
        {
            env = environment;
        }
        public IWebHostEnvironment env { get; set; }
        /// <summary>
        /// 上传照片
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        public string UpLoad(IFormFile file)
        {
            if (file != null)
            {
                string filename = DateTime.Now.ToString("yyyyMMddss") + Path.GetExtension(file.FileName);
                var path = env.ContentRootPath + @"\UpFiles\" + filename;
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                return filename;
            }
            else
            {
                return null;
            }
        }
    }
}

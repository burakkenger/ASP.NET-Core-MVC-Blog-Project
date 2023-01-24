using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.EnitiyFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        Context data = new Context();
        public ICollection<Blog> GetListIncludeCategory()
        {
            return data.Blogs.Include(x => x.Category).Include(x => x.Writer).ToList(); //Ben burayi sonradan editleyip writer tablosunu da include ettim
        }
    }
}

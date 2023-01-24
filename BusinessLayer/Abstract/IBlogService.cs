using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        ICollection<Blog> GetAll();
        Blog GetById(int ID);
        ICollection<Blog> GetBlogListIncludeCategory();
        ICollection<Blog> GetBlogListByWriter(int ID);
    }
}

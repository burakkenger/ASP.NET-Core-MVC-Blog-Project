using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public ICollection<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int ID)
        {
            return _blogDal.GetByID(ID);
        }

        public ICollection<Blog> GetBlogListIncludeCategory()
        {
            return _blogDal.GetListIncludeCategory();
        }

        public ICollection<Blog> GetBlogByID(int ID)
        {
            return _blogDal.GetAll(x => x.ID == ID);
        }

        public ICollection<Blog> GetBlogListByWriter(int ID)
        {
            return _blogDal.GetAll(x => x.WriterID == ID);
        }
    }
}

using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int ID)
        {
            return _categoryDal.GetByID(ID);
        }
    }
}

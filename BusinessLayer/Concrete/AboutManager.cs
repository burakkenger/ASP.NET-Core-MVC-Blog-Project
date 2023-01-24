using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }
        public ICollection<About> GetAll()
        {
            int ID = 1;
            return _AboutDal.GetAll(x => x.ID == ID);
        }
    }
}

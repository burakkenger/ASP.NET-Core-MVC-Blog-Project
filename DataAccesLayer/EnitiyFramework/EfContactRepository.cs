using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EnitiyFramework
{
    public class EfContactRepository: GenericRepository<Contact>, IContactDal
    {
    }
}

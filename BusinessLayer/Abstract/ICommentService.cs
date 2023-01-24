using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void CategoryDelete(Comment category);
        //void CategoryUpdate(Comment category);
        ICollection<Comment> GetAll(int ID);
        //Comment GetById(int ID);
    }
}

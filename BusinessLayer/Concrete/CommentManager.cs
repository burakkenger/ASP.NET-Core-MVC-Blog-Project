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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void AddComment(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public ICollection<Comment> GetAll(int ID)
        {
           return _commentDal.GetAll(x => x.BlogID == ID);
        }
    }
}

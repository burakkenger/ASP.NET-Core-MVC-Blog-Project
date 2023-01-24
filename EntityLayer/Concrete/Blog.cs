using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ThumbnailImage { get; set; }
        public string? Image { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int WriterID { get; set; }
        public Writer Writer { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}

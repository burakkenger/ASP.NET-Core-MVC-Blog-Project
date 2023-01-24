using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string? UserName { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}

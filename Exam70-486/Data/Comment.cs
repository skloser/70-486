using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam70_486.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
    }
}
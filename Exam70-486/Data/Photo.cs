using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam70_486.Data
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public byte[] PhotoFile { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        [DisplayName("Created Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "The image was modified on {0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam70_486.Data
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        public string Url { get; set; }

        public byte[] Image { get; set; }


    }
}
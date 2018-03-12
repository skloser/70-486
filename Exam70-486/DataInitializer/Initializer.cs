using Exam70_486.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam70_486.DataInitializer
{
    public class Initializer : DropCreateDatabaseAlways<PhotoSharingContext>
    {
        protected override void Seed(PhotoSharingContext context)
        {
            var photo = new Photo();
            photo.Url = @"\Images\Iglika.jpg";
            photo.CreatedDate = DateTime.Now;
            context.Photos.Add(photo);
            context.SaveChanges();
        }
    }
}
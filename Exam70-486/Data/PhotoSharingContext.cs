namespace Exam70_486.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhotoSharingContext : DbContext
    {
        public PhotoSharingContext()
            : base("name=PhotoSharingContext")
        {
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
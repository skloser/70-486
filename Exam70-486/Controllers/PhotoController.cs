using Exam70_486.Data;
using Exam70_486.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam70_486.Controllers
{
    [DebugLoggerFilter]
    public class PhotoController : Controller
    {
        private PhotoSharingContext context = new PhotoSharingContext();

        public ActionResult Index()
        {
            var allPhotos = context.Photos.ToList();

            return View(allPhotos);
        }

        public ActionResult Display(int id)
        {
            var photoToDisplay = context.Photos.FirstOrDefault(p => p.PhotoId == id);

            if (photoToDisplay == null)
            {
                return HttpNotFound();
            }

            return View(photoToDisplay);
        }

        public ActionResult Create()
        {
            var photo = new Photo();

            return View(photo);
        }

        [HttpPost]
        public ActionResult Create(Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return View(photo);
            }

            context.Photos.Add(photo);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var photoToDelete = context.Photos.FirstOrDefault(p => p.PhotoId == id);

            return View(photoToDelete);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(Photo photo)
        {
            context.Photos.Remove(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ContentResult GetImage(int id)
        {
            var photoImage = context.Photos.FirstOrDefault(p => p.PhotoId == id);

            return Content(photoImage.Url);
        }

        public ActionResult Details(int id)
        {
            var photo = context.Photos.FirstOrDefault(p => p.PhotoId == id);

            return View(photo);
        }
    }
}
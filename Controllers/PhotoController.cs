using Microsoft.AspNetCore.Mvc;
using PaulaPachecoHairStyle.Repositories.Interfaces;

namespace PaulaPachecoHairStyle.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoController(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public IActionResult ListPhoto(int procedureId)
        {
            var photos = _photoRepository.Photo.Where(p => p.ProcedureId == procedureId).ToList();

            if (!photos.Any())
            {
                
                return RedirectToAction("Index", "Home");
            }

            return View("ListPhoto", photos); 
        }
    }

}


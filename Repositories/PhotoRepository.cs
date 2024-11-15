using Microsoft.EntityFrameworkCore;
using PaulaPachecoHairStyle.Context;
using PaulaPachecoHairStyle.Models;
using PaulaPachecoHairStyle.Repositories.Interfaces;

namespace PaulaPachecoHairStyle.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly AppDbContext _appDbContext;
        public PhotoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Photo> Photo => _appDbContext.Photo.Include(p => p.procedure);
    }
}

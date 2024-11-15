using PaulaPachecoHairStyle.Models;

namespace PaulaPachecoHairStyle.Repositories.Interfaces
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> Photo { get; }
    }
}

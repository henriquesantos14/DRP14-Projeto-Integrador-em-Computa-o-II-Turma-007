using PaulaPachecoHairStyle.Models;

namespace PaulaPachecoHairStyle.Repositories.Interfaces
{
    public interface IProceduresRepository
    {
        IEnumerable<Procedure> Procedures { get; }

        Task SalvarImagemComoBase64Async(int procedureId, string imagePath);
    }
}

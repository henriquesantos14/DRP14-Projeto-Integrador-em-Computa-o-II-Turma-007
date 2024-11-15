using Microsoft.EntityFrameworkCore;
using PaulaPachecoHairStyle.Context;
using PaulaPachecoHairStyle.Models;
using PaulaPachecoHairStyle.Repositories.Interfaces;

namespace PaulaPachecoHairStyle.Repositories
{
    public class ProceduresRepository : IProceduresRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProceduresRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Procedure> Procedures => _appDbContext.Procedures;

        public async Task SalvarImagemComoBase64Async(int procedureId, string imagePath)
        {
            var procedure = await _appDbContext.Procedures.FindAsync(procedureId);
            if (procedure != null && File.Exists(imagePath))
            {
                byte[] imageBytes = await System.IO.File.ReadAllBytesAsync(imagePath);
                procedure.CoverImageBase64 = Convert.ToBase64String(imageBytes);

                await _appDbContext.SaveChangesAsync();
            }
        }

    }
}

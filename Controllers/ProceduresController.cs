using Microsoft.AspNetCore.Mvc;
using PaulaPachecoHairStyle.Repositories.Interfaces;

namespace PaulaPachecoHairStyle.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly IProceduresRepository _proceduresRepository;

        public ProceduresController(IProceduresRepository proceduresRepository)
        {
            _proceduresRepository = proceduresRepository;
        }
        public IActionResult List()
        {
            var procedures = _proceduresRepository.Procedures;
            return View(procedures);
        }

        public async Task<IActionResult> SalvarImagemEmBase64(int procedureId)
        {
            try
            {
                // Caminho da imagem (ajuste conforme o local de armazenamento das suas imagens)
                string imagePath = Path.Combine("wwwroot", "images", $"{procedureId}.jpeg");

                // Chama o método para salvar a imagem como Base64
                await _proceduresRepository.SalvarImagemComoBase64Async(procedureId, imagePath);

                // Redireciona de volta para a lista de procedimentos
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso algo dê errado
                TempData["Error"] = $"Erro ao salvar a imagem: {ex.Message}";
                return RedirectToAction("List");
            }
        }
    }
}

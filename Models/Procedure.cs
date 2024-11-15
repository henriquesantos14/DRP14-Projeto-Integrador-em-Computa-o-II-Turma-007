using System.ComponentModel.DataAnnotations;

namespace PaulaPachecoHairStyle.Models
{
    public class Procedure
    {
        public int ProcedureId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho Máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o Nome da Categoria")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(300, ErrorMessage = "O tamanho Máximo é 300 caracteres")]
        [Required(ErrorMessage = "Informe o Nome da Categoria")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        public string CoverImageBase64 { get; set; }

        public List<Photo> Photos { get; set; }
    }
}

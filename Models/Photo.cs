using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaulaPachecoHairStyle.Models
{
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho Máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o Nome da Categoria")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(600, ErrorMessage = "O tamanho Máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o Nome da Categoria")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        public int ProcedureId { get; set; }

        public Procedure procedure { get; set; }


    }
}

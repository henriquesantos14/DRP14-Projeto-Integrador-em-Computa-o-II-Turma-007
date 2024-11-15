using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaulaPachecoHairStyle.Migrations
{
    /// <inheritdoc />
    public partial class ADD_PROCEDIMENTOS01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("INSERT INTO Procedures(Name, Description, CoverImageBase64)" +
                "VALUES('Corte', 'Transforme seu visual e renove sua autoestima com cortes de cabelo impecáveis! Oferecemos as últimas tendências e técnicas personalizadas para realçar sua beleza única. Venha vivenciar um serviço de qualidade que faz toda a diferença!', 'images/Cortes.jpeg')");

            migrationBuilder.Sql("INSERT INTO Procedures(Name, Description, CoverImageBase64)" +
               "VALUES('Mechas', 'Ilumine seu visual com mechas de cabelo que refletem sua personalidade! utilizamos técnicas modernas e produtos de alta qualidade para garantir resultados naturais e deslumbrantes.', 'images/Mechas.jpeg')");

            migrationBuilder.Sql("INSERT INTO Procedures(Name, Description, CoverImageBase64)" +
               "VALUES('Maquiagem', 'Realce sua beleza com uma maquiagem personalizada, feita por um profissional apaixonado e atualizado nas melhores técnicas! Com produtos de alta qualidade, garantimos o visual perfeito para qualquer ocasião, elevando sua confiança e tornando cada momento especial.', 'images/Maquiagem.jpeg')");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Procedures");
        }
    }
    
}

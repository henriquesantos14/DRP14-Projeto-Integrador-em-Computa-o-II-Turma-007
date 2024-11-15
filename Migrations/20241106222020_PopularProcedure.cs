using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaulaPachecoHairStyle.Migrations
{
    /// <inheritdoc />
    public partial class PopularProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Procedures(Name, Description)" +
                "VALUES('Penteados','Desenvolvemos penteados com elegância e sofisticação para qualquer ocasião. Nosso penteado clássico combina estilo e simplicidade, ideal para eventos formais e celebrações especiais.Com técnicas de escova e fixação precisas, garantimos que seu visual permaneça impecável durante todo o evento.')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Procedures");
        }
    }
}

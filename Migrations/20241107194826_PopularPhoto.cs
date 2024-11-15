using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaulaPachecoHairStyle.Migrations
{
    /// <inheritdoc />
    public partial class PopularPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Photo(Name, Description,ImagemThumbnailUrl,procedureId)" +
                  "VALUES('Trança Lateral','A trança lateral é uma ótima opção para o cabelo médio, já que ela pode ser vista como um adereço para o seu cabelo. Ainda pode ser feita em um só dos lados da cabeça ou mesmo nos dois!','/images/penteado-com-tranca-lateral.jpg','1')");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Photo");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaulaPachecoHairStyle.Migrations
{
    /// <inheritdoc />
    public partial class ADD_PHOTOS01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Photo(Name, Description,ImagemThumbnailUrl,procedureId)" +
                  "VALUES('Trança Torcida','A trança torcida é um estilo moderno e versátil que combina elegância com praticidade. Criada ao torcer duas mechas de cabelo, ela pode ser usada em penteados mais simples ou combinada com outras técnicas para um visual mais elaborado. Perfeita para cabelos de diferentes texturas, a trança torcida destaca-se pela aparência entrelaçada e natural, proporcionando um efeito volumoso e sofisticado. Seja em coques, rabos de cavalo ou solta, essa trança é ideal para ocasiões formais e informais, mantendo um toque de charme e originalidade.','/images/TrançaCatarina.jpeg','1')");

            migrationBuilder.Sql("INSERT INTO Photo(Name, Description,ImagemThumbnailUrl,procedureId)" +
                 "VALUES('Mechas Blond',' As mechas são uma técnica popular de coloração que adiciona luminosidade e profundidade ao cabelo, criando um visual dinâmico e moderno. Podem ser feitas em diferentes estilos, como babylights, ombré, balayage ou tradicionais, dependendo do efeito desejado. Essa técnica permite clarear ou colorir partes específicas do cabelo, dando movimento e realce aos fios. As mechas são versáteis e se adaptam a diversos tons de pele e estilos, oferecendo desde um resultado sutil e natural até algo mais marcante e ousado.','/images/Mechas02','9')");

            migrationBuilder.Sql("INSERT INTO Photo(Name, Description,ImagemThumbnailUrl,procedureId)" +
                  "VALUES('Mechas Iluminada','As mechas iluminadas são perfeitas para quem busca um visual radiante e natural, trazendo leveza e brilho ao cabelo. Essa técnica cria reflexos sutis que imitam o efeito do sol nos fios, realçando a cor base sem perder a naturalidade. Podem ser aplicadas em diferentes tons, desde dourado e caramelo até loiro mais suave, adaptando-se a vários tipos e cores de cabelo. O resultado é um look moderno, com profundidade e movimento, ideal para dar um toque de frescor e luminosidade ao visual, sem mudanças drásticas.','/images/MechasIluminada.jpeg','9')");

            migrationBuilder.Sql("INSERT INTO Photo(Name, Description,ImagemThumbnailUrl,procedureId)" +
                  "VALUES('Corte Degradê Médio','O corte degradê médio feminino é uma opção moderna e sofisticada que combina camadas sutis para criar um efeito de transição suave entre os comprimentos do cabelo. Esse estilo proporciona movimento e volume, destacando os contornos do rosto de maneira elegante. Ideal para quem deseja um look leve e versátil, o corte degradê médio é perfeito para vários tipos de cabelo, seja liso, ondulado ou cacheado. Ele permite diferentes formas de estilização, desde um visual despojado e natural até penteados mais polidos e formais, sempre com um toque de frescor e personalidade.','/images/CorteDegradeMédio.jpeg','8')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

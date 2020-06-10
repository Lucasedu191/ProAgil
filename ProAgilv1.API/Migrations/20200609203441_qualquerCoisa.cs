using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgilv1.API.Migrations
{
    public partial class qualquerCoisa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}

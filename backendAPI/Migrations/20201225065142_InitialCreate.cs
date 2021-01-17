using Microsoft.EntityFrameworkCore.Migrations;

namespace backendAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    team = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    joinedDate = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    avatar = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

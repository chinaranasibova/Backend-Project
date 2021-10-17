using Microsoft.EntityFrameworkCore.Migrations;

namespace Quarter.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebPage = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    HeaderLogo = table.Column<string>(maxLength: 100, nullable: false),
                    FooterLogo = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    SupportPhone = table.Column<string>(maxLength: 20, nullable: false),
                    SupportEmail = table.Column<string>(maxLength: 100, nullable: false),
                    FacebookUrl = table.Column<string>(maxLength: 100, nullable: false),
                    TwitterUrl = table.Column<string>(maxLength: 100, nullable: false),
                    YoutubeUrl = table.Column<string>(maxLength: 100, nullable: false),
                    LinkedinUrl = table.Column<string>(maxLength: 100, nullable: false),
                    AboutUsTitle = table.Column<string>(maxLength: 100, nullable: false),
                    AboutUsDescription = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}

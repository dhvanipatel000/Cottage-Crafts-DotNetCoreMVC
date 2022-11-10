using Microsoft.EntityFrameworkCore.Migrations;

namespace cottage_crafts.Migrations
{
    public partial class abcde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ca_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ca_name = table.Column<string>(nullable: true),
                    ca_price = table.Column<int>(nullable: false),
                    ca_desc = table.Column<string>(nullable: true),
                    ca_img = table.Column<string>(nullable: true),
                    ca_category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ca_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");
        }
    }
}

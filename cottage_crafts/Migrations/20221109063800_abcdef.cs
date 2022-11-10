using Microsoft.EntityFrameworkCore.Migrations;

namespace cottage_crafts.Migrations
{
    public partial class abcdef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ca_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ca_category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ca_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ca_img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ca_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ca_price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ca_id);
                });
        }
    }
}

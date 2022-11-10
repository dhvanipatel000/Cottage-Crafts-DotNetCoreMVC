using Microsoft.EntityFrameworkCore.Migrations;

namespace cottage_crafts.Migrations
{
    public partial class session_table_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Sessions",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Sessions",
                newName: "UserName");
        }
    }
}

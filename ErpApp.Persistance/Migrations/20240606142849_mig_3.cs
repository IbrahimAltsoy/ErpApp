using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpApp.Persistance.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "application",
                table: "Notifications",
                newName: "Message");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                schema: "application",
                table: "Notifications",
                newName: "Name");
        }
    }
}

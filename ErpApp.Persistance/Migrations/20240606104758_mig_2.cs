using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpApp.Persistance.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EndpointId",
                schema: "application",
                table: "AspNetRoles",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Endpoints",
                schema: "application",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ActionType = table.Column<string>(type: "text", nullable: false),
                    HttpType = table.Column<string>(type: "text", nullable: false),
                    Definition = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endpoints", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_EndpointId",
                schema: "application",
                table: "AspNetRoles",
                column: "EndpointId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_Endpoints_EndpointId",
                schema: "application",
                table: "AspNetRoles",
                column: "EndpointId",
                principalSchema: "application",
                principalTable: "Endpoints",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_Endpoints_EndpointId",
                schema: "application",
                table: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Endpoints",
                schema: "application");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_EndpointId",
                schema: "application",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "EndpointId",
                schema: "application",
                table: "AspNetRoles");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAPIDemo.Migrations
{
    public partial class addedsurgery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SurgeryId",
                table: "Patient",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Surgery",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgery", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SurgeryId",
                table: "Patient",
                column: "SurgeryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient",
                column: "SurgeryId",
                principalTable: "Surgery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient");

            migrationBuilder.DropTable(
                name: "Surgery");

            migrationBuilder.DropIndex(
                name: "IX_Patient_SurgeryId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "SurgeryId",
                table: "Patient");
        }
    }
}

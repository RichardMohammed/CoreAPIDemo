using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAPIDemo.Migrations
{
    public partial class addedsurgeryidtopatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient");

            migrationBuilder.AlterColumn<long>(
                name: "SurgeryId",
                table: "Patient",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient",
                column: "SurgeryId",
                principalTable: "Surgery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient");

            migrationBuilder.AlterColumn<long>(
                name: "SurgeryId",
                table: "Patient",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Surgery_SurgeryId",
                table: "Patient",
                column: "SurgeryId",
                principalTable: "Surgery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

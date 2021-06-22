using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArchitecture.RepositoryLayer.Migrations
{
    public partial class UpDateCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customer",
                newName: "Customer_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Customer_Name",
                table: "Customer",
                type: "NVARCHAR(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_Name",
                table: "Customer",
                newName: "CustomerName");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(200)");
        }
    }
}

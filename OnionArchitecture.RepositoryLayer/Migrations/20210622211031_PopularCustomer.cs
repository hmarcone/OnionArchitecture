using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArchitecture.RepositoryLayer.Migrations
{
    public partial class PopularCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "id", "created_date", "Customer_Name", "is_active", "modified_date", "payment_type", "purchased_product" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 22, 18, 10, 30, 697, DateTimeKind.Local).AddTicks(7016), "João Augusto", false, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(2510), "Cartão", "S" },
                    { 2, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3215), "Maria Augusta", true, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3220), "Dinheiro", "S" },
                    { 3, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3223), "José Augusto Rodrigues", true, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3224), "Cheque", "S" },
                    { 4, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3226), "Fernando Medeiros de Almeida", false, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3227), "Cartão Débito", "S" },
                    { 5, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3230), "João Alfredo", true, new DateTime(2021, 6, 22, 18, 10, 30, 702, DateTimeKind.Local).AddTicks(3231), "Pix", "S" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}

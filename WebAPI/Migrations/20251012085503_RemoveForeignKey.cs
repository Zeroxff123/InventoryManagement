using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class RemoveForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInvoices_Customers_Customer_id",
                table: "CustomerInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInvoices_Vats_Vat_id",
                table: "CustomerInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vats",
                table: "Vats");

            migrationBuilder.DropIndex(
                name: "IX_CustomerInvoices_Customer_id",
                table: "CustomerInvoices");

            migrationBuilder.RenameTable(
                name: "Vats",
                newName: "VATs");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "CustomerInvoices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VATs",
                table: "VATs",
                column: "VatId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoices_CustomerId",
                table: "CustomerInvoices",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInvoices_Customers_CustomerId",
                table: "CustomerInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInvoices_VATs_Vat_id",
                table: "CustomerInvoices",
                column: "Vat_id",
                principalTable: "VATs",
                principalColumn: "VatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInvoices_Customers_CustomerId",
                table: "CustomerInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInvoices_VATs_Vat_id",
                table: "CustomerInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VATs",
                table: "VATs");

            migrationBuilder.DropIndex(
                name: "IX_CustomerInvoices_CustomerId",
                table: "CustomerInvoices");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerInvoices");

            migrationBuilder.RenameTable(
                name: "VATs",
                newName: "Vats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vats",
                table: "Vats",
                column: "VatId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoices_Customer_id",
                table: "CustomerInvoices",
                column: "Customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInvoices_Customers_Customer_id",
                table: "CustomerInvoices",
                column: "Customer_id",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInvoices_Vats_Vat_id",
                table: "CustomerInvoices",
                column: "Vat_id",
                principalTable: "Vats",
                principalColumn: "VatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

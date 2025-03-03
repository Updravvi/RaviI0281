using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Migrations
{
    /// <inheritdoc />
    public partial class training2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Salesorder",
                table: "Salesorder");

            migrationBuilder.RenameTable(
                name: "Salesorder",
                newName: "SalesOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder",
                column: "OrderNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesOrder",
                table: "SalesOrder");

            migrationBuilder.RenameTable(
                name: "SalesOrder",
                newName: "Salesorder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salesorder",
                table: "Salesorder",
                column: "OrderNo");
        }
    }
}

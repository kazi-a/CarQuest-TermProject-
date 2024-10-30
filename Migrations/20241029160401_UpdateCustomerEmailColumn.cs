using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarQuest.Migrations
{
    public partial class UpdateCustomerEmailColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "Customer_Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_Email",
                table: "Customers",
                newName: "Email");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalApp_DataBase.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 1, null, "Huseyn", "Mehdiyev", "123", "huseyn" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 1, "Huseyn", "Mehdiyev", "123", "huseyn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

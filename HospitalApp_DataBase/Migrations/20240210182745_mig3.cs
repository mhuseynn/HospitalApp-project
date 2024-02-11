using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalApp_DataBase.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departmentss_DepartmentId",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmentss",
                table: "Departmentss");

            migrationBuilder.RenameTable(
                name: "Departmentss",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departmentss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmentss",
                table: "Departmentss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departmentss_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departmentss",
                principalColumn: "Id");
        }
    }
}

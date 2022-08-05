using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AttMembro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Membros",
                table: "Membros");

            migrationBuilder.RenameTable(
                name: "Membros",
                newName: "tb_membro");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "tb_membro",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_membro",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Github",
                table: "tb_membro",
                newName: "github");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_membro",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_membro",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_membro",
                table: "tb_membro",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_membro",
                table: "tb_membro");

            migrationBuilder.RenameTable(
                name: "tb_membro",
                newName: "Membros");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Membros",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Membros",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "github",
                table: "Membros",
                newName: "Github");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Membros",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Membros",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Membros",
                table: "Membros",
                column: "Id");
        }
    }
}

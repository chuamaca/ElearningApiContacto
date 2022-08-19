using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRest.Elearning.Migrations
{
    public partial class AddDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RasonSocila = table.Column<string>(nullable: true),
                    Ruc = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Distrito = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "contacto",
                columns: table => new
                {
                    IdContacto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    correo = table.Column<string>(nullable: false),
                    empresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacto", x => x.IdContacto);
                    table.ForeignKey(
                        name: "FK_contacto_empresa_empresaId",
                        column: x => x.empresaId,
                        principalTable: "empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contacto_empresaId",
                table: "contacto",
                column: "empresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacto");

            migrationBuilder.DropTable(
                name: "empresa");
        }
    }
}

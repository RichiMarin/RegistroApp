using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoR.APP.Persistencia.Migrations
{
    public partial class MigraInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gruporh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    encargado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel_encargado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grupo_etnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vacuna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre_vacuna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dosis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");
        }
    }
}

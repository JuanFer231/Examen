using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda_Pacientes.Data.Migrations
{
    public partial class AddPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacientePrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteSegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCorreo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacineteAcompananteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteAcompananteApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteDireccionCalle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteEstado_Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteCodigoPostal = table.Column<int>(type: "int", nullable: false),
                    PacienteNTelefonoCodigoArea = table.Column<int>(type: "int", nullable: false),
                    PacienteNTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteNwasapcodigo = table.Column<int>(type: "int", nullable: false),
                    PacienteNwasap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}

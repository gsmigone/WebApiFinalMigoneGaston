using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalMigoneGaston.Migrations
{
    public partial class NuevaBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    HospitalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumCama = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.HospitalID);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalID = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Especialidad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoID);
                    table.ForeignKey(
                        name: "FK_Medico_Hospital_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospital",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medico_HospitalID",
                table: "Medico",
                column: "HospitalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}

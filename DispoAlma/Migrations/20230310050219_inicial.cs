using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DispoAlma.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DispositivoAlmacenamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_dispositivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Almacenamiento_dispositivo = table.Column<int>(type: "int", nullable: false),
                    Descripcion_dispositivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Velocidad_escritura = table.Column<int>(type: "int", nullable: false),
                    Velocidad_lectura = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispositivoAlmacenamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DispositivoAlmacenamientos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DispositivoAlmacenamientos_ProveedorId",
                table: "DispositivoAlmacenamientos",
                column: "ProveedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispositivoAlmacenamientos");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc.Migrations
{
    /// <inheritdoc />
    public partial class yourMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposOcorrencias",
                columns: table => new
                {
                    TipoOcorrenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOcorrencias", x => x.TipoOcorrenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    DenunciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoOcorrenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.DenunciaId);
                    table.ForeignKey(
                        name: "FK_Denuncia_TiposOcorrencias_TipoOcorrenciaId",
                        column: x => x.TipoOcorrenciaId,
                        principalTable: "TiposOcorrencias",
                        principalColumn: "TipoOcorrenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Denuncia_TipoOcorrenciaId",
                table: "Denuncia",
                column: "TipoOcorrenciaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Denuncia");

            migrationBuilder.DropTable(
                name: "TiposOcorrencias");
        }
    }
}

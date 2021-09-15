using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "GeomShape");

            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Drawing",
                schema: "GeomShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawing", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shape",
                schema: "GeomShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DrawingId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    OffsetX = table.Column<double>(type: "double", nullable: false),
                    OffsetY = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shape", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shape_Drawing_DrawingId",
                        column: x => x.DrawingId,
                        principalSchema: "GeomShape",
                        principalTable: "Drawing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Circle",
                schema: "GeomShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Radius = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Circle_Shape_Id",
                        column: x => x.Id,
                        principalSchema: "GeomShape",
                        principalTable: "Shape",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rectangle",
                schema: "GeomShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LengthA = table.Column<float>(type: "float", nullable: false),
                    LengthB = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rectangle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rectangle_Shape_Id",
                        column: x => x.Id,
                        principalSchema: "GeomShape",
                        principalTable: "Shape",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Triangle",
                schema: "GeomShape",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LengthA = table.Column<float>(type: "float", nullable: false),
                    LengthB = table.Column<float>(type: "float", nullable: false),
                    LengthC = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triangle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Triangle_Shape_Id",
                        column: x => x.Id,
                        principalSchema: "GeomShape",
                        principalTable: "Shape",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Shape_DrawingId",
                schema: "GeomShape",
                table: "Shape",
                column: "DrawingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circle",
                schema: "GeomShape");

            migrationBuilder.DropTable(
                name: "Rectangle",
                schema: "GeomShape");

            migrationBuilder.DropTable(
                name: "Triangle",
                schema: "GeomShape");

            migrationBuilder.DropTable(
                name: "Shape",
                schema: "GeomShape");

            migrationBuilder.DropTable(
                name: "Drawing",
                schema: "GeomShape");
        }
    }
}

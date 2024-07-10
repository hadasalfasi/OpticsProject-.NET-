using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custumers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GModel = table.Column<string>(type: "text", nullable: false),
                    GPD = table.Column<int>(type: "integer", nullable: false),
                    GRnumber = table.Column<string>(type: "text", nullable: false),
                    GRCyilinder = table.Column<string>(type: "text", nullable: false),
                    GRAxis = table.Column<int>(type: "integer", nullable: false),
                    GRAddition = table.Column<string>(type: "text", nullable: false),
                    GRPrizma = table.Column<string>(type: "text", nullable: false),
                    GRIndex = table.Column<double>(type: "double precision", nullable: false),
                    GLnumber = table.Column<string>(type: "text", nullable: false),
                    GLCyilinder = table.Column<string>(type: "text", nullable: false),
                    GLRAxis = table.Column<int>(type: "integer", nullable: false),
                    GLAddition = table.Column<string>(type: "text", nullable: false),
                    GLPrizma = table.Column<string>(type: "text", nullable: false),
                    GLIndex = table.Column<double>(type: "double precision", nullable: false),
                    Rnumber = table.Column<string>(type: "text", nullable: false),
                    RCyilinder = table.Column<string>(type: "text", nullable: false),
                    RAxis = table.Column<int>(type: "integer", nullable: false),
                    RBC = table.Column<double>(type: "double precision", nullable: false),
                    lnumber = table.Column<string>(type: "text", nullable: false),
                    LCyilinder = table.Column<string>(type: "text", nullable: false),
                    LAxis = table.Column<int>(type: "integer", nullable: false),
                    LBC = table.Column<double>(type: "double precision", nullable: false),
                    PreGPD = table.Column<int>(type: "integer", nullable: false),
                    PreGRnumber = table.Column<string>(type: "text", nullable: false),
                    PreGRCyilinder = table.Column<string>(type: "text", nullable: false),
                    PreGRAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGRAddition = table.Column<string>(type: "text", nullable: false),
                    PreGRPrizma = table.Column<string>(type: "text", nullable: false),
                    PreGRIndex = table.Column<double>(type: "double precision", nullable: false),
                    PreGLnumber = table.Column<string>(type: "text", nullable: false),
                    PreGLCyilinder = table.Column<string>(type: "text", nullable: false),
                    PreGLRAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGLAddition = table.Column<string>(type: "text", nullable: false),
                    PreGLPrizma = table.Column<string>(type: "text", nullable: false),
                    PreGLIndex = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custumers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Custumers");
        }
    }
}
